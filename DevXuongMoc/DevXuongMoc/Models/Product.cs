﻿using System;
using System.Collections.Generic;

namespace DevXuongMoc.Models;

public partial class Product
{
    public int Id { get; set; }

    public int? Cid { get; set; }

    public string? Code { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Content { get; set; }

    public string? Image { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaKeyword { get; set; }

    public string? MetaDescription { get; set; }

    public string? Slug { get; set; }

    public decimal? PriceOld { get; set; }

    public decimal? PriceNew { get; set; }

    public string? Size { get; set; }

    public int? Views { get; set; }

    public int? Likes { get; set; }

    public double? Star { get; set; }

    public byte? Home { get; set; }

    public byte? Hot { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? AdminCreated { get; set; }

    public string? AdminUpdated { get; set; }

    public byte? Status { get; set; }

    public bool? Isdelete { get; set; }

    public virtual Category? CidNavigation { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();

    public virtual ICollection<ProductExtension> ProductExtensions { get; set; } = new List<ProductExtension>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductMaterial> ProductMaterials { get; set; } = new List<ProductMaterial>();
}
