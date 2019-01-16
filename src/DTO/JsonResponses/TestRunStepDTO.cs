namespace SpiraAPI.Client.DTO
{
    public class TestRunStepDTO
    {
        public object ActualDuration { get; set; }
        public object ActualResult { get; set; }
        public string Description { get; set; }
        public object EndDate { get; set; }
        public int ExecutionStatusId { get; set; }
        public string ExpectedResult { get; set; }
        public int Position { get; set; }
        public object SampleData { get; set; }
        public object StartDate { get; set; }
        public int TestCaseId { get; set; }
        public int TestRunId { get; set; }
        public int TestRunStepId { get; set; }
        public int TestStepId { get; set; }
    }
}