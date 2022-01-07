using System.Net.Http;
using System.Threading.Tasks;

namespace BenchmarkApplication
{
    class Client
    {

        public async Task<HttpResponseMessage> GetSmallPayloadAsync(string payload)

        {
            HttpClientHandler clientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
            };

            // Pass the handler to httpclient(from you are calling api)
            HttpClient client = new HttpClient(clientHandler);

            // Call the rest api and send the response

            HttpRequestMessage request = new(HttpMethod.Get, payload);

            HttpResponseMessage response = await client.SendAsync(request);

            return response;
        }
    }
}
