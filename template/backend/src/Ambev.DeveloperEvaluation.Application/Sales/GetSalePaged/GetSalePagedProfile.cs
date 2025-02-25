#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    public class GetSalePagedProfile : Profile
    {
        public GetSalePagedProfile()
        {
            CreateMap<Sale, SaleForPagedDto>()
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer.Name))
                .ForMember(dest => dest.Branch, opt => opt.MapFrom(src => src.Branch.Name));
        }
    }
}