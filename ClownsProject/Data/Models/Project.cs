using System;
using System.Collections.Generic;

namespace ClownsProject.Models;

public partial class Project
{
    public int IdProject { get; set; }

    public string Title { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string TradeMark { get; set; } = null!;

    public virtual User LoginNavigation { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual Company TradeMarkNavigation { get; set; } = null!;
}
