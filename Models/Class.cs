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
        public string TimeOfClass { get; set; }

        public List<string> ClassTimes = new List<string> { "6:00am - 6:50am", "7:00am - 7:50am" , "8:00am - 8:50am","9:00am - 9:50am", "10:00am - 10:50am", "10:00am - 10:50am",
                                                                "11:00am - 11:50am", "12:00pm - 12:50pm", "13:00pm - 13:50pm", "14:00pm - 14:50pm", "15:00pm - 15:50pm", "16:00pm - 16:50pm", "17:00pm - 17:50pm" };

    }
}
