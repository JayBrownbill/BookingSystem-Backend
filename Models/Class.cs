using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Class
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int TotalSpaces { get; set; }
        public int SpacesBooked { get; set; }
        public int SpacesFree { get; set; }
        public List<string> TimeOfClass { get; set; }
    }
}
