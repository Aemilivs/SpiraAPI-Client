using System.Collections.Generic;
using System.Threading.Tasks;
using SpiraAPI.Client.DTO;
using SpiraAPI.Client.Connection;

namespace SpiraAPI.Client.Endpoints
{
    public interface ITestRunsEndpoint
    {
        TestRunDTO GetTestRun(int testRunId);
        Task<TestRunDTO> GetTestRunAsync(int testRunId);
        TestRunDTO GetAutomatedTestRun(int testRunId);
        Task<TestRunDTO> GetAutomatedTestRunAsync(int testRunId);
        IEnumerable<TestRunDTO> CreateTestRuns(int testSetId);
        Task<IEnumerable<TestRunDTO>> CreateTestRunsAsync(int testSetId);
        TestRunDTO PutTestRun(TestRunDTO testRun);
        Task<TestRunDTO> PutTestRunAsync(TestRunDTO testRun);
    }

    internal class TestRunsEndpoint : SpiraEndpoint, ITestRunsEndpoint
    {
        protected override string EndpointUrl => "test-runs";

        public TestRunsEndpoint(ISpiraConnection connection) : base(connection) { }

        public TestRunDTO GetTestRun(int testRunId) => Get<TestRunDTO>($"{testRunId}");
        public Task<TestRunDTO> GetTestRunAsync(int testRunId) => GetAsync<TestRunDTO>($"{testRunId}");

        public TestRunDTO GetAutomatedTestRun(int testRunId) => Get<TestRunDTO>($"{testRunId}/Automated");
        public Task<TestRunDTO> GetAutomatedTestRunAsync(int testRunId) => GetAsync<TestRunDTO>($"{testRunId}/Automated");

        public IEnumerable<TestRunDTO> CreateTestRuns(int testSetId) => 
            Post<TestRunDTO, IEnumerable<TestRunDTO>>($"create/test_set/{testSetId}", null);
        public Task<IEnumerable<TestRunDTO>> CreateTestRunsAsync(int testSetId) => 
            PostAsync<TestRunDTO, IEnumerable<TestRunDTO>>($"create/test_set/{testSetId}", null);

        public TestRunDTO PutTestRun(TestRunDTO testRun) => Post<TestRunDTO, TestRunDTO>($"record", testRun);
        public Task<TestRunDTO> PutTestRunAsync(TestRunDTO testRun) => PostAsync<TestRunDTO, TestRunDTO>($"record", testRun);
    }
}
