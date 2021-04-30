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
            
            Class workoutClass = new Class {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = "17:00pm - 17:50pm",
                Name = "Workout Class",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            Class gluteSmashClass = new Class
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = "17:00pm - 17:50pm",
                Name = "Glute Smasher",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            Class spinningClass = new Class
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = "15:00pm - 15:50pm",
                Name = "Spinning Class",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            Class assClass = new Class
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = "10:00am - 10:50am",
                Name = "A*s Class",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            allClasses.Add(workoutClass);
            allClasses.Add(gluteSmashClass);
            allClasses.Add(spinningClass);
            allClasses.Add(assClass);

            return allClasses;
        }
    }
}
