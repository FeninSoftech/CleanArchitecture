using Fenin.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fenin.Infrastructure
{
    public interface IProductRepository: IRepository<Fenin.Core.Entities.Product>
    {
        Task<IEnumerable<Fenin.Core.Entities.Product>> GetProductByName(string productName);
    }
}
