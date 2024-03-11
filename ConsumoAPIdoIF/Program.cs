using System.Text.Json;
using System.Text.Json.Serialization;
using QuickType;

namespace ConsumindoAPIdoIF
{
    class Program
    {
        static async Task Main(String[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://api-v2.intranet.maracanau.ifce.edu.br") };

            // Teste = https://api.intranet-h.maracanau.ifce.edu.br/v1/transito-catraca
            // API CÓDIGO ORIGINAL = https://api-v2.intranet.maracanau.ifce.edu.br
            // /v1/integracao/transito/tag?cartao=21646000&usuario=c4tr4c4&senha=YzR0cjRjNHA0c3N3MHJk
            // Guilherme = 13218530
            // Thiago = 21646000
            var dadosTag = "21646000";
            var usuario = "c4tr4c4";
            var senha = "YzR0cjRjNHA0c3N3MHJk";

            // código original = /v1/integracao/transito/tag?cartao={dadosTag}&usuario={usuario}&senha={senha}
            var response = await client.GetAsync($"/v1/integracao/transito/tag?cartao={dadosTag}&usuario={usuario}&senha={senha}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var cartao = JsonSerializer.Deserialize<Autorizacao>(content);

                System.Console.WriteLine(cartao.autorizacao);

                if (cartao.autorizacao == 1)
                {
                    System.Console.WriteLine("Aluno do Campus, autorizado entrada!");
                }
                else if (cartao.autorizacao == 0)
                {
                    System.Console.WriteLine("Não é aluno do campus, entrada negada!");
                }
            }else
            {
                System.Console.WriteLine("Conexão com a API falhou!");
            }

        }
    }
}


