#region Using

using AutoMapper;

#endregion

/// <summary>
/// Profile for mapping DeleteSale feature requests to commands
/// </summary>
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale
{
    public class DeleteSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteSale feature
        /// </summary>
        public DeleteSaleProfile()
        {
            CreateMap<Guid, Application.Sales.DeleteSale.DeleteSaleCommand>()
                .ConstructUsing(id => new Application.Sales.DeleteSale.DeleteSaleCommand(id));
        }
    }
}