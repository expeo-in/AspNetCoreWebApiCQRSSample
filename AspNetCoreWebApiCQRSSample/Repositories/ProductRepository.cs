using AspNetCoreWebApiCQRSSample.Models;

namespace AspNetCoreWebApiCQRSSample.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Add(Product product);
        Task<Product> Update(int id, Product product);
        Task<Product> Delete(int id);
    }

    public class ProductRepository : IProductRepository
    {
        public List<Product> dataStore = new List<Product>() {
            new Product { Id = 1, Name = "Butter", Price = 40 },
            new Product { Id = 2, Name = "Bread", Price = 50 },
            new Product { Id = 3, Name = "Milk", Price = 30 }
        };

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await Task.FromResult(dataStore.AsEnumerable());
        }

        public async Task<Product> GetById(int id)
        {
            return await Task.FromResult(dataStore.Single(x => x.Id == id));
        }

        public async Task<Product> Add(Product product)
        {
            dataStore.Add(new Product
            {
                Id = dataStore.Count() + 1,
                Name = product.Name,
                Price = product.Price
            });
            return await Task.FromResult(dataStore.Last());
        }

        public async Task<Product> Update(int id, Product product)
        {
            var entity = await GetById(id);
            entity.Price = product.Price;
            return entity;
        }

        public async Task<Product> Delete(int id)
        {
            var entity = await GetById(id);
            dataStore.Remove(entity);
            return entity;
        }
    }
}
