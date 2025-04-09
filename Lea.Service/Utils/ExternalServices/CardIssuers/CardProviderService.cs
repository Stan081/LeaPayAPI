using Lea.Service.DTOs;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Lea.Service
{
    public class CardProviderService
    {
        private readonly HttpClient _httpClient;

        public CardProviderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CardDto> RequestVisaCardAsync(CardRequestDto cardRequest)
        {
            var response = await _httpClient.PostAsJsonAsync("https://api.visa.com/cards", cardRequest);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CardDto>();
            }
            throw new Exception("Failed to request Visa card");
        }

        public async Task<CardDto> RequestMasterCardAsync(CardRequestDto cardRequest)
        {
            var response = await _httpClient.PostAsJsonAsync("https://api.mastercard.com/cards", cardRequest);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CardDto>();
            }
            throw new Exception("Failed to request MasterCard");
        }

        public async Task<CardDto> RequestVerveCardAsync(CardRequestDto cardRequest)
        {
            var response = await _httpClient.PostAsJsonAsync("https://api.verve.com/cards", cardRequest);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CardDto>();
            }
            throw new Exception("Failed to request Verve card");
        }
    }

}
