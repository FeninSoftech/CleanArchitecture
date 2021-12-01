using Fenin.Application.Commands;
using Fenin.Application.Mappers;
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
   public class CreateProductHandler: IRequestHandler<CreateProductCommand, ProductResponse>
    {
        private readonly IProductRepository _productRepo;
        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }
        public async Task<ProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var productEntitiy = ProductMapper.Mapper.Map<Fenin.Core.Entities.Product>(request);
            if (productEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newProduct = await _productRepo.AddAsync(productEntitiy);
            var employeeResponse = ProductMapper.Mapper.Map<ProductResponse>(newProduct);
            return employeeResponse;
        }
    }
}
