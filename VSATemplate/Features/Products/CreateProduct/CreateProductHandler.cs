namespace VSATemplate.Features.Products.CreateProduct;
public sealed record CreateProductCommand(
    string Name,
    string Description,
    List<string> Categories,
    decimal Price) : ICommand<Result<CreateProductResult>>;
public sealed record CreateProductResult(Guid Id);

public sealed class CreateProductCommandValidator
    : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required!");
        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage("Description is required!");
        RuleFor(x => x.Price)
            .GreaterThan(0.0m)
             .WithMessage("Price should be greater than zero!");
        RuleFor(x => x.Categories)
            .Must(x => x == null || x.Any())
            .WithMessage("Categories should have at least one category!");
    }
}

internal sealed class CreateProductCommandHandler(ApplicationDbContext dbContext)
   : ICommandHandler<CreateProductCommand, Result<CreateProductResult>>
{
    public async Task<Result<CreateProductResult>> Handle(CreateProductCommand command,
        CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            Categories = command.Categories,
            Price = command.Price,
            LastUpdatedOnUtc = DateTime.UtcNow
        };

        dbContext.Products.Add(product);

        await dbContext.SaveChangesAsync(cancellationToken);

        return new CreateProductResult(product.Id);
    }
}