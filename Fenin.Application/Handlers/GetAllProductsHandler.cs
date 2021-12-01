using Fenin.Application.Commands;
using Fenin.Application.Mappers;
using Fenin.Application.Queries;
using Fenin.Application.Responses;
using Fenin.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fenin.Application.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductQuery, IEnumerable<Fenin.Core.Entities.Product>>
    {
        private readonly IProductRepository _productRepo;
        public GetAllProductsHandler(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }
        public async Task<IEnumerable<Fenin.Core.Entities.Product>> Handle(GetAllProductQuery request,
        CancellationToken cancellationToken) => await _productRepo.GetAllAsync();
    }
}
