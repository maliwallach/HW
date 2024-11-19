using System;
using System.Collections.Generic;

namespace users.Models;

public partial class Project
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public DateOnly? Date { get; set; }

    public int TaskId { get; set; }

    public virtual Task Task { get; set; } = null!;
}
