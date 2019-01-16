using System.Collections.Generic;

namespace SpiraAPI.Client.DTO
{
    public class DefinitionDTO
    {
        public int ArtifactTypeId { get; set; }
        public object CustomList { get; set; }
        public string CustomPropertyFieldName { get; set; }
        public int CustomPropertyId { get; set; }
        public int CustomPropertyTypeId { get; set; }
        public string CustomPropertyTypeName { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public List<OptionDTO> Options { get; set; }
        public int ProjectId { get; set; }
        public int PropertyNumber { get; set; }
        public string SystemDataType { get; set; }
    }
}