

using System.Net.Http.Headers;
using System.Text.Json;
using QuickType;

namespace ConsumindoApiHttpClient;


public class Program
{
    public static async Task Main(string[] args){
        
        

            
        var cep = "61814300";    
            
        HttpClient client = new HttpClient{BaseAddress = new Uri("https://opencep.com")};


        var response = await client.GetAsync($"/v1/{cep}");

        var content = await response.Content.ReadAsStringAsync();

        var endereco = JsonSerializer.Deserialize<Endereco>(content);


        // System.Console.WriteLine(content);
        System.Console.WriteLine($"Bairro: {endereco.bairro}");
        System.Console.WriteLine($"Logadouro: {endereco.cep}");


        
        

        
    }
}



