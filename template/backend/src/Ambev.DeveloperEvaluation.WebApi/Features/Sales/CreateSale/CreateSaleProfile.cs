#region Using

using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using AutoMapper;
using static Ambev.DeveloperEvaluation.Application.Sales.CreateSale.CreateSaleCommand;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateUser feature
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
