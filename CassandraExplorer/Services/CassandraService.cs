using Cassandra.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CassandraExplorer.Services
{
    public interface ICassandraService
    {
        Task<IEnumerable<string>> GetKeyspaces();
    }

    public class CassandraService : ICassandraService
    {
        private readonly IMapper _mapper;

        public CassandraService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<string>> GetKeyspaces()
        {
            var keyspaceNames = (await _mapper.FetchAsync<string>("select keyspace_name from system_schema.keyspaces")).ToList();
            return keyspaceNames;
        }
    }
}
