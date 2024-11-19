using System;
using System.Collections.Generic;

namespace users.Models;

public partial class Task
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? IsDone { get; set; }

    public DateOnly? CreatDate { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
