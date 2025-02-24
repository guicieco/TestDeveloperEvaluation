#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    public class GetSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetUser operation
        /// </summary>
        public GetSaleProfile()
        {
            CreateMap<Sale, GetSaleResult>();
        }
    }
}