using System;
using System.Collections.Generic;

namespace ex2.Models;

public partial class Tasks
{
    public string? Name { get; set; }

    public int? Priority { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Status { get; set; }

    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? ProjectId { get; set; }

    public virtual Project? Project { get; set; }

    public virtual User? User { get; set; }
}