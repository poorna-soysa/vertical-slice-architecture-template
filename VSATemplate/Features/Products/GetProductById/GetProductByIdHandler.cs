namespace VSATemplate.Features.Products.GetProductById;
public sealed record GetProductByIdQuery(Guid Id) : IQuery<Result<GetProductByIdResult>>;
public sealed record GetProductByIdResult(
    Guid Id,
    string Name,
    string Description,
    List<string> Categories,
    decimal Price);

internal sealed class GetProductByIdQueryHandler(ApplicationDbContext dbContext)
    : IQueryHandler<GetProductByIdQuery, Result<GetProductByIdResult>>
{
    public async Task<Result<GetProductByIdResult>> Handle(GetProductByIdQuery query,
        CancellationToken cancellationToken)
    {
        var product = await dbContext
            .Products
            .FirstOrDefaultAsync(d=>d.Id == query.Id);

        if (product is null)
        {
            return Result.Failure<GetProductByIdResult>(ProductErrors.NotFound(query.Id));
        }

        var result = new GetProductByIdResult(
                 product.Id,
                 product.Name,
                 product.Description,
                 product.Categories,
                 product.Price);

        return result;
    }
}