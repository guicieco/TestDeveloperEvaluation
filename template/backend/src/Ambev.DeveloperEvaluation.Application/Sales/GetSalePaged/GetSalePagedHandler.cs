#region Using

using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    public class GetSalePagedHandler : IRequestHandler<GetSalePagedCommand, GetSalePagedResult>
    {
        private readonly ISalePagedRepository _salePagedRepository;
        private readonly IMapper _mapper;

        public GetSalePagedHandler(
            ISalePagedRepository salePagedRepository,
            IMapper mapper)
        {
            _salePagedRepository = salePagedRepository;
            _mapper = mapper;
        }

        public async Task<GetSalePagedResult> Handle(GetSalePagedCommand request, CancellationToken cancellationToken)
        {
            var validator = new GetSalePagedValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var count = await _salePagedRepository.GetCount(request.Name);
            if (count == 0)
                return await Task.FromResult(new GetSalePagedResult() { Count = 0, List = null, Page = 0, Size = 0 });

            var list = await _salePagedRepository.GetPaged(request.Name, request.Page, request.Size);
            var sales = _mapper.Map<IEnumerable<SaleForPagedDto>>(list);
            
            return await Task.FromResult(new GetSalePagedResult() { Count = count, List = sales, Page = request.Page, Size = request.Size });
        }
    }
}