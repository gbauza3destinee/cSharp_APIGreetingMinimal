
using Microsoft.AspNetCore.Mvc;

namespace HelloAPI
{


// WORKING 

class MappingEndpoints{

    // ******  Call response to retrieve and send back Hello string ********* //
    // --->  Method to be nested in api call from Program.cs 

    [HttpPost]
    public static IResult PostName(ClientRequest ClientName){

        // Capture value of ClientName 

        System.Diagnostics.Debug.Write(ClientName);
        
        // Trim leading/trailing whitespace

        if (string.IsNullOrWhiteSpace(ClientName.GetClientName().Trim())){
            return Results.BadRequest("No name provided in Request.");
        } else {
            return Results.Ok("Hello " + ClientName.GetClientName() + "!");

        }
       
    }

}


}