using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Spira.Client.DTO.JsonResponses;
using SpiraAPI.Client.DTO;
using SpiraAPI.Client.Connection;

namespace SpiraAPI.Client.Endpoints
{
    public interface ITestCasesEndpoint
    {
        TestCaseDTO GetTestCase(int testCaseId);
        Task<TestCaseDTO> GetTestCaseAsync(int testCaseId);

        IEnumerable<TestRunDTO> GetTestRuns(
            int testCaseId,
            int starting_row = 0,
            int number_of_rows = int.MaxValue, 
            int sort_field = 0,
            string sort_direction = "desc");
        Task<IEnumerable<TestRunDTO>> GetTestRunsAsync(
            int testCaseId,
            int starting_row = 0,
            int number_of_rows = int.MaxValue, 
            int sort_field = 0,
            string sort_direction = "desc");

        TestCaseDTO CreateTestCase(TestCaseDTO testCase);
        Task<TestCaseDTO> CreateTestCaseAsync(TestCaseDTO testCase);

        TestCaseDTO UpdateTestCase(TestCaseDTO testCase);
        Task<TestCaseDTO> UpdateTestCaseAsync(TestCaseDTO testCase);

        TestCaseDTO DeleteTestCase(int testCaseId);
        Task<TestCaseDTO> DeleteTestCaseAsync(int testCaseId);
    }

    internal class TestCasesEndpoint : SpiraEndpoint, ITestCasesEndpoint
    {
        protected override string EndpointUrl => "test-cases";

        public TestCasesEndpoint(ISpiraConnection connection) : base(connection) { }

        public TestCaseDTO GetTestCase(int testCaseId) => Get<TestCaseDTO>($"{testCaseId}");
        public Task<TestCaseDTO> GetTestCaseAsync(int testCaseId) => GetAsync<TestCaseDTO>($"{testCaseId}");
       
        public IEnumerable<TestRunDTO> GetTestRuns(
            int testCaseId,
            int starting_row,
            int number_of_rows, 
            int sort_field,
            string sort_direction = "desc") =>
            Post<TestRunsFilterDTO, IEnumerable<TestRunDTO>>(
                $"{testCaseId}/test-runs/search" +
                $"?starting_row={starting_row}" +
                $"&number_of_rows={number_of_rows}" +
                $"&sort_field={sort_field}" +
                $"&sort_direction={sort_direction}",
                new TestRunsFilterDTO());
        public Task<IEnumerable<TestRunDTO>> GetTestRunsAsync(
            int testCaseId,
            int starting_row,
            int number_of_rows, 
            int sort_field,
            string sort_direction = "desc") =>
            PostAsync<TestRunsFilterDTO, IEnumerable<TestRunDTO>>(
                $"{testCaseId}/test-runs/search" +
                $"?starting_row={starting_row}" +
                $"&number_of_rows={number_of_rows}" +
                $"&sort_field={sort_field}" +
                $"&sort_direction={sort_direction}",
                new TestRunsFilterDTO());

        public TestCaseDTO CreateTestCase(TestCaseDTO testCase) => Post<TestCaseDTO, TestCaseDTO>("", testCase);
        public Task<TestCaseDTO> CreateTestCaseAsync(TestCaseDTO testCase) => PostAsync<TestCaseDTO, TestCaseDTO>("", null);

        public TestCaseDTO UpdateTestCase(TestCaseDTO testCase) => Put<TestCaseDTO, TestCaseDTO>("", testCase);
        public Task<TestCaseDTO> UpdateTestCaseAsync(TestCaseDTO testCase) => PutAsync<TestCaseDTO, TestCaseDTO>("", null);

        public TestCaseDTO DeleteTestCase(int testCaseId) => Delete<TestCaseDTO>($"{testCaseId}");
        public Task<TestCaseDTO> DeleteTestCaseAsync(int testCaseId) => DeleteAsync<TestCaseDTO>($"{testCaseId}");
    }
}
