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
        public ClassController(ITableStorageProvider<ClassEntity> classStorageProvider, IConfiguration config)
        {
            classTableStorage = classStorageProvider;
            partitionKey = config["partitionKeyClasses"];
        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<ClassEntity> GetClasses()
        {
            IEnumerable<ClassEntity> tableStorageResult = classTableStorage.GetAllEntities(partitionKey);
            return tableStorageResult;
        }

        [EnableCors]
        [HttpGet]
        [Route("/api/classes/{rowKey}")]
        public ClassEntity GetSingleClass([FromRoute] string rowKey)
        {
            ClassEntity resultEntity = classTableStorage.GetEntity(rowKey);
            return resultEntity;
        }
    }
}
