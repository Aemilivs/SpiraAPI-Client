using System;
using System.Collections.Generic;
using SpiraAPI.Client.DTO;

namespace Monster.CombinedView.UI.TestingFramework.Helpers.DTO
{
    public class TestSetDTO
    {
        public int ArtifactTypeId { get; set; }
        public DateTime ConcurrencyDate { get; set; }
        public List<CustomDefinitionDTO> CustomProperties { get; set; }
        public bool IsAttachments { get; set; }
        public int ProjectId { get; set; }
        public int ActualDuration { get; set; }
        public object AutomationHostId { get; set; }
        public object BuildExecuteTimeInterval { get; set; }
        public int CountBlocked { get; set; }
        public int CountCaution { get; set; }
        public int CountFailed { get; set; }
        public int CountNotApplicable { get; set; }
        public int CountNotRun { get; set; }
        public int CountPassed { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorId { get; set; }
        public string CreatorName { get; set; }
        public object Description { get; set; }
        public object DynamicQuery { get; set; }
        public object EstimatedDuration { get; set; }
        public DateTime ExecutionDate { get; set; }
        public object IndentLevel { get; set; }
        public bool IsAutoScheduled { get; set; }
        public bool IsDynamic { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string Name { get; set; }
        public object OwnerId { get; set; }
        public object OwnerName { get; set; }
        public object PlannedDate { get; set; }
        public string ProjectName { get; set; }
        public object RecurrenceId { get; set; }
        public object RecurrenceName { get; set; }
        public object ReleaseId { get; set; }
        public object ReleaseVersionNumber { get; set; }
        public object TestConfigurationSetId { get; set; }
        public int TestRunTypeId { get; set; }
        public int TestSetFolderId { get; set; }
        public int TestSetId { get; set; }
        public int TestSetStatusId { get; set; }
        public string TestSetStatusName { get; set; }
    }
}