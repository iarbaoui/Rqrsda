using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Rqrsda
{
    public class PreflightRequestHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Headers.Contains("Origin") && request.Method.Method == "OPTIONS")
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Headers.Add("Access-Control-Allow-Origin", "*");
                response.Headers.Add("Access-Control-Allow-Headers", "Origin, Content-Type, Accept, Authorization");
                response.Headers.Add("Access-Control-Allow-Methods", "*");

                var tcs = new TaskCompletionSource<HttpResponseMessage>();
                return tcs.Task;
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}