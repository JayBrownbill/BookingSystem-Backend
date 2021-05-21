using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.TableStorage;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/api/classes")]
    public class ClassController : ControllerBase
    {
        private ITableStorageProvider<ClassEntity> classTableStorage;
        private string partitionKey;
        private string baseAddress;
        public ClassController(ITableStorageProvider<ClassEntity> classStorageProvider, IConfiguration config)
        {
            classTableStorage = classStorageProvider;
            partitionKey = config["partitionKeyClasses"];
        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<ClassEntity> GetClasses()
        {

            var tableStorageResult = classTableStorage.GetAllEntities(partitionKey);

            List<ClassEntity> allClasses = new List<ClassEntity>();


            ClassEntity spinningClass = new ClassEntity
            {
                ID = Guid.NewGuid().ToString(),
                TimeOfClass = "4:50pm - 5:50pm, 6:00pm - 6:50pm",
                //TimeOfClass = new List<string> { "4:50pm - 5:50pm", "6:00pm - 6:50pm" },
                Name = "Spinning Class",
                SpacesBooked = 0,
                TotalSpaces = 10,
            };

            allClasses.Add(spinningClass);

            return tableStorageResult;
        }
    }
}
