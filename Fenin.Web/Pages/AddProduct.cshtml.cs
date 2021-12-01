using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fenin.Core.Entities;
using Fenin.Infrastructure.Data;
using MediatR;
using Microsoft.Extensions.Logging;
using Fenin.Application.Commands;
using Microsoft.AspNetCore.Http;
using Fenin.Application.Responses;
using AutoMapper;

namespace Fenin.Web
{
    public class AddProductModel : PageModel
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AddProductModel> _logger;
        private readonly IMapper _mapper;

        public AddProductModel(IMediator mediator, ILogger<AddProductModel> logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProductResponse Product { get; set; }

        public async Task OnPostAsync(Product product)
        {
            CreateProductCommand command = _mapper.Map<CreateProductCommand>(product);

            Product = await _mediator.Send(command);
        }
    }
}
