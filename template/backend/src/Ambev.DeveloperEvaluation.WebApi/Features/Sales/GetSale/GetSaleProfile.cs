#region Using

using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using AutoMapper;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale
{
    public class GetSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetUser feature
        /// </summary>
        public GetSaleProfile()
        {
            CreateMap<Guid, Application.Sales.GetSale.GetSaleCommand>()
                .ConstructUsing(id => new Application.Sales.GetSale.GetSaleCommand(id));
            CreateMap<GetSaleResult, GetSaleResponse>().ReverseMap();
        }
    }
}