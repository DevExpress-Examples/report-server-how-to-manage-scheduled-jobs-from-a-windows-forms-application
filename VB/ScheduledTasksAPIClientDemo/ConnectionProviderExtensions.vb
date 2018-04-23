Imports DevExpress.ReportServer.ServiceModel.Client
Imports DevExpress.ReportServer.ServiceModel.ConnectionProviders
Imports System
Imports System.Threading.Tasks

Namespace ScheduledTasksAPIClientDemo
    Public Module ConnectionProviderExtensions
        <System.Runtime.CompilerServices.Extension> _
        Public Function DoWithScheduledJobAsync(Of T)(ByVal serverConnection As ConnectionProvider, ByVal func As Func(Of IReportServerClient, Task(Of T))) As Task(Of T)
            Return serverConnection.ConnectAsync().ContinueWith(Function(taskFunc)
                Dim client As IReportServerClient = taskFunc.Result
                Return func(client)
            End Function).Unwrap()
        End Function

        <System.Runtime.CompilerServices.Extension> _
        Public Function DoWithScheduledJobAsync(ByVal serverConnection As ConnectionProvider, ByVal func As Func(Of IReportServerClient, Task)) As Task
            Return serverConnection.ConnectAsync().ContinueWith(Function(task) func(task.Result)).Unwrap()
        End Function
    End Module
End Namespace
