using System;
using System.Collections.Generic;

namespace DevXuongMoc.Models;

public partial class Order
{
    public int Id { get; set; }

    public string? Idorders { get; set; }

    public DateTime? OrdersDate { get; set; }

    public int? Idcustomer { get; set; }

    public int? Idpayment { get; set; }

    public decimal? TotalMoney { get; set; }

    public string? Notes { get; set; }

    public string? NameReciver { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? TrangThai { get; set; }

    public byte? Isdelete { get; set; }

    public byte? Isactive { get; set; }

    public virtual Customer? IdcustomerNavigation { get; set; }

    public virtual PaymentMethod? IdpaymentNavigation { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();
}
