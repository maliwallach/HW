using System;
using System.Collections.Generic;

namespace ex2.Models;

public partial class User
{
    public string? Name { get; set; }

    public int Id { get; set; }

    public string? Adress { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
}
