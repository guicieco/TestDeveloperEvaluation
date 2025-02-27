namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSalePaged
{
    /// <summary>
    /// Request model for getting a sale per page
    /// </summary>
    public class GetSalePagedRequest
    {
        /// <summary>
        /// The customer's name
        /// </summary>
        public string? Name { get; set; } = string.Empty;

        /// <summary>
        /// The page number
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// The page size
        /// </summary>
        public int Size { get; set; }
    }
}
