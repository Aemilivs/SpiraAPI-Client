using System;

namespace Spira.Client.DTO.JsonResponses
{
    public class TestCaseFolderDTO
    {
        public object ActualDuration { get; set; }
        public int CountBlocked { get; set; }
        public int CountCaution { get; set; }
        public int CountFailed { get; set; }
        public int CountNotApplicable { get; set; }
        public int CountNotRun { get; set; }
        public int CountPassed { get; set; }
        public object Description { get; set; }
        public string EstimatedDuration { get; set; }
        public string ExecutionDate { get; set; }
        public string IndentLevel { get; set; }
        public string LastUpdateDate { get; set; }
        public string Name { get; set; }
        public object ParentTestCaseFolderId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? TestCaseFolderId { get; set; }
    }
}