using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVTranformation.Models
{
    internal class DataPOCO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Business { get; set; }

        public DataPOCO(int id, string name, string business)
        {
            Id = id;
            Name = name;
            Business = business;
        }
    }
}
