using MicroORMWrapper;
using System.Data.Common;

namespace WebApi.Kashilog.Test.DatabaseConnections {
    public class KashilogConnection : IDatabaseConnection {
        public string ConnectionName { get; set; } = null!;

        public DbConnection DbConnection { get; set; } = null!;
    }
}
