namespace SpiraAPI.Client.DTO
{
    public class CustomDefinitionDTO
    {
        public object BooleanValue { get; set; }
        public object DateTimeValue { get; set; }
        public object DecimalValue { get; set; }
        public DefinitionDTO Definition { get; set; }
        public object IntegerListValue { get; set; }
        public object IntegerValue { get; set; }
        public int PropertyNumber { get; set; }
        public string StringValue { get; set; }
    }
}