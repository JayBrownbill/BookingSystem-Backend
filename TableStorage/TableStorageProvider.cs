﻿using Microsoft.Azure.Cosmos.Table;
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
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> GetAllEntities(string partitionKey)
        {
            TableQuery<Entity> query = new TableQuery<Entity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey));
            return table.ExecuteQuery<Entity>(query);
        }
    }
}
