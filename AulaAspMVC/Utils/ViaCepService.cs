using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class ViaCepService
{
    private readonly HttpClient _httpClient;

    public ViaCepService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Endereco> GetEnderecoByCepAsync(string cep)
    {
        return await _httpClient.GetFromJsonAsync<Endereco>($"https://viacep.com.br/ws/{cep}/json/");
    }
}

public class Endereco
{
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Localidade { get; set; }
    public string Uf { get; set; }
}
