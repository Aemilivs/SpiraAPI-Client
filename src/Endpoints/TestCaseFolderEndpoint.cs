using System.Collections.Generic;
using System.Threading.Tasks;
using Spira.Client.DTO.JsonResponses;
using SpiraAPI.Client.Connection;

namespace SpiraAPI.Client.Endpoints
{
    public interface ITestCaseFolderEndpoint
    {
        IEnumerable<TestCaseFolderDTO> GetTestCaseFolder();
        Task<IEnumerable<TestCaseFolderDTO>> GetTestCaseFolderAsync();

        IEnumerable<TestCaseFolderDTO> GetTestCaseFoldersByParentId(int testCaseFolderId);
        Task<IEnumerable<TestCaseFolderDTO>> GetTestCaseFolderByParentIdAsync(int testCaseFolderId);

        TestCaseFolderDTO CreateTestCaseFolder(TestCaseFolderDTO folder);
        Task<TestCaseFolderDTO> CreateTestCaseFolderAsync(TestCaseFolderDTO folder);

        TestCaseFolderDTO GetTestCaseFolder(int testCaseFolderId);
        Task<TestCaseFolderDTO> GetTestCaseFolderAsync(int testCaseFolderId);

        TestCaseFolderDTO UpdateTestCaseFolder(TestCaseFolderDTO folder);
        Task<TestCaseFolderDTO> UpdateTestCaseFolderAsync(TestCaseFolderDTO folder);

        TestCaseFolderDTO DeleteTestCaseFolder(int testCaseFolderId);
        Task<TestCaseFolderDTO> DeleteTestCaseFolderAsync(int testCaseFolderId);
    }

    internal class TestCaseFolderEndpoint : SpiraEndpoint, ITestCaseFolderEndpoint
    {
        protected override string EndpointUrl => "test-folders";

        public TestCaseFolderEndpoint(ISpiraConnection connection) : base(connection) { }

        public IEnumerable<TestCaseFolderDTO> GetTestCaseFolder() => Get<IEnumerable<TestCaseFolderDTO>>("");
        public Task<IEnumerable<TestCaseFolderDTO>> GetTestCaseFolderAsync() => GetAsync<IEnumerable<TestCaseFolderDTO>>("");

        public IEnumerable<TestCaseFolderDTO> GetTestCaseFoldersByParentId(int testCaseFolderId) =>
            Get<IEnumerable<TestCaseFolderDTO>>($"{testCaseFolderId}/children");
        public Task<IEnumerable<TestCaseFolderDTO>> GetTestCaseFolderByParentIdAsync(int testCaseFolderId) =>
            GetAsync<IEnumerable<TestCaseFolderDTO>>($"{testCaseFolderId}/children");

        public TestCaseFolderDTO CreateTestCaseFolder(TestCaseFolderDTO folder) =>
            Post<TestCaseFolderDTO, TestCaseFolderDTO>("", folder);
        public Task<TestCaseFolderDTO> CreateTestCaseFolderAsync(TestCaseFolderDTO folder) =>
            PostAsync<TestCaseFolderDTO, TestCaseFolderDTO>("", folder);

        public TestCaseFolderDTO GetTestCaseFolder(int testCaseFolderId) => Get<TestCaseFolderDTO>($"{testCaseFolderId}");
        public Task<TestCaseFolderDTO> GetTestCaseFolderAsync(int testCaseFolderId) =>
            GetAsync<TestCaseFolderDTO>($"{testCaseFolderId}");

        public TestCaseFolderDTO UpdateTestCaseFolder(TestCaseFolderDTO folder) =>
            Put<TestCaseFolderDTO, TestCaseFolderDTO>("", folder);
        public Task<TestCaseFolderDTO> UpdateTestCaseFolderAsync(TestCaseFolderDTO folder) =>
            PutAsync<TestCaseFolderDTO, TestCaseFolderDTO>("", folder);

        public TestCaseFolderDTO DeleteTestCaseFolder(int testCaseFolderId) => Delete<TestCaseFolderDTO>($"{testCaseFolderId}");
        public Task<TestCaseFolderDTO> DeleteTestCaseFolderAsync(int testCaseFolderId) =>
            DeleteAsync<TestCaseFolderDTO>($"{testCaseFolderId}");
    }
}
