using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ClassEntity : TableEntity
    {
        public ClassEntity()
        {
        }

        public ClassEntity(string guid, string className)
        {
            PartitionKey = guid;
            RowKey = className;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public int TotalSpaces { get; set; }
        public int SpacesBooked { get; set; }
        public int SpacesFree { get; set; }
        public string TimeOfClass { get; set; }
    }
}
