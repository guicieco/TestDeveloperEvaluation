#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    /// <summary>
    /// Profile for mapping between Sale entity and GetSalePagedResponse
    /// </summary>
    public class GetSalePagedProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSalePaged operation
        /// </summary>
        public GetSalePagedProfile()
        {
            CreateMap<Sale, SaleForPagedDto>()
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer.Name))
                .ForMember(dest => dest.Branch, opt => opt.MapFrom(src => src.Branch.Name));
        }
    }
}