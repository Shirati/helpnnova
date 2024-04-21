using System;
using System.Collections.Generic;

namespace Helpnova_Repositories.Models;

public partial class User
{
    public int UserId { get; set; }
    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public string? UserName { get; set; }

    public string UserLogin { get; set; } = null!;

    public string? Password { get; set; }

    public string? Email { get; set; }

    public int? AuthorizationLevel { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
