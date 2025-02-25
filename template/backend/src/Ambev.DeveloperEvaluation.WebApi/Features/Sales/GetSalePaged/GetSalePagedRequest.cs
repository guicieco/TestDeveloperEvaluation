namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSalePaged
{
    public class GetSalePagedRequest
    {
        public string? Name { get; set; } = string.Empty;
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
