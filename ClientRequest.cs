using System.Text.Json.Serialization;

namespace HelloAPI
{
    class ClientRequest {

        [JsonPropertyName("ClientName")]

        /// How to access this get method in MappingEndpoints file?
        public string ClientName { get; set; }

        public ClientRequest(string ClientName){
            this.ClientName = ClientName;
        }

        [JsonConstructor]
        public ClientRequest(){
            this.ClientName = string.Empty;
        }
    
        
        public string GetClientName(){
            return this.ClientName;
        }
    }
}