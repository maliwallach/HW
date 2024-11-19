using System;
using System.Collections.Generic;

namespace users.Models;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public int? TaskId { get; set; }

    public virtual Task? Task { get; set; }
}
