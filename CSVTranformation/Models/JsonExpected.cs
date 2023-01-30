using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVTranformation.Models
{
    internal class JsonExpected
    {
        public string ExternalUniqueId { get; set; }
        public string BusinessId { get; set; }
        public string SourceSystem { get; set; }
        public string EventDateTime { get; set; }
        public List<object> Data { get; set; }
    }
}
