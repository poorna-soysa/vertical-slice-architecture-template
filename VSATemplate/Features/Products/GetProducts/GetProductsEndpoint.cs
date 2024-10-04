namespace VSATemplate.Features.Products.GetProducts;

public sealed record GetProductsResponse(
    Guid Id,
    string Name,
    string Description,
    List<string> Categories,
    decimal Price);

public sealed class GetProductsEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/products", async (ISender sender) =>
        {
            var result = await sender.Send(new GetProductsQuery());

            return result.Match(
               onSuccess: () => Results.Ok(result.Value),
               onFailure: error => Results.BadRequest(error));
        })
        .WithName("GetProducts")
        .Produces<IEnumerable<GetProductsResponse>>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Get Products")
        .WithDescription("Get Products");
    }
}
