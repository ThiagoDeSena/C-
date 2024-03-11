using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using QuickType;

namespace ConsumindoApiHttpClient;


public class Program
{
    public static async Task Main(string[] args){
        
        using (var httpClient = new HttpClient()){

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");

            if(response.IsSuccessStatusCode){

                var content = await response.Content.ReadAsStringAsync();

                
                var pessoa = JsonSerializer.Deserialize<Person[]>(content);

                foreach (var item in pessoa)
                {
                    System.Console.WriteLine($"Nome: {item.name}");
                    System.Console.WriteLine($"Email: {item.email}");
                    System.Console.WriteLine();
                }

                
            }else{
                System.Console.WriteLine("Erro ao acessar a API: "+response.StatusCode);
            }
        }
    }
}
