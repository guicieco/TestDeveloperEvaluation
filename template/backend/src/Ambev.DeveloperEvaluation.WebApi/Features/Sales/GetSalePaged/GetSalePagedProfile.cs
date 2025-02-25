#region Using

using Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged;
using AutoMapper;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSalePaged
{
    public class GetSalePagedProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetUser feature
        /// </summary>
        public GetSalePagedProfile()
        {
            CreateMap<GetSalePagedResult, GetSalePagedResponse>().ReverseMap();
        }
    }
}