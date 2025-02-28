#region Using

using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Handler for processing CreateSaleCommand requests
    /// </summary>
    public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        private static readonly Dictionary<int, int> _discountRules = new()
        {
            // If a product has at least 4 units, apply a 10% discount
            { 4, 10 },
            
            // If a product has at least 10 units, apply a 20% discount
            { 10, 20 }
        };

        /// <summary>
        /// Initializes a new instance of CreatesaleHandler
        /// </summary>
        /// <param name="saleRepository"></param>
        /// <param name="productRepository"></param>
        /// <param name="mapper"></param>
        public CreateSaleHandler(ISaleRepository saleRepository, IProductRepository productRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the CreatesaleCommand request
        /// </summary>
        /// <param name="command">The Createsale command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created sale details</returns>
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

        /// <summary>
        /// Calculate total of sale
        /// </summary>
        /// <param name="products"></param>
        /// <param name="discount"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        private async Task<(decimal Total, decimal TotalDiscount)> CalculateTotal(List<SaleProduct> products, decimal discount, CancellationToken cancellationToken)
        {
            var ids = products.Select(p => p.ProductId).ToList();
            var productList = await _productRepository.GetByIdAsync(ids, cancellationToken);

            var total = products.Sum(lp => lp.Quantity * productList.First(p => p.Id == lp.ProductId).Price);
            var totalDiscount = discount > 0 ? ApplyDiscount(total, discount) : total;

            return (total, totalDiscount);
        }

        /// <summary>
        /// if necessary the discount will be applied
        /// </summary>
        /// <param name="originalPrice"></param>
        /// <param name="discountPercentage"></param>
        /// <returns></returns>
        private static decimal ApplyDiscount(decimal originalPrice, decimal discountPercentage)
        {
            return originalPrice * (1 - discountPercentage / 100);
        }

        /// <summary>
        /// Get range of discount
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
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
