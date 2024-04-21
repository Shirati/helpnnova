using System;
using System.Collections.Generic;

namespace Helpnova_Repositories.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int? CustomerId { get; set; }

    public string? ProductName { get; set; }

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<ProcedureCourse> ProcedureCourses { get; } = new List<ProcedureCourse>();

    public virtual ICollection<Procedure> Procedures { get; } = new List<Procedure>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
