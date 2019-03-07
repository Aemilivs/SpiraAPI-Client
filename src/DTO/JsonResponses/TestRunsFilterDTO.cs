using System;
using System.Collections.Generic;
using System.Text;

namespace Spira.Client.DTO.JsonResponses
{
    class TestRunsFilterDTO
    {
        public object DateRangeValue { get; set; }
        public object IntValue { get; set; }
        public object MultiValue { get; set; }
        public object PropertyName { get; set; }
        public object StringValue { get; set; }
    }
}
