using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CassandraExplorer.Entities
{
    public class Keyspace
    {
        public string KeyspaceName { get; set; }

        public bool DurableWrites { get; set; }
    }
}
