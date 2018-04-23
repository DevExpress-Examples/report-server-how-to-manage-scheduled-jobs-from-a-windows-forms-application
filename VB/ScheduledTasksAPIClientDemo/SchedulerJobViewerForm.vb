Imports DevExpress.ReportServer.ServiceModel.ConnectionProviders
Imports DevExpress.ReportServer.ServiceModel.DataContracts
Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ScheduledTasksAPIClientDemo
    Partial Public Class SchedulerJobViewerForm
        Inherits Form

        #Region "inner classes"
        Private Class Info
            Public Property Name() As String
            Public Property Value() As Object
        End Class

        Private Class Parameter
            Public Property Name() As String
            Public Property Source() As SchedulerParametersSource
            Public Property Value() As Object
        End Class
        #End Region
        Private ReadOnly serverConnection As ConnectionProvider
        Private ReadOnly scheduledJobId As Integer

        Public Sub New(ByVal scheduledJobId As Integer, ByVal serverConnection As ConnectionProvider)
            InitializeComponent()
            Me.serverConnection = serverConnection
            Me.scheduledJobId = scheduledJobId
        End Sub

        ' The following code obtains information about a specific scheduled job from the server
        ' and enables you to remotely manage scheduled jobs on the client.
        ' Please note that managing jobs requires that appropriate access permissions are attributed 
        ' to the user account under which this application is connected to the Server.
        Private Sub SchedulerJobViewerForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            serverConnection.DoWithScheduledJobAsync(Function(x) x.GetScheduledJobAsync(scheduledJobId, Nothing)).ContinueWith(Sub(taskFunc)
                If taskFunc.IsFaulted Then
                    MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    FillScheduledJob(taskFunc.Result)
                End If
            End Sub, TaskScheduler.FromCurrentSynchronizationContext())
        End Sub

        Private Sub FillScheduledJob(ByVal scheduledJob As ScheduledJobDto)
            id.Text = String.Format("{0}", scheduledJob.Id)
            scheduledJobName.Text = scheduledJob.Name
            scheduledJobEnabled.Checked = scheduledJob.Enabled
            scheduledJobStartDate.DateTime = scheduledJob.StartDate.ToLocalTime()
            reportId.Text = String.Format("{0}", scheduledJob.ReportId)

            FillRecurrencyInfo(scheduledJob)
            FillParametersBinding(scheduledJob)
            FillParameters(scheduledJob)
            FillExternalSubscribers(scheduledJob)
            FillExportToShared(scheduledJob)
        End Sub

        #Region "Appointment"
        Private Sub FillRecurrencyInfo(ByVal scheduledJob As ScheduledJobDto)
            recurrencyInfo.Text = String.Empty
            Dim appointment = CreateAppointment(scheduledJob)
            If appointment Is Nothing Then
                Return
            End If
            Dim culture = Thread.CurrentThread.CurrentUICulture
            Dim infos = New List(Of Info)()
            infos.Add(New Info With { _
                .Name = "Description", _
                .Value = RecurrenceInfo.GetDescription(appointment, culture.DateTimeFormat.FirstDayOfWeek) _
            })
            infos.Add(New Info With { _
                .Name = "Next start", _
                .Value = GetNextDateDisplayText(appointment) _
            })
            recurrencyInfoGrid.DataSource = infos
            recurrencyInfoView.BestFitColumns()
        End Sub

        Private Function CreateAppointment(ByVal scheduledJob As ScheduledJobDto) As Appointment
            If String.IsNullOrEmpty(scheduledJob.SerializedRecurrenceInfo) Then
                Return Nothing
            End If
            Dim appointment = DevExpress.XtraScheduler.Compatibility.StaticAppointmentFactory.CreateAppointment(AppointmentType.Pattern)
            appointment.Start = scheduledJob.StartDate.ToLocalTime()
            appointment.RecurrenceInfo.FromXml(scheduledJob.SerializedRecurrenceInfo)
            appointment.RecurrenceInfo.Start = appointment.Start
            Return appointment
        End Function

        Private Function GetNextDateDisplayText(ByVal appointment As Appointment) As String
            Const ScheduledJobExpired As String = "Never (expired)"
            Const ScheduledJobExpiredFormat As String = "Never (expired on {0:d})"
            Dim calculator = OccurrenceCalculator.CreateInstance(appointment.RecurrenceInfo)
            Dim nextDate = calculator.FindNextOccurrenceTimeAfter(Date.Now, appointment)
            If nextDate <> DateTime.MaxValue Then
                Return nextDate.ToString("g")
            Else
                Dim lastDate = GetLastDate(appointment, calculator)
                Return If(lastDate IsNot Nothing, String.Format(ScheduledJobExpiredFormat, lastDate), ScheduledJobExpired)
            End If
        End Function


        Private Function GetLastDate(ByVal appointment As Appointment, ByVal calculator As OccurrenceCalculator) As Date?
            Dim index = calculator.CalcLastOccurrenceIndex(appointment)
            Return If(index >= 0, CType(appointment.GetOccurrence(index).Start, Date?), Nothing)
        End Function
        #End Region

        #Region "Parameters Binding"
        Private Sub FillParametersBinding(ByVal scheduledJob As ScheduledJobDto)
            Dim infos = New List(Of Info)()
            If scheduledJob.SchedulerParameters.Binding IsNot Nothing Then
                infos.Add(New Info With { _
                    .Name = "Data Model (id)", _
                    .Value = scheduledJob.SchedulerParameters.Binding.DataModelId _
                })
                infos.Add(New Info With { _
                    .Name = "Data Member", _
                    .Value = scheduledJob.SchedulerParameters.Binding.DataMember _
                })
                infos.Add(New Info With { _
                    .Name = "Email Field", _
                    .Value = scheduledJob.SchedulerParameters.Binding.EmailField _
                })
                infos.Add(New Info With { _
                    .Name = "Recipient Name Field", _
                    .Value = scheduledJob.SchedulerParameters.Binding.DisplayNameField _
                })
                parametersBindingGrid.DataSource = infos
                parametersBindingView.BestFitColumns()
            End If
        End Sub
        #End Region

        #Region "Report Parameters"
        Private Sub FillParameters(ByVal scheduledJob As ScheduledJobDto)
            Dim parameters = New List(Of Parameter)()
            For Each item In scheduledJob.SchedulerParameters.Parameters
                parameters.Add(New Parameter() With { _
                    .Name = item.Key, _
                    .Source = item.Value.Source, _
                    .Value = item.Value.Value _
                })
            Next item
            reportParametersGrid.DataSource = parameters
            reportParametersView.BestFitColumns()
        End Sub

        #End Region

        #Region "External Subscribers"
        Private Sub FillExternalSubscribers(ByVal scheduledJob As ScheduledJobDto)
            externalSubscribers.Text = scheduledJob.ExternalSubscribers
        End Sub
        #End Region

        #Region "Export to Shared Folder"
        Private Sub FillExportToShared(ByVal scheduledJob As ScheduledJobDto)
            exportToSharedFolder.Text = scheduledJob.ExportToSharedFolder
        End Sub
        #End Region


        #Region "Delete Task"
        Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
            serverConnection.DoWithScheduledJobAsync(Function(x) x.DeleteScheduledJobAsync(scheduledJobId, Nothing)).ContinueWith(Function(taskFunc) MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error), TaskContinuationOptions.OnlyOnFaulted)
        End Sub
        #End Region

        #Region "Update Task"
        Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
            serverConnection.DoWithScheduledJobAsync(Function(x) x.GetScheduledJobAsync(scheduledJobId, Nothing)).ContinueWith(Function(taskFunc)
                Dim scheduledJob = taskFunc.Result
                scheduledJob.Name = scheduledJobName.Text
                scheduledJob.Enabled = scheduledJobEnabled.Checked
                scheduledJob.StartDate = scheduledJobStartDate.DateTime
                scheduledJob.ExternalSubscribers = externalSubscribers.Text
                scheduledJob.ExportToSharedFolder = exportToSharedFolder.Text
                Dim selectedReportId As Integer = Nothing
                If Integer.TryParse(reportId.Text, selectedReportId) Then
                    scheduledJob.ReportId = selectedReportId
                Else
                    scheduledJob.ReportId = Nothing
                End If
                Return serverConnection.DoWithScheduledJobAsync(Function(x) x.UpdateScheduledJobAsync(scheduledJob, Nothing))
            End Function).Unwrap().ContinueWith(Function(taskFunc) MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error), New CancellationToken(), TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext())
        End Sub
        #End Region

        #Region "Create Task"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreate.Click
            Dim scheduledJob = New ScheduledJobDto()
            scheduledJob.TaskMode = ScheduledTaskMode.BillingStatement
            scheduledJob.Name = scheduledJobName.Text
            scheduledJob.Enabled = scheduledJobEnabled.Checked
            scheduledJob.StartDate = scheduledJobStartDate.DateTime.ToUniversalTime()

            Using apt = DevExpress.XtraScheduler.Compatibility.StaticAppointmentFactory.CreateAppointment(AppointmentType.Pattern)
                apt.RecurrenceInfo.Type = RecurrenceType.Daily
                apt.RecurrenceInfo.Start = scheduledJob.StartDate
                apt.RecurrenceInfo.WeekDays = WeekDays.WorkDays
                scheduledJob.SerializedRecurrenceInfo = apt.RecurrenceInfo.ToXml()
            End Using

            scheduledJob.SchedulerParameters = New SchedulerParameters() With { _
                .Binding = New ParametersBinding() With { _
                    .DataModelId = 1, _
                    .DataMember = "vwEmployees", _
                    .EmailField = "Email", _
                    .DisplayNameField = "DisplayName" _
                } _
            }
            scheduledJob.InternalSubscribers = Nothing
            scheduledJob.ExternalSubscribers = externalSubscribers.Text
            scheduledJob.ExportToSharedFolder = exportToSharedFolder.Text
            Dim selectedReportId As Integer = Nothing
            If Integer.TryParse(reportId.Text, selectedReportId) Then
                scheduledJob.ReportId = selectedReportId
            Else
                scheduledJob.ReportId = Nothing
            End If

            serverConnection.DoWithScheduledJobAsync(Function(x) x.CreateScheduledJobAsync(scheduledJob, Nothing)).ContinueWith(Sub(taskFunc)
                If taskFunc.IsFaulted Then
                    MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    id.Text = taskFunc.Result.ToString()
                End If
            End Sub, TaskScheduler.FromCurrentSynchronizationContext())
        End Sub
        #End Region

        Private Sub btnExecute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExecute.Click
            serverConnection.DoWithScheduledJobAsync(Function(x) x.ExecuteJobAsync(scheduledJobId, Nothing, Nothing))
        End Sub
    End Class
End Namespace
