using Fenin.Core.Entities;
using Fenin.Infrastructure.Data;
using Fenin.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenin.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Fenin.Core.Entities.Product>, IProductRepository
    {
        public ProductRepository(ProductContext productContext) : base(productContext) { }
        public async Task<IEnumerable<Product>> GetProductByName(string productName)
        {
            return await _productContext.Products.Where(m => m.ProductName == productName).ToListAsync();
        }
    }
}
