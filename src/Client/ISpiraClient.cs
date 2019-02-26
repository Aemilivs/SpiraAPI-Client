using SpiraAPI.Client.Endpoints;

namespace SpiraAPI.Client.Client
{
    public interface ISpiraClient
    {
        ITestRunsEndpoint TestRuns { get; }
        ITestSetsEndpoint TestSets { get; }
    }
}
