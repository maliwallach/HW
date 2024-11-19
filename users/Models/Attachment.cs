using System;
using System.Collections.Generic;

namespace users.Models;

public partial class Attachment
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Path { get; set; } = null!;

    public string? DateUplode { get; set; }
}
