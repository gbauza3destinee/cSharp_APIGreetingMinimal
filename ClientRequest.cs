using System.Text.Json.Serialization;

namespace HelloAPI
{
    /// "Constructor field unbinded" -> metadata for compiler
    class ClientRequest {

        [JsonPropertyName("ClientName")]
        private string ClientName;

        public ClientRequest(string ClientName){
            this.ClientName = ClientName;
        }

        [JsonConstructor]
        public ClientRequest(){
            this.ClientName = string.Empty;
        }
    
        
        public String GetClientName(){
            return this.ClientName;
        }
    }
}