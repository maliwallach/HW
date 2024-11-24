using System;
using System.Collections.Generic;

namespace ex2.Models;

public partial class Attachment
{
    public string Name { get; set; } = null!;

    public string? Path { get; set; }

    public int Id { get; set; }
}
