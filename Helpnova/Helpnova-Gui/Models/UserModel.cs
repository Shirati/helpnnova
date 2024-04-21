using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpnova_Gui.Models
{
    public class UserModel
    {
        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        public string UserName { get; set; }

        public string UserLogin { get; set; } 

        public string Password { get; set; }

        public string Email { get; set; }

        public int AuthorizationLevel { get; set; }

        public virtual CustomerModel Customer { get; set; }

        public virtual ProductModel Product { get; set; }
    }
}