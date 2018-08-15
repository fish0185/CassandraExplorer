using Cassandra.Mapping;
using CassandraExplorer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CassandraExplorer.Infrastructure
{
    public class EntityMappings : Mappings
    {
        public EntityMappings()
        {
            // Define mappings in the constructor of your class
            // that inherits from Mappings
            For<Keyspace>()
               .TableName("keyspaces")
               //.PartitionKey(u => u.UserId)
               .Column(u => u.DurableWrites, cm => cm.WithName("durable_writes"))
               .Column(u => u.KeyspaceName, cm => cm.WithName("keyspace_name"));
        }
    }
}
