#region Using

using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        private static readonly Dictionary<int, int> _discountRules = new()
        {
            // If a product has at least 10 units, apply a 20% discount
            { 10, 20 }, 
            
            // If a product has at least 4 units, apply a 10% discount
            { 4, 10 }   
        };

        public CreateSaleHandler(ISaleRepository saleRepository, IProductRepository productRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CreateSaleResult> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateSaleCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var sale = _mapper.Map<Sale>(command);
            var saleProduct = _mapper.Map<List<SaleProduct>>(command.Products);

            sale.Discount = GetDiscount(saleProduct);
            var (total, totalDiscount) = await CalculateTotal(saleProduct, sale.Discount, cancellationToken);

            sale.Total = total;
            sale.TotalDiscount = totalDiscount;

            var createdSale = await _saleRepository.CreateAsync(sale, saleProduct, cancellationToken);
            return _mapper.Map<CreateSaleResult>(createdSale);
        }

        private async Task<(decimal Total, decimal TotalDiscount)> CalculateTotal(List<SaleProduct> products, decimal discount, CancellationToken cancellationToken)
        {
            var ids = products.Select(p => p.ProductId).ToList();
            var productList = await _productRepository.GetByIdAsync(ids, cancellationToken);

            var total = products.Sum(lp => lp.Quantity * productList.First(p => p.Id == lp.ProductId).Price);
            var totalDiscount = discount > 0 ? ApplyDiscount(total, discount) : total;

            return (total, totalDiscount);
        }

        private static decimal ApplyDiscount(decimal originalPrice, decimal discountPercentage)
        {
            return originalPrice * (1 - discountPercentage / 100);
        }

        private int GetDiscount(List<SaleProduct> products)
        {
            foreach (var (quantity, discount) in _discountRules.OrderByDescending(d => d.Key))
            {
                if (products.Any(p => p.Quantity >= quantity))
                    return discount;
            }

            return 0;
        }
    }
}
