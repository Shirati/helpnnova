using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpnova_Gui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public string ProductName { get; set; }


        public virtual CustomerModel Customer { get; set; }
    }
}