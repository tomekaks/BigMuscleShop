using BigMuscleShop.Application.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Application.Contracts.Services
{
    public interface IProductsService
    {
        Task AddProduct(ProductDto productDto);
        Task DeleteProduct(int id);
        Task<ProductDto> GetProduct(int id);
        Task UpdateProduct(UpdateProductDto productDto);
        Task<List<ProductDto>> GetAllProducts();
    }
}
