﻿#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using static Ambev.DeveloperEvaluation.Application.Sales.CreateSale.CreateSaleCommand;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Profile for mapping between Sale entity and CreateSaleResponse
    /// </summary>
    public class CreateSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateSale operation
        /// </summary>
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleCommand, Sale>();
            CreateMap<Sale, CreateSaleResult>();
            CreateMap<CreateSaleProduct, SaleProduct>();
        }
    }
}