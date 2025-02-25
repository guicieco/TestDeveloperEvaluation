using Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSalePaged
{
    public class GetSalePagedResponse
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public IEnumerable<SaleForPagedDto>? List { get; set;}
    }
}
