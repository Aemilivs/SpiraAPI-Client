using System;

namespace Spira.Client.DTO.JsonResponses
{
    public class TestSetFolderDTO
    {
        public object ActualDuration { get; set; }
        public int CountBlocked { get; set; }
        public int CountCaution { get; set; }
        public int CountFailed { get; set; }
        public int CountNotApplicable { get; set; }
        public int CountNotRun { get; set; }
        public int CountPassed { get; set; }
        public DateTime CreationDate { get; set; }
        public object Description { get; set; }
        public object EstimatedDuration { get; set; }
        public object ExecutionDate { get; set; }
        public string IndentLevel { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string Name { get; set; }
        public int? ParentTestSetFolderId { get; set; }
        public int ProjectId { get; set; }
        public object ProjectName { get; set; }
        public int TestSetFolderId { get; set; }
    }
}