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
    [EnableCors]
    [ApiController]
    [Route("/api/classes")]
    public class ClassController : ControllerBase
    {
        private ITableStorageProvider<ClassEntity> classTableStorage;
        public ClassController(ITableStorageProvider<ClassEntity> classStorageProvider, IConfiguration config)
        {
            classTableStorage = classStorageProvider;
        }

        [HttpGet]
        public IEnumerable<ClassEntity> GetAllClasses()
        {
            IEnumerable<ClassEntity> tableStorageResult = classTableStorage.GetAllEntities();
            return tableStorageResult;
        }

        [HttpGet]
        [Route("/api/classes/type/{partitionKey}")]
        public IEnumerable<ClassEntity> GetAllClassesOfType([FromRoute] string partitionKey)
        {
            IEnumerable<ClassEntity> tableStorageResult = classTableStorage.GetAllEntitiesOfType(partitionKey);
            return tableStorageResult;
        }

        [HttpGet]
        [Route("/api/classes/{rowKey}")]
        public ClassEntity GetSingleClass([FromRoute] string rowKey)
        {
            ClassEntity resultEntity = classTableStorage.GetEntity(rowKey);
            return resultEntity;
        }
    }
}
