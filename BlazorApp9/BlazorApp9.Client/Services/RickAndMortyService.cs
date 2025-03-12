
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorApp9.Client.Models;
namespace BlazorApp9.Client.Services { 

public class RickAndMortyService
{
    private readonly HttpClient _httpClient;

    public RickAndMortyService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResponse<Character>> GetCharactersAsync()
    {
        var response = await _httpClient.GetAsync("character");
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        var characters = JsonSerializer.Deserialize<ApiResponse<Character>>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        return characters;
    }
        public async Task DeleteCharacterAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"character/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al eliminar el personaje.");
            }
        }
    }
}