using System;
using System.Collections.Generic;

namespace CurWork.DAL.Entities;

public partial class Charterclient
{
    public int Id { get; set; }

    public int? Customerid { get; set; }

    public int? Movieid { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Movie? Movie { get; set; }
}
