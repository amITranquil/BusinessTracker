using FluentValidation;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Category).NotEmpty();
        RuleFor(c => c.StockQuantity).NotEmpty();
        RuleFor(c => c.UnitPrice).NotEmpty();
        RuleFor(c => c.IsActive).NotEmpty();
    }
}