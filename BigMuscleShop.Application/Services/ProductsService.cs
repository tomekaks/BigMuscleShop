using AutoMapper;
using BigMuscleShop.Application.Contracts;
using BigMuscleShop.Application.Contracts.Services;
using BigMuscleShop.Application.Dtos.Product;
using BigMuscleShop.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Application.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public ProductsService(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task AddProduct(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return null;
            }

            return _mapper.Map<ProductDto>(product);
        }

        public async Task UpdateProduct(UpdateProductDto productDto)
        {
            var product = await _context.Products.FindAsync(productDto.Id);

            product = _mapper.Map(productDto, product);

            await _context.SaveChangesAsync();
        }
    }
}
