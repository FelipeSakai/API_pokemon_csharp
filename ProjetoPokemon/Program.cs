using Newtonsoft.Json.Linq;
using RestSharp;

namespace ProjetoPokemon
{
    class program
    {
        static void Main(string[] args)
        {
            InvocarGet();
        }
        private static void InvocarGet()
        {

            var client = new RestClient("https://pokeapi.co/api/v2/pokemon/dragonite");
            var request = new RestRequest(" ", Method.Get);
            var respose = client.Execute(request);

            if (respose.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonFormatado = JToken.Parse(respose.Content).ToString(Newtonsoft.Json.Formatting.Indented);
                Console.WriteLine(jsonFormatado);
            }
            else
            {
                Console.WriteLine(respose.ErrorMessage);
            }
            Console.ReadKey();
        }

    }
}