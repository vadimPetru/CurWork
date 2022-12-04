using System;
using System.Collections.Generic;

namespace CurWork.DAL.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int? Age { get; set; }

    public virtual ICollection<Charterclient> Charterclients { get; } = new List<Charterclient>();
}
