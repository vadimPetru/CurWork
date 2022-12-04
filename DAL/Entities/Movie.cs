using System;
using System.Collections.Generic;

namespace CurWork.DAL.Entities;

public partial class Movie
{
    public int Id { get; set; }

    public string Moviename { get; set; } = null!;

    public string? Genre { get; set; }

    public DateTime? DateOfRelease { get; set; }

    public virtual ICollection<Charterclient> Charterclients { get; } = new List<Charterclient>();
}
