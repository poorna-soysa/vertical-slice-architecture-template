namespace VSATemplate.Features.Products;

public sealed class ProductNotFoundException(Guid Id)
    :Exception($"Product is not found for Id - {Id}")
{
}
