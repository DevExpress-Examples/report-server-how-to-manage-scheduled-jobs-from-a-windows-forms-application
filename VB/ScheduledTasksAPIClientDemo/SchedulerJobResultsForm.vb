Imports DevExpress.ReportServer.ServiceModel.ConnectionProviders
Imports DevExpress.ReportServer.ServiceModel.DataContracts
Imports System
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ScheduledTasksAPIClientDemo
    Partial Public Class SchedulerJobResultsForm
        Inherits Form

        #Region "inner classes"
        Private Class Info
            Public Property Name() As String
            Public Property Value() As Object
        End Class
        #End Region

        Private ReadOnly serverConnection As ConnectionProvider
        Private ReadOnly scheduledJobId As Integer

        Public Sub New(ByVal scheduledJobId As Integer, ByVal scheduledJobName As String, ByVal serverConnection As ConnectionProvider)
            InitializeComponent()
            Me.serverConnection = serverConnection
            Me.scheduledJobId = scheduledJobId
            Me.id.Text = String.Format("{0}", scheduledJobId)
            Me.scheduledJobName.Text = scheduledJobName
        End Sub

        ' The following code obtains the logs corresponding to a selected scheduled job from the server
        ' for the period of 100 days prior to the current date
        ' and displays the total number of obtained logs.
        Private Sub SchedulerJobResults_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            splashScreenManager1.ShowWaitForm()
            serverConnection.DoWithScheduledJobAsync(Function(x) x.GetScheduledJobLogsAsync(scheduledJobId, New DataPaginationByDate() With { _
                .From = Date.Now.Subtract(TimeSpan.FromDays(100)), _
                .Interval = TimeSpan.FromDays(100) _
            }, Nothing)).ContinueWith(Sub(taskFunc)
                splashScreenManager1.CloseWaitForm()
                If taskFunc.IsFaulted Then
                    MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    FillScheduledJobLogs(taskFunc.Result)
                End If
            End Sub, TaskScheduler.FromCurrentSynchronizationContext()).ContinueWith(Function(taskFunc)
                Return serverConnection.DoWithScheduledJobAsync(Function(x) x.GetScheduledJobLogsCountAsync(scheduledJobId, Nothing))
            End Function).Unwrap().ContinueWith(Sub(taskFunc)
                logsLabel.Text = String.Format("Logs count: {0}", taskFunc.Result)
            End Sub, TaskScheduler.FromCurrentSynchronizationContext())
        End Sub

        ' The following method populates a grid control with a list 
        ' of job executions and the dates on which they were started.
        Private Sub FillScheduledJobLogs(ByVal scheduledJobLogs As IEnumerable(Of ScheduledJobLogDto))
            jobLogsView.GridControl.DataSource = scheduledJobLogs
        End Sub

        ' The following code displays information about the last 100 results of a job's execution.
        ' This information includes the date and time when the result was obtained, 
        ' as well as the status or result of its execution and the total number of results.
        Private Sub jobLogsView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles jobLogsView.FocusedRowChanged
            jobResultsGrid.DataSource = Nothing
            resultInfoGrid.DataSource = Nothing
            Dim selectedId = CType(jobLogsView.GetFocusedRowCellValue("Id"), Integer?)
            If Not selectedId.HasValue Then
                Return
            End If

            splashScreenManager1.ShowWaitForm()
            serverConnection.DoWithScheduledJobAsync(Function(x) x.GetScheduledJobResultsAsync(selectedId.Value, New DataPaginationByCount() With { _
                .Offset = 0, _
                .Count = 100 _
            }, Nothing)).ContinueWith(Sub(taskFunc)
                splashScreenManager1.CloseWaitForm()
                If taskFunc.IsFaulted Then
                    MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    FillScheduledJobResults(taskFunc.Result, selectedId.Value)
                End If
            End Sub, TaskScheduler.FromCurrentSynchronizationContext()).ContinueWith(Function(taskFunc)
                Return serverConnection.DoWithScheduledJobAsync(Function(x) x.GetScheduledJobResultsCountAsync(selectedId.Value, Nothing))
            End Function).Unwrap().ContinueWith(Sub(taskFunc)
                resultsLabel.Text = String.Format("Results count: {0}", taskFunc.Result)
            End Sub, TaskScheduler.FromCurrentSynchronizationContext())
        End Sub

        Private Sub FillScheduledJobResults(ByVal scheduledJobResults As IEnumerable(Of ScheduledJobResultCatalogItemDto), ByVal scheduledJobLogId As Integer)
            jobResultsView.GridControl.DataSource = scheduledJobResults
        End Sub

        ' The following code displays information about the selected job execution result.
        ' This information includes a list of email subscribers, 
        ' parameter values at the moment of execution, and (when applicable)
        ' the reason why the task execution failed.    
        Private Sub jobResultsView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles jobResultsView.FocusedRowChanged
            previewDocumentButton.Enabled = False
            resultInfoGrid.DataSource = Nothing
            If jobResultsView.SelectedRowsCount = 0 Then
                Return
            End If
            Dim selectedId = CType(jobResultsView.GetFocusedRowCellValue("Id"), Integer?)
            If Not selectedId.HasValue Then
                Return
            End If
            Dim status = CType(jobResultsView.GetFocusedRowCellValue("Status"), JobResultStatus?)
            previewDocumentButton.Enabled = status.HasValue AndAlso status.Value = JobResultStatus.Success

            splashScreenManager1.ShowWaitForm()
            serverConnection.DoWithScheduledJobAsync(Function(x) x.GetScheduledJobResultAsync(selectedId.Value, Nothing)).ContinueWith(Sub(taskFunc)
                splashScreenManager1.CloseWaitForm()
                If taskFunc.IsFaulted Then
                    MessageBox.Show(taskFunc.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    FillScheduledJobResultInfo(taskFunc.Result)
                End If
            End Sub, TaskScheduler.FromCurrentSynchronizationContext())
        End Sub

        Private Sub FillScheduledJobResultInfo(ByVal scheduledJobResult As ScheduledJobResultDto)
            Dim infos = New List(Of Info)()
            infos.Add(New Info With { _
                .Name = "Recipients", _
                .Value = scheduledJobResult.Recipients _
            })
            infos.Add(New Info With { _
                .Name = "Reason", _
                .Value = scheduledJobResult.Message _
            })
            infos.Add(New Info With { _
                .Name = "Parameters", _
                .Value = scheduledJobResult.ExecutionParameters _
            })
            resultInfoGrid.DataSource = infos
            resultInfoView.BestFitColumns()
        End Sub

        ' The following code invokes a Print Preview form displaying 
        ' the report document created by a selected task.
        Private Sub previewDocumentButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles previewDocumentButton.Click
            If jobResultsView.SelectedRowsCount = 0 Then
                Return
            End If
            Dim selectedId = CType(jobResultsView.GetFocusedRowCellValue("Id"), Integer?)
            If Not selectedId.HasValue Then
                Return
            End If

            Dim form As New ReportViewerForm(selectedId.Value) With {.Owner = Me}
            form.ShowDialog()
        End Sub




    End Class
End Namespace
