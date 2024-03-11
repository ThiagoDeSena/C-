using System.Text.Json;
using QuickType;
// using QuickType;


namespace ConsumindoApiComConsole
{
    class Program{
        static async Task Main(string[] args){
            HttpClient client = new HttpClient{BaseAddress = new Uri("https://jsonplaceholder.typicode.com")};
            var response = await client.GetAsync("/users");
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonSerializer.Deserialize<Person[]>(content);

            System.Console.WriteLine(content);
            
            foreach (var item in users)
            {
                System.Console.WriteLine(item.name);
                System.Console.WriteLine();
                System.Console.WriteLine(item.email);
            }
        }
    }
}






