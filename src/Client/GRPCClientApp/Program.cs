using Grpc.Net.Client;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7156");

//var client = new Greeter.GreeterClient(channel);
var client = new GRPCClient.ProductService.ProductServiceClient(channel);
var reply = client.GetAllProducts(new GRPCClient.GetProductRequest{});

foreach (var product in reply.Products)
{
    Console.WriteLine($"Name: {product.Name}, SKU: {product.Sku}, Price: {product.Price}");
}
