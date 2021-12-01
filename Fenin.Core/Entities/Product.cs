using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fenin.Core.Entities
{
   public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
