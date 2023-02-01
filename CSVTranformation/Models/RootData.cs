using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVTranformation.Models
{
    internal class RootData
    {
        public string ExternalUniqueId { get; set; }
        public string BusinessId { get; set; }
        public string SourceSystem { get; set; }
        public DateTime EventDateTime { get; set; }
        public List<DataPOCO> DataPOCO { get; set; }
        
    }
}
