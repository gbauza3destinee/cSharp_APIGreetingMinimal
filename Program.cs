using HelloAPI;

class Program {


    public static void Main(string[] args){
            
    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    // app.MapGet("/", () => "Hello World!");

    // The Entry point of the app 
    app.MapPost("/clientName", MappingEndpoints.postName);
    app.Run();

    }


}
