using System;
using System.Collections.Generic;

namespace JM_Api.Data.Models;

public partial class Burger
{
    public int BurgerId { get; set; }

    public string? Name { get; set; }

    public bool WithCheese { get; set; }

    public virtual ICollection<Promo> Promos { get; set; } = new List<Promo>();
}
