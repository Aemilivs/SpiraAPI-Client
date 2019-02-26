using System;
using System.Linq;
using System.Threading;
using SpiraAPI.Client.DTO;
using SpiraAPI.Client.Client;
using SpiraAPI.Client.Middleware;

namespace Example
{
    class Program
    {
        private class ApplicationRequest : ISpiraCredentials
        {
            public string Username => "vemelin";
            public string RsaToken => "E2A69618-0FC3-438A-9B03-73674E4231BE";
        }

        public static void Main()
        {
            var endpoint = "http://spira201.be.monster.com/SpiraTest/Services/v5_0/RestService.svc/projects/92/";
            var factory = new SpiraClientFactory(endpoint);

            var client = factory.Create(new ApplicationRequest());

            var runs = client.TestSets.GetTestCases(63514);

        }

        private static string GetCurrentTime()
        {
            var timeStamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            return $"/Date({timeStamp}000+0000)/";
        }

        private static void SignTestRun(TestRunDTO run)
        {
            run.StartDate = GetCurrentTime();
            run.RunnerName = Environment.MachineName;
            Thread.Sleep(TimeSpan.FromSeconds(1));
            run.ExecutionStatusId = ExecutionStatusIdEnum.Failed;
            run.EndDate = GetCurrentTime();
            run.RunnerName = "Test run name";
            run.RunnerMessage = "Test run message";
            run.RunnerStackTrace = @"Test run description";
        }
    }
}
