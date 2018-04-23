using DevExpress.ReportServer.Printing;
using DevExpress.ReportServer.ServiceModel.DataContracts;
using System.Windows.Forms;

namespace ScheduledTasksAPIClientDemo {
    public partial class ReportViewerForm : Form {

        public ReportViewerForm(int reportId) {
            InitializeComponent();
            remoteDocumentSource1.ServiceUri = MainForm.ServerAddress;
            remoteDocumentSource1.AuthenticationType = AuthenticationType.Guest;
            remoteDocumentSource1.ReportIdentity = new GeneratedReportIdentity(reportId);
            remoteDocumentSource1.CreateDocument();
        }
    }
}
