﻿#region Using

using MediatR;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale
{
    public class DeleteSaleCommand : IRequest<DeleteSaleResponse>
    {
        public Guid Id { get; }

        public DeleteSaleCommand(Guid id)
        {
            Id = id;
        }
    }
}