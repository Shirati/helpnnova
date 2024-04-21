using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpnova_Gui.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; }

        public int? CustomerId { get; set; }

        public int? ProductId { get; set; }

        public string CourseName { get; set; }

        public string DisplayOrder { get; set; }

        public virtual CustomerModel Customer { get; set; }


        public virtual ProductModel Product { get; set; }
    }
}