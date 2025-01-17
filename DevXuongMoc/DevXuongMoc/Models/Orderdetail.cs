using System;
using System.Collections.Generic;

namespace DevXuongMoc.Models;

public partial class Orderdetail
{
    public int Id { get; set; }

    public int? Idord { get; set; }

    public int? Idproduct { get; set; }

    public decimal? Price { get; set; }

    public int? Qty { get; set; }

    public decimal? Total { get; set; }

    public int? ReturnQty { get; set; }

    public virtual Order? IdordNavigation { get; set; }

    public virtual Product? IdproductNavigation { get; set; }
}
