using ProductApi.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductApi.Infrastructure
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
