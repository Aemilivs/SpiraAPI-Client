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

        private ITestCasesEndpoint _testCases;
        public ITestCasesEndpoint TestCases => _testCases ?? (_testCases = new TestCasesEndpoint(_connection));

        private ITestSetsEndpoint _testSet;
        public ITestSetsEndpoint TestSets => _testSet ?? (_testSet = new TestSetsEndpoint(_connection));

        private ITestSetFolderEndpoint _testSetFolder;
        public ITestSetFolderEndpoint TestSetFolders => _testSetFolder ?? (_testSetFolder = new TestSetFolderEndpoint(_connection));

        private ITestCaseFolderEndpoint _testCaseFolder;
        public ITestCaseFolderEndpoint TestCaseFolders => _testCaseFolder ?? (_testCaseFolder = new TestCaseFolderEndpoint(_connection));
    }
}
