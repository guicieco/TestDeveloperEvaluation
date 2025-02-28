#region Using

using Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged;
using AutoMapper;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSalePaged
{
    /// <summary>
    /// Profile for mapping GetSalePaged feature requests to commands
    /// </summary>
    public class GetSalePagedProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSalePaged feature
        /// </summary>
        public GetSalePagedProfile()
        {
            CreateMap<GetSalePagedResult, GetSalePagedResponse>().ReverseMap();
        }
    }
}