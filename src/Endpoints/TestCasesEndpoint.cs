using System.Collections.Generic;
using System.Threading.Tasks;
using SpiraAPI.Client.DTO;
using SpiraAPI.Client.Connection;

namespace SpiraAPI.Client.Endpoints
{
    public interface ITestCasesEndpoint
    {
        TestCaseDTO GetTestCase(int testCaseId);
        Task<TestCaseDTO> GetTestCaseAsync(int testCaseId);
    }

    internal class TestCasesEndpoint : SpiraEndpoint, ITestCasesEndpoint
    {
        protected override string EndpointUrl => "test-cases";

        public TestCasesEndpoint(ISpiraConnection connection) : base(connection) { }

        public TestCaseDTO GetTestCase(int testCaseId) => Get<TestCaseDTO>($"{testCaseId}");
        public Task<TestCaseDTO> GetTestCaseAsync(int testCaseId) => GetAsync<TestCaseDTO>($"{testCaseId}");
    }
}
