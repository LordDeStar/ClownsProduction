using System;
using System.Collections.Generic;

namespace ClownsProject.Models;

public partial class User
{
    public string Login { get; set; } = null!;

    public string Passwords { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public int IdRole { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual Company BrandNavigation { get; set; } = null!;

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
