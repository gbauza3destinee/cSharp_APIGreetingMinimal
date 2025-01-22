
using Microsoft.AspNetCore.Mvc;

namespace HelloAPI
{


// WORKING 

class MappingEndpoints{

    // ******  Call response to retrieve and send back Hello string ********* //
    // --->  Method to be nested in api call from Program.cs 

    [HttpPost]
    public static IResult postName(ClientRequest clientName){

        // Handle Faulty Input
        // Trim leading/trailing whitespace
        
        if (string.IsNullOrWhiteSpace(clientName.getClientName().Trim())){
            return Results.BadRequest("No name provided in Request.");
        } else {
            return Results.Ok("Hello " + clientName.getClientName() + "!");

        }
       
    }

}


}