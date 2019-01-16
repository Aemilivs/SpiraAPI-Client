using System.Collections.Generic;
using System.Threading.Tasks;
using Monster.CombinedView.UI.TestingFramework.Helpers.DTO;
using SpiraAPI.Client.DTO;
using SpiraAPI.Client.Connection;

namespace SpiraAPI.Client.Endpoints
{
    public interface ITestSetsEndpoint
    {
        TestSetDTO GetTestSet(int testSetId);
        Task<TestSetDTO> GetTestSetAsync(int testSetId);
    }

    internal class TestSetsEndpoint : SpiraEndpoint, ITestSetsEndpoint
    {
        protected override string EndpointUrl => "test-sets";

        public TestSetsEndpoint(ISpiraConnection connection) : base(connection) { }

        public TestSetDTO GetTestSet(int testSetId) => Get<TestSetDTO>($"{testSetId}");
        public Task<TestSetDTO> GetTestSetAsync(int testSetId) => GetAsync<TestSetDTO>($"{testSetId}");
    }
}
