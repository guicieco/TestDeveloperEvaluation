#region Using

using MediatR;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    /// <summary>
    /// Command for retrieving a sale paged
    /// </summary>
    public class GetSalePagedCommand : IRequest<GetSalePagedResult>
    {
        /// <summary>
        /// The customer's name
        /// </summary>
        public string? Name { get; set; } = string.Empty;

        /// <summary>
        /// The number of page
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// The page size
        /// </summary>
        public int Size { get; set; }
    }
}