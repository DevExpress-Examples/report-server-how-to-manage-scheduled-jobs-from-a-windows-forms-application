using DevExpress.ReportServer.ServiceModel.ConnectionProviders;
using DevExpress.ReportServer.ServiceModel.DataContracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduledTasksAPIClientDemo {
    public partial class SchedulerJobResultsForm : Form {
        #region inner classes
        class Info {
            public string Name { get; set; }
            public object Value { get; set; }
        }
        #endregion

        readonly ConnectionProvider serverConnection;
        readonly int scheduledJobId;

        public SchedulerJobResultsForm(int scheduledJobId, string scheduledJobName, ConnectionProvider serverConnection) {
            InitializeComponent();
            this.serverConnection = serverConnection;
            this.scheduledJobId = scheduledJobId;
            this.id.Text = string.Format("{0}", scheduledJobId);
            this.scheduledJobName.Text = scheduledJobName;
        }

        // The following code obtains the logs corresponding to a selected scheduled job from the server
        // for the period of 100 days prior to the current date
        // and displays the total number of obtained logs.
        private void SchedulerJobResults_Load(object sender, EventArgs e) {
            splashScreenManager1.ShowWaitForm();
            serverConnection.DoWithScheduledJobAsync(x => x.GetScheduledJobLogsAsync(scheduledJobId,
                new DataPaginationByDate() {
                    From = DateTime.Now - TimeSpan.FromDays(100),
                    Interval = TimeSpan.FromDays(100)
                }, null))
                .ContinueWith(taskFunc => {
                    splashScreenManager1.CloseWaitForm();
                    if (taskFunc.IsFaulted) {
                        MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        FillScheduledJobLogs(taskFunc.Result);
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext())
                .ContinueWith((taskFunc) => {
                    return serverConnection.DoWithScheduledJobAsync(x => x.GetScheduledJobLogsCountAsync(scheduledJobId, null));
                })
                .Unwrap()
                .ContinueWith(taskFunc => {
                    logsLabel.Text = string.Format("Logs count: {0}", taskFunc.Result);
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        // The following method populates a grid control with a list 
        // of job executions and the dates on which they were started.
        void FillScheduledJobLogs(IEnumerable<ScheduledJobLogDto> scheduledJobLogs) {
            jobLogsView.GridControl.DataSource = scheduledJobLogs;
        }

        // The following code displays information about the last 100 results of a job's execution.
        // This information includes the date and time when the result was obtained, 
        // as well as the status or result of its execution and the total number of results.
        private void jobLogsView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            jobResultsGrid.DataSource = null;
            resultInfoGrid.DataSource = null;
            var selectedId = jobLogsView.GetFocusedRowCellValue("Id") as int?;
            if (!selectedId.HasValue) {
                return;
            }

            splashScreenManager1.ShowWaitForm();
            serverConnection.DoWithScheduledJobAsync(x => x.GetScheduledJobResultsAsync(selectedId.Value,
                new DataPaginationByCount() {
                    Offset = 0,
                    Count = 100
                }, null))
                .ContinueWith(taskFunc => {
                    splashScreenManager1.CloseWaitForm();
                    if (taskFunc.IsFaulted) {
                        MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        FillScheduledJobResults(taskFunc.Result, selectedId.Value);
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext())
                .ContinueWith((taskFunc) => {
                    return serverConnection.DoWithScheduledJobAsync(x => x.GetScheduledJobResultsCountAsync(selectedId.Value, null));
                })
                .Unwrap()
                .ContinueWith(taskFunc => {
                    resultsLabel.Text = string.Format("Results count: {0}", taskFunc.Result);
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        void FillScheduledJobResults(IEnumerable<ScheduledJobResultCatalogItemDto> scheduledJobResults, int scheduledJobLogId) {
            jobResultsView.GridControl.DataSource = scheduledJobResults;
        }

        // The following code displays information about the selected job execution result.
        // This information includes a list of email subscribers, 
        // parameter values at the moment of execution, and (when applicable)
        // the reason why the task execution failed.    
        private void jobResultsView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            previewDocumentButton.Enabled = false;
            resultInfoGrid.DataSource = null;
            if (jobResultsView.SelectedRowsCount == 0) {
                return;
            }
            var selectedId = jobResultsView.GetFocusedRowCellValue("Id") as int?;
            if (!selectedId.HasValue) {
                return;
            }
            var status = jobResultsView.GetFocusedRowCellValue("Status") as JobResultStatus?;
            previewDocumentButton.Enabled = status.HasValue && status.Value == JobResultStatus.Success;

            splashScreenManager1.ShowWaitForm();
            serverConnection.DoWithScheduledJobAsync(x => x.GetScheduledJobResultAsync(selectedId.Value, null))
                .ContinueWith(taskFunc => {
                    splashScreenManager1.CloseWaitForm();
                    if (taskFunc.IsFaulted) {
                        MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        FillScheduledJobResultInfo(taskFunc.Result);
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        void FillScheduledJobResultInfo(ScheduledJobResultDto scheduledJobResult) {
            var infos = new List<Info>();
            infos.Add(new Info { Name = "Recipients", Value = scheduledJobResult.Recipients });
            infos.Add(new Info { Name = "Reason", Value = scheduledJobResult.Message });
            infos.Add(new Info { Name = "Parameters", Value = scheduledJobResult.ExecutionParameters });
            resultInfoGrid.DataSource = infos;
            resultInfoView.BestFitColumns();
        }

        // The following code invokes a Print Preview form displaying 
        // the report document created by a selected task.
        private void previewDocumentButton_Click(object sender, EventArgs e) {
            if (jobResultsView.SelectedRowsCount == 0) {
                return;
            }
            var selectedId = jobResultsView.GetFocusedRowCellValue("Id") as int?;
            if (!selectedId.HasValue) {
                return;
            }

            ReportViewerForm form = new ReportViewerForm(selectedId.Value) { Owner = this };
            form.ShowDialog();
        }




    }
}
