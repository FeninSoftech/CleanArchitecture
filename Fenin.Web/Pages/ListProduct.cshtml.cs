using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fenin.Core.Entities;
using Fenin.Infrastructure.Data;
using MediatR;
using Microsoft.Extensions.Logging;
using Fenin.Application.Queries;

namespace Fenin.Web
{
    public class ListProductModel : PageModel
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AddProductModel> _logger;

        public ListProductModel(IMediator mediator, ILogger<AddProductModel> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product =  (await _mediator.Send(new GetAllProductQuery())).ToList();
        }
    }
}
