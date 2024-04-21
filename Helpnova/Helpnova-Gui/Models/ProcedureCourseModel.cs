using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpnova_Gui.Models
{
    public class ProcedureCourseModel
    {
        public int ProcedureCourseId { get; set; }

        public int? CourseId { get; set; }

        public int ProcedureId { get; set; }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        public string DisplayOrder { get; set; }

        public virtual CourseModel Course { get; set; }

        public virtual CustomerModel Customer { get; set; }

        public virtual ProcedureModel Procedure { get; set; }

        public virtual ProductModel Product { get; set; }
    }
}