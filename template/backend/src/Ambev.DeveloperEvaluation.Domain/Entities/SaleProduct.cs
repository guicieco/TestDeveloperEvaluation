﻿#region Using

using Ambev.DeveloperEvaluation.Domain.Common;

#endregion

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleProduct : BaseEntity
    {
        public Guid SaleId { get; set; }
        public Sale Sale { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
