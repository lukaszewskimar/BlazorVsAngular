using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Ebooks.Core.Domain;

namespace Blazor.UI.Data
{
    public class EbookService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EbookService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Ebook>> GetAll(CancellationToken cancellationToken = default)
        {
            var httpClient = _httpClientFactory.CreateClient("ebooks-api-handler");

            using (var request = new HttpRequestMessage(HttpMethod.Get, $"ebooks"))
            {
                using (var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
                {
                    response.EnsureSuccessStatusCode();
                    return await JsonSerializer.DeserializeAsync<IEnumerable<Ebook>>(
                            await response.Content.ReadAsStreamAsync(),
                            options: new JsonSerializerOptions() { PropertyNameCaseInsensitive = true },
                            cancellationToken: cancellationToken
                        );
                }
            }
        }

        public async Task<Ebook> Get(int id, CancellationToken cancellationToken = default)
        {
            var httpClient = _httpClientFactory.CreateClient("ebooks-api-handler");

            using (var request = new HttpRequestMessage(HttpMethod.Get, $"ebooks/{id}"))
            {
                using (var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
                {
                    response.EnsureSuccessStatusCode();
                    return await JsonSerializer.DeserializeAsync<Ebook>(
                        await response.Content.ReadAsStreamAsync(),
                        options: new JsonSerializerOptions() { PropertyNameCaseInsensitive = true },
                        cancellationToken: cancellationToken
                    );
                }
            }
        }
    }
}
