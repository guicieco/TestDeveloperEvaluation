namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleRequest
    {
        public Guid CustomerId { get; set; }
        public Guid BranchId { get; set; }
        public List<SaleProductRequest> Products { get; set; }
    }

    public class SaleProductRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
