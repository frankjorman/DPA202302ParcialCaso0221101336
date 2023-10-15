using System;
using System.Collections.Generic;

namespace DPA202302ParcialCaso0221101336.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Currency { get; set; } = null!;
}
