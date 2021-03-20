using MicroORMWrapper;
using Service.Extensions.DependencyInjection.Markers;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Kashilog.DomainObjects.Kashi;
using WebApi.Kashilog.Repositories.DatabaseConnections;
using WebApi.Kashilog.Repositories.Kashi.Products.Sqls;

namespace WebApi.Kashilog.Repositories.Kashi.Products {
    public class ProductRepository : IRepository {

        private SqlManager<KashilogConnection> KashilogSqlManager { get; }

        public ProductRepository(SqlManager<KashilogConnection> kashilogSqlManager) => KashilogSqlManager = kashilogSqlManager;

        public Task<IEnumerable<Product>> FindAllProductAsync() =>
            KashilogSqlManager.SelectAsync<Product>(SqlForProductResource.FindAllProduct);

        public Task<IEnumerable<Product>> FindProductByIdAsync(int id) =>
            KashilogSqlManager.SelectAsync<Product>(SqlForProductResource.FindProductById, new { Id = id });

        public Task<IEnumerable<ProductTaste>> FindProductTasteByProductIdAsync(int productId) =>
            KashilogSqlManager.SelectAsync<ProductTaste>(SqlForProductResource.FindProductTasteByProductId, new { ProductId = productId });

        public Task<IEnumerable<ProductTaste>> FindProductTasteInProductIdsAsync(IEnumerable<int> productIds) =>
            KashilogSqlManager.SelectAsync<ProductTaste>(SqlForProductResource.FindProductTasteInProductIds, new { ProductIds = productIds });

        public Task<IEnumerable<ProductTexture>> FindProductTextureByProductIdAsync(int productId) =>
            KashilogSqlManager.SelectAsync<ProductTexture>(SqlForProductResource.FindProductTextureByProductId, new { ProductId = productId });

        public Task<IEnumerable<ProductTexture>> FindProductTextureInProductIdsAsync(IEnumerable<int> productIds) =>
            KashilogSqlManager.SelectAsync<ProductTexture>(SqlForProductResource.FindProductTextureInProductIds, new { ProductIds = productIds });
    }
}
