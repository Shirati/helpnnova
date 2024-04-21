using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpnova_Gui.Models
{
    public class ProcedureModel
    {
        public int ProcedureId { get; set; }

        public int? CustomerId { get; set; }

        public int? ProductId { get; set; }

        public string ProcedureName { get; set; }

        public string  AlternateName { get; set; }

        public TimeSpan EstimatedReadingTime { get; set; }

        public string  HowToGetThere { get; set; }

        public string Summary { get; set; }

        public string Explanation { get; set; }

        public string Tip { get; set; }

        public string SeeMore { get; set; }

        public string Keywords { get; set; }

        public byte[] ImageLink1 { get; set; }

        public byte[] ImageLink2 { get; set; }

        public byte[] ImageLink3 { get; set; }

        public string  VideoLink { get; set; }

        public virtual CustomerModel Customer { get; set; }


        public virtual ProductModel Product { get; set; }
    }
}