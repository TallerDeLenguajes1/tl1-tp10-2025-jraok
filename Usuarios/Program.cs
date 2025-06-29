using EspacioUsuarios;
using System.Text.Json;
using System.Net.Http;

HttpClient Cliente = new HttpClient();

string Api = "https://jsonplaceholder.typicode.com/users";
Console.WriteLine("\n\t\t---TALLER DE LENGUAJES I---");
try
{
    HttpResponseMessage Respuesta = await Cliente.GetAsync(Api);
    Respuesta.EnsureSuccessStatusCode();
    string JsonRespuesta = await Respuesta.Content.ReadAsStringAsync();
    List<Usuario> Usuarios = JsonSerializer.Deserialize<List<Usuario>>(JsonRespuesta);
    
}
catch (Exception error){
    Console.WriteLine("ERROR: " + error.Message);
}