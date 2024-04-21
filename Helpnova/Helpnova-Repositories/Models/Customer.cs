using System;
using System.Collections.Generic;

namespace Helpnova_Repositories.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public byte[]? Logo { get; set; }

    public string? ContactDetails { get; set; }

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual ICollection<ProcedureCourse> ProcedureCourses { get; } = new List<ProcedureCourse>();

    public virtual ICollection<Procedure> Procedures { get; } = new List<Procedure>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
