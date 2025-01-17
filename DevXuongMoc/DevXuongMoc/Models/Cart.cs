using System;
using System.Collections.Generic;

namespace DevXuongMoc.Models;

public partial class Cart
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Image { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? Total { get; set; }

    public int? ProductId { get; set; }

    public string? UserId { get; set; }
}
