namespace VSATemplate.Features.Products.GetProducts;
public sealed record GetProductsQuery() : IQuery<Result<IEnumerable<GetProductsResult>>>;
public sealed record GetProductsResult(
    Guid Id,
    string Name,
    string Description,
    List<string> Categories,
    decimal Price);

internal sealed class GetProductsQueryHandler(ApplicationDbContext dbContext)
    : IQueryHandler<GetProductsQuery, Result<IEnumerable<GetProductsResult>>>
{
    public async Task<Result<IEnumerable<GetProductsResult>>> Handle(GetProductsQuery query,
        CancellationToken cancellationToken)
    {
        var products = await dbContext
            .Products
            .ToListAsync(cancellationToken);

        List<GetProductsResult> results = new();
        
        foreach (var item in products)
        {
            results.Add(new GetProductsResult(
                item.Id,
                item.Name,
                item.Description,
                item.Categories,
                item.Price));          
        }

        return results;
    }
}