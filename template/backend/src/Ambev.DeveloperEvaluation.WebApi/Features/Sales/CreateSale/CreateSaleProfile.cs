#region Using

using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using AutoMapper;
using static Ambev.DeveloperEvaluation.Application.Sales.CreateSale.CreateSaleCommand;

#endregion

/// <summary>
/// Profile for mapping between Application and API CreateSale responses
/// </summary>
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateSale feature
        /// </summary>
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleRequest, CreateSaleCommand>();
            CreateMap<CreateSaleResult, CreateSaleResponse>();
            CreateMap<CreateSaleResult, CreateSaleResponse>();
            CreateMap<SaleProductRequest, CreateSaleProduct>();
        }
    }
}
