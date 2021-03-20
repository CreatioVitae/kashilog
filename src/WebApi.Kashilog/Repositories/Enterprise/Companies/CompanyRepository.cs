using MicroORMWrapper;
using Service.Extensions.DependencyInjection.Markers;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Kashilog.DomainObjects.Enterprise;
using WebApi.Kashilog.Repositories.DatabaseConnections;
using WebApi.Kashilog.Repositories.Enterprise.Companies.Sqls;

namespace WebApi.Kashilog.Repositories.Enterprise.Companies {
    public class CompanyRepository : IRepository {
        private SqlManager<KashilogConnection> SqlManager { get; }

        public CompanyRepository(SqlManager<KashilogConnection> sqlManager) => SqlManager = sqlManager;

        public Task<IEnumerable<Company>> FindAllCompanyAsync() => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindAllCompany);

        public Task<IEnumerable<Company>> FindCompanyByIdAsync(int id) => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindCompanyById, new { Id = id });

        public Task<IEnumerable<Company>> FindCompanyInIdsAsync(IEnumerable<int> ids) => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindCompanyInIds, new { Ids = ids });
    }
}
