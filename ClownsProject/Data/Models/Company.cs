using System;
using System.Collections.Generic;

namespace ClownsProject.Models;

public partial class Company
{
    public string TradeMark { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
