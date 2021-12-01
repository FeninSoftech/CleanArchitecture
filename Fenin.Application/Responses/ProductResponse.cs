using System;
using System.Collections.Generic;
using System.Text;

namespace Fenin.Application.Responses
{
    public class ProductResponse
    {
        public Int64 ProductId
        {
            get;
            set;
        }

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
