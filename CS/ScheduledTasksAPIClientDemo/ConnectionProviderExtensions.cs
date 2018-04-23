using DevExpress.ReportServer.ServiceModel.Client;
using DevExpress.ReportServer.ServiceModel.ConnectionProviders;
using System;
using System.Threading.Tasks;

namespace ScheduledTasksAPIClientDemo {
    public static class ConnectionProviderExtensions {
        public static Task<T> DoWithScheduledJobAsync<T>(this ConnectionProvider serverConnection, Func<IReportServerClient, Task<T>> func) {
            return serverConnection
                .ConnectAsync()
                .ContinueWith(taskFunc => {
                    IReportServerClient client = taskFunc.Result;
                    return func(client);
                })
                .Unwrap();
        }

        public static Task DoWithScheduledJobAsync(this ConnectionProvider serverConnection, Func<IReportServerClient, Task> func) {
            return serverConnection
                .ConnectAsync()
                .ContinueWith(task => func(task.Result))
                .Unwrap();
        }
    }
}
