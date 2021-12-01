using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fenin.Application.Queries
{
    public class GetAllProductQuery : IRequest<IEnumerable<Fenin.Core.Entities.Product>>
    {

    }
}
