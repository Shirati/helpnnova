using System;
using System.Collections.Generic;

namespace Helpnova_Repositories.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public string? CourseName { get; set; }

    public string? DisplayOrder { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<ProcedureCourse> ProcedureCourses { get; } = new List<ProcedureCourse>();

    public virtual Product? Product { get; set; }
}
