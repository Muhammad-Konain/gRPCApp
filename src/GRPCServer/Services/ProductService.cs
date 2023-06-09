using Grpc.Core;

namespace GRPCServer.Services;

public class ProductService : GRPCServer.ProductService.ProductServiceBase
{
    public override Task<GetProductsResponse> GetAllProducts(GetProductRequest request, ServerCallContext context)
    {
        var products = GetMockProducts();

        var productsResponse = new GetProductsResponse();
        productsResponse.Products.AddRange(products);

        return Task.FromResult(productsResponse);
    }

    private List<ProductCatalog> GetMockProducts()
    {
        return new List<ProductCatalog>
        {
            new ProductCatalog 
            {
                Name = "product 1",
                Sku = "23",
                Price = 235
            },
            new ProductCatalog 
            {
                Name = "product 2",
                Sku = "223",
                Price = 27
            },
            
            new ProductCatalog 
            {
                Name = "product 3",
                Sku = "6547",
                Price = 64.1
            },
            new ProductCatalog 
            {
                Name = "product 4",
                Sku = "47438",
                Price = 989
            }
        };
    }
}