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
        public int TestSetId { get; set; }                                                   
        public int TestSetTestCaseId { get; set; }                                           
        public int TesterId { get; set; }                                                    
        public string AutomationAttachmentId { get; set; }                                      
        public string AutomationEngineId { get; set; }                                          
        public object AutomationEngineToken { get; set; }                                    
        public string AutomationHostId { get; set; }                                            
        public object Parameters { get; set; }                                               
        public int RunnerAssertCount { get; set; }                                           
        public string RunnerMessage { get; set; }                                            
        public string RunnerName { get; set; }                                               
        public string RunnerStackTrace { get; set; }                                         
        public string RunnerTestName { get; set; }                                           
        public string ScheduledDate { get; set; }                                            
        public int TestRunFormatId { get; set; }                                             
        public List<TestRunStepDTO> TestRunSteps { get; set; }         
    }
}
