namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    public class SaleForPagedDto
    {
        public string Customer { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public decimal Discount { get; set; }
    }
}
