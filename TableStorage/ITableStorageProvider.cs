using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApi.TableStorage
{
    public interface ITableStorageProvider<Entity>
    {
        //Task<HttpContent> ConnectTableStorageAsync(string url, string tableName);
        IEnumerable<Entity> GetAllEntities();
        IEnumerable<Entity> GetAllEntitiesOfType(string partitionKey);
        Task<Entity> CreateOrUpdateRecord(Entity entity);
        Entity GetEntity(string rowKey);


    }
}
