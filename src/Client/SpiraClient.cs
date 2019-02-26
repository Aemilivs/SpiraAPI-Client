using SpiraAPI.Client.Connection;
using SpiraAPI.Client.Endpoints;

namespace SpiraAPI.Client.Client
{
    internal class SpiraClient : ISpiraClient
    {
        private readonly ISpiraConnection _connection;

        public SpiraClient(ISpiraConnection connection)
        {
            _connection = connection;
        }

        private ITestRunsEndpoint _testRuns;
        public ITestRunsEndpoint TestRuns => _testRuns ?? (_testRuns = new TestRunsEndpoint(_connection));

        private ITestSetsEndpoint _testSet;
        public ITestSetsEndpoint TestSets => _testSet ?? (_testSet = new TestSetsEndpoint(_connection));

    }
}
