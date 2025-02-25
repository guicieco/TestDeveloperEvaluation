﻿#region Using

using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale
{
    public class DeleteSaleHandler : IRequestHandler<DeleteSaleCommand, DeleteSaleResponse>
    {
        private readonly ISaleRepository _saleRepository;

        /// <summary>
        /// Initializes a new instance of DeleteUserHandler
        /// </summary>
        /// <param name="userRepository">The user repository</param>
        /// <param name="validator">The validator for DeleteUserCommand</param>
        public DeleteSaleHandler(
            ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        /// <summary>
        /// Handles the DeleteUserCommand request
        /// </summary>
        /// <param name="request">The DeleteUser command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The result of the delete operation</returns>
        public async Task<DeleteSaleResponse> Handle(DeleteSaleCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteSaleValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var success = await _saleRepository.DeleteAsync(request.Id, cancellationToken);
            if (!success)
                throw new KeyNotFoundException($"Sale with ID {request.Id} not found");

            return new DeleteSaleResponse { Success = true };
        }
    }
}