using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpnova_Gui.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public byte[] Logo { get; set; }
    }
}