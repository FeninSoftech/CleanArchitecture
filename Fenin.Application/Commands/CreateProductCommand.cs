using Fenin.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fenin.Application.Commands
{
    public class CreateProductCommand: IRequest<ProductResponse>
    {
        public string ProductName
        {
            get;
            set;
        }

        public string ProductImage
        {
            get;
            set;
        }

        public string SKU
        {
            get;
            set;
        }

        public Int32 Width
        {
            get;
            set;
        }

        public Int32 Height
        {
            get;
            set;
        }

        public Int32 Length
        {
            get;
            set;
        }
    }
}
