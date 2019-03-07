using SpiraAPI.Client.Endpoints;

namespace SpiraAPI.Client.Client
{
    public interface ISpiraClient
    {
        ITestRunsEndpoint TestRuns { get; }
        ITestCasesEndpoint TestCases { get; }
        ITestSetsEndpoint TestSets { get; }
    }
}
