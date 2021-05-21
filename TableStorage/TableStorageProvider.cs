using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.TableStorage
{
    public class TableStorageProvider<Entity> : ITableStorageProvider<Entity> where Entity : ITableEntity, new()
    {
        private readonly CloudTable table;
        public TableStorageProvider(CloudTableClient cloudTableClient)
        {
            table = cloudTableClient.GetTableReference("testCustomerStorage");
        }

        public Task<Entity> CreateOrUpdateRecord(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Entity GetEntity(string rowKey)
        {
            TableQuery<Entity> query = new TableQuery<Entity>().Where(TableQuery.GenerateFilterCondition("RowKey", QueryComparisons.Equal, rowKey));
            return table.ExecuteQuery(query).FirstOrDefault();
        }

        public IEnumerable<Entity> GetAllEntities()
        {
            TableQuery<Entity> query = new TableQuery<Entity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.NotEqual, ""));
            return table.ExecuteQuery<Entity>(query);
        }

        public IEnumerable<Entity> GetAllEntitiesOfType(string partitionKey)
        {
            TableQuery<Entity> query = new TableQuery<Entity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey));
            return table.ExecuteQuery<Entity>(query);
        }
    }
}
