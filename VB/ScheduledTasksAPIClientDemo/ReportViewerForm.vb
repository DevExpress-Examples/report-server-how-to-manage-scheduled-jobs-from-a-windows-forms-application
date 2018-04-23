Imports DevExpress.ReportServer.Printing
Imports DevExpress.ReportServer.ServiceModel.DataContracts
Imports System.Windows.Forms

Namespace ScheduledTasksAPIClientDemo
    Partial Public Class ReportViewerForm
        Inherits Form

        Public Sub New(ByVal reportId As Integer)
            InitializeComponent()
            remoteDocumentSource1.ServiceUri = MainForm.ServerAddress
            remoteDocumentSource1.AuthenticationType = AuthenticationType.Guest
            remoteDocumentSource1.ReportIdentity = New GeneratedReportIdentity(reportId)
            remoteDocumentSource1.CreateDocument()
        End Sub
    End Class
End Namespace
