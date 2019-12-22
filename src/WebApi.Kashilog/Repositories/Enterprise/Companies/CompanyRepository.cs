using MicroORMWrapper;
using Service.Extensions.DependencyInjection.Markers;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Kashilog.DomainObjects.Enterprise;
using WebApi.Kashilog.Repositories.Enterprise.Companies.Sqls;

namespace WebApi.Kashilog.Repositories.Enterprise.Companies {
    public class CompanyRepository : IRepository {
        private SqlManager SqlManager { get; }

        public CompanyRepository(SqlManager sqlManager) {
            SqlManager = sqlManager;
        }

        public Task<IEnumerable<Company>> FindAllCompanyAsync() {
            return SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindAllCompany);
        }

        public Task<IEnumerable<Company>> FindCompanyByIdAsync(int id) {
            return SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindCompanyById, new { Id = id });
        }

        public Task<IEnumerable<Company>> FindCompanyInIdsAsync(IEnumerable<int> ids) {
            return SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindCompanyInIds, new { Ids = ids });
        }
    }
}
