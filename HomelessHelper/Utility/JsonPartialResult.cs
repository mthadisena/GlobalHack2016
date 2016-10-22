using System.Collections.Generic;

namespace HomelessHelper.Utility
{
    public class JsonPartialResult
    {
        public JsonResultStatus Status { get; set; }
        public string Message { get; set; }
        
        public string Html { get; set; }

        public object Model { get; set; }
    }

    public enum JsonResultStatus
    {
        Successful = 0,
        Warning = 1,
        Error = 2,
    }
}