using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/api/classes")]
    public class ClassController : ControllerBase
    {
        [EnableCors]
        [HttpGet]
        public List<Class> GetClasses()
        {
            List<Class> allClasses = new List<Class>();

            Class defaultClass = new Class
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = new List<string> { " " },
                Name = "Default",
                SpacesBooked = 0,
                TotalSpaces = 0,
            };

            Class workoutClass = new Class
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = new List<string> { "6:00am - 6:50am", "7:00am - 7:50am", "8:10pm - 9:00pm" },
                Name = "Workout Class",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            Class gluteSmashClass = new Class
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = new List<string> { "3:00pm - 4:00pm", "6:00pm - 6:50pm" },
                Name = "Glute Smasher",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            Class spinningClass = new Class
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = new List<string> { "4:50pm - 5:50pm", "6:00pm - 6:50pm" },
                Name = "Spinning Class",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            Class assClass = new Class
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = new List<string> { "10:00am - 10:45am" },
                Name = "A*s Class",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            allClasses.Add(defaultClass);
            allClasses.Add(workoutClass);
            allClasses.Add(gluteSmashClass);
            allClasses.Add(spinningClass);
            allClasses.Add(assClass);

            return allClasses;
        }
    }
}
