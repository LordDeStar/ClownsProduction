using System;
using System.Collections.Generic;

namespace ClownsProject.Models;

public partial class Task
{
    public int IdTask { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Login { get; set; } = null!;

    public DateOnly DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public int IdStatus { get; set; }

    public int IdProject { get; set; }

    public virtual Project IdProjectNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual User LoginNavigation { get; set; } = null!;
}
