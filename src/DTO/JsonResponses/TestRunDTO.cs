using System.Collections.Generic;

namespace SpiraAPI.Client.DTO
{
    public class TestRunDTO
    {
        public int ArtifactTypeId { get; set; }
        public string ConcurrencyDate { get; set; }
        public List<CustomDefinitionDTO> CustomProperties { get; set; }
        public bool IsAttachments { get; set; }
        public int ProjectId { get; set; }
        public int? ActualDuration { get; set; }
        public object BuildId { get; set; }
        public string EndDate { get; set; }
        public object EstimatedDuration { get; set; }
        public ExecutionStatusIdEnum ExecutionStatusId { get; set; }
        public string Name { get; set; }
        public int? ReleaseId { get; set; }
        public string StartDate { get; set; }
        public int TestCaseId { get; set; }
        public int TestRunId { get; set; }
        public int TestRunTypeId { get; set; }
        public object TestSetId { get; set; }
        public object TestSetTestCaseId { get; set; }
        public int TesterId { get; set; }
        public object AutomationAttachmentId { get; set; }
        public object AutomationEngineId { get; set; }
        public object AutomationEngineToken { get; set; }
        public object AutomationHostId { get; set; }
        public object Parameters { get; set; }
        public object RunnerAssertCount { get; set; }
        public object RunnerMessage { get; set; }
        public object RunnerName { get; set; }
        public object RunnerStackTrace { get; set; }
        public object RunnerTestName { get; set; }
        public object ScheduledDate { get; set; }
        public int TestRunFormatId { get; set; }
        public List<TestRunStepDTO> TestRunSteps { get; set; }
    }
}
