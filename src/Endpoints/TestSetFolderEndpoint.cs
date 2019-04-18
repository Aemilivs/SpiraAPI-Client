using System.Collections.Generic;
using System.Threading.Tasks;
using Monster.CombinedView.UI.TestingFramework.Helpers.DTO;
using Spira.Client.DTO.JsonResponses;
using SpiraAPI.Client.DTO;
using SpiraAPI.Client.Connection;

namespace SpiraAPI.Client.Endpoints
{
    public interface ITestSetFolderEndpoint
    {
        IEnumerable<TestSetFolderDTO> GetTestSetFolder();
        Task<IEnumerable<TestSetFolderDTO>> GetTestSetFolderAsync();

        IEnumerable<TestSetFolderDTO> GetTestSetFolderByParentId(int testSetFolderId);
        Task<IEnumerable<TestSetFolderDTO>> GetTestSetFolderByParentIdAsync(int testSetFolderId);

        TestSetFolderDTO CreateTestSetFolder(TestSetFolderDTO folder);
        Task<TestSetFolderDTO> CreateTestSetFolderAsync(TestSetFolderDTO folder);

        TestSetFolderDTO GetTestSetFolder(int testSetFolderId);
        Task<TestSetFolderDTO> GetTestSetFolderAsync(int testSetFolderId);

        TestSetFolderDTO UpdateTestSetFolder(TestSetFolderDTO folder);
        Task<TestSetFolderDTO> UpdateTestSetFolderAsync(TestSetFolderDTO folder);

        TestSetFolderDTO DeleteTestSetFolder(int testSetFolderId);
        Task<TestSetFolderDTO> DeleteTestSetFolderAsync(int testSetFolderId);
    }

    internal class TestSetFolderEndpoint : SpiraEndpoint, ITestSetFolderEndpoint
    {
        protected override string EndpointUrl => "test-set-folders";

        public TestSetFolderEndpoint(ISpiraConnection connection) : base(connection) { }

        public IEnumerable<TestSetFolderDTO> GetTestSetFolder() => Get<IEnumerable<TestSetFolderDTO>>("");
        public Task<IEnumerable<TestSetFolderDTO>> GetTestSetFolderAsync() => GetAsync<IEnumerable<TestSetFolderDTO>>("");

        public IEnumerable<TestSetFolderDTO> GetTestSetFolderByParentId(int testSetFolderId) =>
            Get<IEnumerable<TestSetFolderDTO>>($"{testSetFolderId}/children");
        public Task<IEnumerable<TestSetFolderDTO>> GetTestSetFolderByParentIdAsync(int testSetFolderId) =>
            GetAsync<IEnumerable<TestSetFolderDTO>>($"{testSetFolderId}/children");

        public TestSetFolderDTO CreateTestSetFolder(TestSetFolderDTO folder) =>
            Post<TestSetFolderDTO, TestSetFolderDTO>("", folder);
        public Task<TestSetFolderDTO> CreateTestSetFolderAsync(TestSetFolderDTO folder) =>
            PostAsync<TestSetFolderDTO, TestSetFolderDTO>("", folder);

        public TestSetFolderDTO GetTestSetFolder(int testSetFolderId) => Get<TestSetFolderDTO>($"{testSetFolderId}");
        public Task<TestSetFolderDTO> GetTestSetFolderAsync(int testSetFolderId) =>
            GetAsync<TestSetFolderDTO>($"{testSetFolderId}");

        public TestSetFolderDTO UpdateTestSetFolder(TestSetFolderDTO folder) =>
            Put<TestSetFolderDTO, TestSetFolderDTO>("", folder);
        public Task<TestSetFolderDTO> UpdateTestSetFolderAsync(TestSetFolderDTO folder) =>
            PutAsync<TestSetFolderDTO, TestSetFolderDTO>("", folder);

        public TestSetFolderDTO DeleteTestSetFolder(int testSetFolderId) => Delete<TestSetFolderDTO>($"{testSetFolderId}");
        public Task<TestSetFolderDTO> DeleteTestSetFolderAsync(int testSetFolderId) =>
            DeleteAsync<TestSetFolderDTO>($"{testSetFolderId}");
    }
}
