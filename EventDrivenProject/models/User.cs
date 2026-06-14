using System;
using System.Collections.Generic;

namespace EventDrivenProject.models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public decimal? PhoneNumber { get; set; }

    public string Password { get; set; } = null!;

    public string? Gender { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
