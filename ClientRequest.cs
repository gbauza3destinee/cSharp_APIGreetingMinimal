using System.Text.Json.Serialization;

namespace HelloAPI
{
    /// "Constructor field unbinded" -> metadata for compiler
    class ClientRequest {
        private string clientName;

        public ClientRequest(String clientName){
            this.clientName = clientName;
        }

        [JsonConstructor]
        public ClientRequest(){
            this.clientName = string.Empty;
        }
    
        
        public String getClientName(){
            return this.clientName;
        }
    }
}