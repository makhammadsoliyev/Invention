﻿using Invention.Domain.Commons;

namespace Invention.Domain.Entities;

public class Product : Auditable
{
    public string Name { get; set; }
    public int Code { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Barcode { get; set; }
    public long? ProductId { get; set; }
}