namespace VSATemplate.Features.Products.GetProductById;

public sealed record GetProductByIdResponse(
    Guid Id,
    string Name,
    string Description,
    List<string> Categories,
    decimal Price);

public sealed class GetProductByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/products/{id}", async (Guid id, ISender sender) =>
        {
            var result = await sender.Send(new GetProductByIdQuery(id));

            return result.Match(
               onSuccess: () => Results.Ok(result.Value),
               onFailure: error => Results.BadRequest(error));
        })
        .WithName("GetProductById")
        .Produces<GetProductByIdResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Get Product by Id")
        .WithDescription("Get Product by Id");
    }
}
