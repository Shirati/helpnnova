using System;
using System.Collections.Generic;

namespace Helpnova_Repositories.Models;

public partial class ProcedureCourse
{
    public int ProcedureCourseId { get; set; }

    public int? CourseId { get; set; }

    public int? ProcedureId { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public string? DisplayOrder { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Procedure? Procedure { get; set; }

    public virtual Product? Product { get; set; }
}
