using System;
using System.Collections.Generic;

namespace ClownsProject.Models;

public partial class Status
{
    public int IdStatus { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
