using System;
using System.Collections.Generic;

namespace ex2.Models;

public partial class Project
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Subject { get; set; }

    public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
}
