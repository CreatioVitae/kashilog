using MicroORMWrapper;
using Service.Extensions.DependencyInjection.Markers;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Kashilog.DomainObjects.Kashi;
using WebApi.Kashilog.Repositories.Kashi.Products.Sqls;

namespace WebApi.Kashilog.Repositories.Kashi.Products {
    public class ProductRepository : IRepository {

        private SqlManager SqlManager { get; }

        public ProductRepository(SqlManager sqlManager) {
            SqlManager = sqlManager;
        }

        public Task<IEnumerable<Product>> FindAllProductAsync() {
            return SqlManager.SelectAsync<Product>(SqlForProductResource.FindAllProduct);
        }

        public Task<IEnumerable<Product>> FindProductByIdAsync(int id) {
            return SqlManager.SelectAsync<Product>(SqlForProductResource.FindProductById, new { Id = id });
        }

        public Task<IEnumerable<ProductTaste>> FindProductTasteByProductIdAsync(int productId) {
            return SqlManager.SelectAsync<ProductTaste>(SqlForProductResource.FindProductTasteByProductId, new { ProductId = productId });
        }

        public Task<IEnumerable<ProductTaste>> FindProductTasteInProductIdsAsync(IEnumerable<int> productIds) {
            return SqlManager.SelectAsync<ProductTaste>(SqlForProductResource.FindProductTasteInProductIds, new { ProductIds = productIds });
        }

        public Task<IEnumerable<ProductTexture>> FindProductTextureByProductIdAsync(int productId) {
            return SqlManager.SelectAsync<ProductTexture>(SqlForProductResource.FindProductTextureByProductId, new { ProductId = productId });
        }

        public Task<IEnumerable<ProductTexture>> FindProductTextureInProductIdsAsync(IEnumerable<int> productIds) {
            return SqlManager.SelectAsync<ProductTexture>(SqlForProductResource.FindProductTextureInProductIds, new { ProductIds = productIds });
        }
    }
}