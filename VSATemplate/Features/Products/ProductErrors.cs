namespace VSATemplate.Features.Products;

public static class ProductErrors
{
    public static Error NotFound(Guid id) =>
        new("Products.NotFound", $"The product with Id '{id}' was not found");
}
