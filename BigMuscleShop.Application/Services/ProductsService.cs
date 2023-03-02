using BigMuscleShop.Application.Contracts.Services;
using BigMuscleShop.Application.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Application.Services
{
    public class ProductsService : IProductsService
    {
        public Task AddProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> UpdateProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
