﻿#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

#endregion


namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    /// <summary>
    /// Profile for mapping between Sale entity and GetUserResponse
    /// </summary>
    public class GetSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSale operation
        /// </summary>
        public GetSaleProfile()
        {
            CreateMap<Sale, GetSaleResult>();
        }
    }
}