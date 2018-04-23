using DevExpress.ReportServer.ServiceModel.ConnectionProviders;
using DevExpress.ReportServer.ServiceModel.DataContracts;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduledTasksAPIClientDemo {
    public partial class SchedulerJobViewerForm : Form {
        #region inner classes
        class Info {
            public string Name { get; set; }
            public object Value { get; set; }
        }

        class Parameter {
            public string Name { get; set; }
            public SchedulerParametersSource Source { get; set; }
            public object Value { get; set; }
        }
        #endregion
        readonly ConnectionProvider serverConnection;
        readonly int scheduledJobId;

        public SchedulerJobViewerForm(int scheduledJobId, ConnectionProvider serverConnection) {
            InitializeComponent();
            this.serverConnection = serverConnection;
            this.scheduledJobId = scheduledJobId;
        }

        // The following code obtains information about a specific scheduled job from the server
        // and enables you to remotely manage scheduled jobs on the client.
        // Please note that managing jobs requires that appropriate access permissions are attributed 
        // to the user account under which this application is connected to the Server.
        private void SchedulerJobViewerForm_Load(object sender, EventArgs e) {
            serverConnection.DoWithScheduledJobAsync(x => x.GetScheduledJobAsync(scheduledJobId, null))
                .ContinueWith(taskFunc => {
                    if (taskFunc.IsFaulted) {
                        MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // 
                    }
                    else {
                        FillScheduledJob(taskFunc.Result);
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        void FillScheduledJob(ScheduledJobDto scheduledJob) {
            id.Text = string.Format("{0}", scheduledJob.Id);
            scheduledJobName.Text = scheduledJob.Name;
            scheduledJobEnabled.Checked = scheduledJob.Enabled;
            scheduledJobStartDate.DateTime = scheduledJob.StartDate.ToLocalTime();
            reportId.Text = string.Format("{0}", scheduledJob.ReportId);

            FillRecurrencyInfo(scheduledJob);
            FillParametersBinding(scheduledJob);
            FillParameters(scheduledJob);
            FillExternalSubscribers(scheduledJob);
            FillExportToShared(scheduledJob);
        }

        #region Appointment
        void FillRecurrencyInfo(ScheduledJobDto scheduledJob) {
            recurrencyInfo.Text = string.Empty;
            var appointment = CreateAppointment(scheduledJob);
            if (appointment == null) {
                return;
            }
            var culture = Thread.CurrentThread.CurrentUICulture;
            var infos = new List<Info>();
            infos.Add(new Info { Name = "Description", Value = RecurrenceInfo.GetDescription(appointment, culture.DateTimeFormat.FirstDayOfWeek) });
            infos.Add(new Info { Name = "Next start", Value = GetNextDateDisplayText(appointment) });
            recurrencyInfoGrid.DataSource = infos;
            recurrencyInfoView.BestFitColumns();
        }

        Appointment CreateAppointment(ScheduledJobDto scheduledJob) {
            if (string.IsNullOrEmpty(scheduledJob.SerializedRecurrenceInfo)) {
                return null;
            }
            var appointment = DevExpress.XtraScheduler.Compatibility.StaticAppointmentFactory.CreateAppointment(AppointmentType.Pattern);
            appointment.Start = scheduledJob.StartDate.ToLocalTime();
            appointment.RecurrenceInfo.FromXml(scheduledJob.SerializedRecurrenceInfo);
            appointment.RecurrenceInfo.Start = appointment.Start;
            return appointment;
        }

        string GetNextDateDisplayText(Appointment appointment) {
            const string ScheduledJobExpired = "Never (expired)";
            const string ScheduledJobExpiredFormat = "Never (expired on {0:d})";
            var calculator = OccurrenceCalculator.CreateInstance(appointment.RecurrenceInfo);
            var nextDate = calculator.FindNextOccurrenceTimeAfter(DateTime.Now, appointment);
            if (nextDate != DateTime.MaxValue) {
                return nextDate.ToString("g");
            }
            else {
                var lastDate = GetLastDate(appointment, calculator);
                return lastDate != null
                    ? string.Format(ScheduledJobExpiredFormat, lastDate)
                    : ScheduledJobExpired;
            }
        }


        DateTime? GetLastDate(Appointment appointment, OccurrenceCalculator calculator) {
            var index = calculator.CalcLastOccurrenceIndex(appointment);
            return index >= 0
                ? (DateTime?)appointment.GetOccurrence(index).Start
                : null;
        }
        #endregion

        #region Parameters Binding
        void FillParametersBinding(ScheduledJobDto scheduledJob) {
            var infos = new List<Info>();
            if (scheduledJob.SchedulerParameters.Binding != null) {
                infos.Add(new Info { Name = "Data Model (id)", Value = scheduledJob.SchedulerParameters.Binding.DataModelId });
                infos.Add(new Info { Name = "Data Member", Value = scheduledJob.SchedulerParameters.Binding.DataMember });
                infos.Add(new Info { Name = "Email Field", Value = scheduledJob.SchedulerParameters.Binding.EmailField });
                infos.Add(new Info { Name = "Recipient Name Field", Value = scheduledJob.SchedulerParameters.Binding.DisplayNameField });
                parametersBindingGrid.DataSource = infos;
                parametersBindingView.BestFitColumns();
            }
        }
        #endregion

        #region Report Parameters
        void FillParameters(ScheduledJobDto scheduledJob) {
            var parameters = new List<Parameter>();
            foreach (var item in scheduledJob.SchedulerParameters.Parameters) {
                parameters.Add(new Parameter() { Name = item.Key, Source = item.Value.Source, Value = item.Value.Value });
            }
            reportParametersGrid.DataSource = parameters;
            reportParametersView.BestFitColumns();
        }

        #endregion

        #region External Subscribers
        void FillExternalSubscribers(ScheduledJobDto scheduledJob) {
            externalSubscribers.Text = scheduledJob.ExternalSubscribers;
        }
        #endregion

        #region Export to Shared Folder
        void FillExportToShared(ScheduledJobDto scheduledJob) {
            exportToSharedFolder.Text = scheduledJob.ExportToSharedFolder;
        }
        #endregion


        #region Delete Task
        private void btnDelete_Click(object sender, EventArgs e) {
            serverConnection
                .DoWithScheduledJobAsync(x => x.DeleteScheduledJobAsync(scheduledJobId, null))
                .ContinueWith(
                    taskFunc => MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error),
                    TaskContinuationOptions.OnlyOnFaulted);
        }
        #endregion

        #region Update Task
        private void btnUpdate_Click(object sender, EventArgs e) {
            serverConnection
                .DoWithScheduledJobAsync(x => x.GetScheduledJobAsync(scheduledJobId, null))
                .ContinueWith(taskFunc => {
                    var scheduledJob = taskFunc.Result;
                    scheduledJob.Name = scheduledJobName.Text;
                    scheduledJob.Enabled = scheduledJobEnabled.Checked;
                    scheduledJob.StartDate = scheduledJobStartDate.DateTime;
                    scheduledJob.ExternalSubscribers = externalSubscribers.Text;
                    scheduledJob.ExportToSharedFolder = exportToSharedFolder.Text;
                    int selectedReportId;
                    if (int.TryParse(reportId.Text, out selectedReportId)) {
                        scheduledJob.ReportId = selectedReportId;
                    }
                    else {
                        scheduledJob.ReportId = null;
                    }
                    return serverConnection.DoWithScheduledJobAsync(x => x.UpdateScheduledJobAsync(scheduledJob, null));
                })
                .Unwrap()
                .ContinueWith(taskFunc => MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    , new CancellationToken(), TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());
        }
        #endregion

        #region Create Task
        private void btnCreate_Click(object sender, EventArgs e) {
            var scheduledJob = new ScheduledJobDto();
            scheduledJob.TaskMode = ScheduledTaskMode.BillingStatement;
            scheduledJob.Name = scheduledJobName.Text;
            scheduledJob.Enabled = scheduledJobEnabled.Checked;
            scheduledJob.StartDate = scheduledJobStartDate.DateTime.ToUniversalTime();

            using (var apt = DevExpress.XtraScheduler.Compatibility.StaticAppointmentFactory.CreateAppointment(AppointmentType.Pattern)) {
                apt.RecurrenceInfo.Type = RecurrenceType.Daily;
                apt.RecurrenceInfo.Start = scheduledJob.StartDate;
                apt.RecurrenceInfo.WeekDays = WeekDays.WorkDays;
                scheduledJob.SerializedRecurrenceInfo = apt.RecurrenceInfo.ToXml();
            }

            scheduledJob.SchedulerParameters = new SchedulerParameters() {
                Binding = new ParametersBinding() {
                    DataModelId = 1,
                    DataMember = "vwEmployees",
                    EmailField = "Email",
                    DisplayNameField = "DisplayName"
                }
            };
            scheduledJob.InternalSubscribers = null;
            scheduledJob.ExternalSubscribers = externalSubscribers.Text;
            scheduledJob.ExportToSharedFolder = exportToSharedFolder.Text;
            int selectedReportId;
            if (int.TryParse(reportId.Text, out selectedReportId)) {
                scheduledJob.ReportId = selectedReportId;
            }
            else {
                scheduledJob.ReportId = null;
            }

            serverConnection
                .DoWithScheduledJobAsync(x => x.CreateScheduledJobAsync(scheduledJob, null))
                .ContinueWith(taskFunc => {
                    if (taskFunc.IsFaulted) {
                        MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        id.Text = taskFunc.Result.ToString();
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        #endregion

        private void btnExecute_Click(object sender, EventArgs e) {
            serverConnection.DoWithScheduledJobAsync(x => x.ExecuteJobAsync(scheduledJobId, null, null));
        }
    }
}
