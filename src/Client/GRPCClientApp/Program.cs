using Grpc.Net.Client;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7156");

//var client = new Greeter.GreeterClient(channel);
var client = new GRPCClient.ProductService.ProductServiceClient(channel);
var reply = client.GetAllProducts(new GRPCClient.GetProductRequest{});

Console.WriteLine("Greeting: " + reply.Products);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();