using Grpc.Core;

namespace GRPCServer.Services;

public class ProductService : GRPCServer.ProductService.ProductServiceBase
{
    public override Task<GetProductsResponse> GetAllProducts(GetProductRequest request, ServerCallContext context)
    {
        return Task.FromResult(new GetProductsResponse
        {
            Name = "product 1",
            Sku = "23",
            Price = 235
        });
    }
}