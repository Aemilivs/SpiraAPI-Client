using System;
using System.Collections.Generic;

namespace SpiraAPI.Client.DTO
{
    public class TestStepDTO
    {
        public int ArtifactTypeId { get; set; }
        public DateTime ConcurrencyDate { get; set; }
        public List<CustomDefinitionDTO> CustomProperties { get; set; }
        public bool IsAttachments { get; set; }
        public int ProjectId { get; set; }
        public string Description { get; set; }
        public int ExecutionStatusId { get; set; }
        public string ExpectedResult { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public object LinkedTestCaseId { get; set; }
        public int Position { get; set; }
        public object SampleData { get; set; }
        public int TestCaseId { get; set; }
        public int TestStepId { get; set; }
    }
}