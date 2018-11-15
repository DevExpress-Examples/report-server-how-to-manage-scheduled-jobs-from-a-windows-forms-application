<!-- default file list -->
*Files to look at*:

* [ConnectionProviderExtensions.cs](./CS/ScheduledTasksAPIClientDemo/ConnectionProviderExtensions.cs) (VB: [ConnectionProviderExtensions.vb](./VB/ScheduledTasksAPIClientDemo/ConnectionProviderExtensions.vb))
* [MainForm.cs](./CS/ScheduledTasksAPIClientDemo/MainForm.cs) (VB: [MainForm.vb](./VB/ScheduledTasksAPIClientDemo/MainForm.vb))
* [Program.cs](./CS/ScheduledTasksAPIClientDemo/Program.cs) (VB: [Program.vb](./VB/ScheduledTasksAPIClientDemo/Program.vb))
* [ReportViewerForm.cs](./CS/ScheduledTasksAPIClientDemo/ReportViewerForm.cs) (VB: [ReportViewerForm.vb](./VB/ScheduledTasksAPIClientDemo/ReportViewerForm.vb))
* [SchedulerJobResultsForm.cs](./CS/ScheduledTasksAPIClientDemo/SchedulerJobResultsForm.cs) (VB: [SchedulerJobResultsForm.vb](./VB/ScheduledTasksAPIClientDemo/SchedulerJobResultsForm.vb))
* [SchedulerJobViewerForm.cs](./CS/ScheduledTasksAPIClientDemo/SchedulerJobViewerForm.cs) (VB: [SchedulerJobViewerForm.vb](./VB/ScheduledTasksAPIClientDemo/SchedulerJobViewerForm.vb))
* [WaitForm1.cs](./CS/ScheduledTasksAPIClientDemo/WaitForm1.cs) (VB: [WaitForm1.vb](./VB/ScheduledTasksAPIClientDemo/WaitForm1.vb))
<!-- default file list end -->
# Report Server - How to manage scheduled jobs from a Windows Forms application


<p>This example illustrates how to enable a client-side WinForms application to access the <a href="https://documentation.devexpress.com/#ReportServer/CustomDocument12432">Report Server</a> and remotely manage <a href="https://documentation.devexpress.com/#ReportServer/CustomDocument14364">scheduled jobs</a>.</p>
<p>For this application to be able to access the Report Server, make sure that the <strong>ServerAddress</strong> field in the application's <strong>MainForm.cs</strong> file matches the <a href="https://documentation.devexpress.com/#ReportServer/CustomDocument14370">Site URL</a> specified in your Report Server settings (it is set to "<strong><a href="http://localhost:83">http://localhost:83</a></strong>" by default).</p>
<p>To log into the Report Server, the application uses the Guest account by default, so it is required that this user is active (you can check this in the <a href="https://documentation.devexpress.com/#ReportServer/CustomDocument14361">User Accounts</a> panel).</p>
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/report-server-how-to-manage-scheduled-jobs-from-a-windows-forms-application-t431255/16.2.3+/media/b03db415-8653-11e6-80bf-00155d62480c.png"></p>
<p>On running the application, the main form displays a complete list of currently scheduled tasks (jobs). After selecting a task, you can do one of the following.</p>
<p>- To manage a specific task, click "<strong>Show Scheduled Task Parameters</strong>". On the invoked form, you can create a new task, as well as update, delete or execute the selected task.</p>
<p>- To inspect the logs stored for a task, click "<strong>Show Scheduled Task Results</strong>". On the invoked form, you can view the history of task executions along with results of each execution.</p>
<p> </p>
<p>The API that this application uses to access the Report Server is related to the following public namespaces.</p>
<p>- <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressReportServerServiceModelConnectionProviders">DevExpress.ReportServer.ServiceModel.ConnectionProviders</a></p>
<p>- <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressReportServerServiceModelClient">DevExpress.ReportServer.ServiceModel.Client</a></p>
<p>- <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressReportServerServiceModelDataContracts">DevExpress.ReportServer.ServiceModel.DataContracts</a></p>
<p>To learn more about the corresponding infrastructure, please consult with the DevExpress product documentation.</p>

<br/>


