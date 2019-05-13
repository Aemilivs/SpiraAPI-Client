using System;
using System.Collections.Generic;

namespace SpiraAPI.Client.DTO
{
    public class TestCaseDTO
    {
        public int ArtifactTypeId { get; set; }
        public string ConcurrencyDate { get; set; }
        public IEnumerable<CustomDefinitionDTO> CustomProperties { get; set; }
        public bool IsAttachments { get; set; }
        public int ProjectId { get; set; }
        public object ActualDuration { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public object AutomationAttachmentId { get; set; }
        public object AutomationEngineId { get; set; }
        public IEnumerable<string> ComponentIds { get; set; }
        public string CreationDate { get; set; }
        public string Description { get; set; }
        public object EstimatedDuration { get; set; }
        public object ExecutionDate { get; set; }
        public int ExecutionStatusId { get; set; }
        public string ExecutionStatusName { get; set; }
        public bool IsSuspect { get; set; }
        public bool IsTestSteps { get; set; }
        public string LastUpdateDate { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string ProjectName { get; set; }
        public int TestCaseFolderId { get; set; }
        public int TestCaseId { get; set; }
        public int TestCasePriorityId { get; set; }
        public string TestCasePriorityName { get; set; }
        public int TestCaseStatusId { get; set; }
        public string TestCaseStatusName { get; set; }
        public int TestCaseTypeId { get; set; }
        public string TestCaseTypeName { get; set; }
        public IEnumerable<TestStepDTO> TestSteps { get; set; }
    }
}