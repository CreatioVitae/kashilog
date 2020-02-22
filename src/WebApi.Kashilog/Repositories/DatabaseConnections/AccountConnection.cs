using MicroORMWrapper;
using System.Data.Common;

namespace WebApi.Kashilog.Repositories.DatabaseConnections {
    public class AccountConnection : IDatabaseConnection {
        public string ConnectionName { get; set; } = null!;
        public DbConnection DbConnection { get; set; } = null!;
    }
}
