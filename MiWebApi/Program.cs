using EspacioUniversidad;
using System.Text.Json;
using System.Net.Http;
using Internal;
// Cliente para realizar la solicitud
HttpClient Cliente = new HttpClient();
// Api con la lista de universidades en Reino Unido
string Api = "http://universities.hipolabs.com/search?country=United+Kingdom";

try
{
    HttpResponseMessage Respuesta = await Cliente.GetAsync(Api);
}
catch (Exception error)
{
    Console.WriteLine($"\n\t\t---ERROR: {error.Message}");
}