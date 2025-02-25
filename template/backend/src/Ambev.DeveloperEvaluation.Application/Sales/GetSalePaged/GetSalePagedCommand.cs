#region Using

using MediatR;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    public class GetSalePagedCommand : IRequest<GetSalePagedResult>
    {
        public string? Name { get; set; } = string.Empty;
        public int Page { get; set; }
        public int Size { get; set; }
    }
}