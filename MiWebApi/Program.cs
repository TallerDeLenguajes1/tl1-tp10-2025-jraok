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
    Respuesta.EnsureSuccessStatusCode();
    string JsonRespuesta =await Respuesta.Content.ReadAsStringAsync();
    List<Universidad> Univerisdades = JsonSerializer.Deserialize<List<Universidad>>(JsonRespuesta);
    if (Univerisdades is not null)
    {
        foreach (Universidad UNI in Univerisdades)
        {
            
        }
        string jsonGuardado = JsonSerializer.Serialize(Univerisdades,new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText("Universidades_UK.json",jsonGuardado);
    }
}
catch (Exception error)
{
    Console.WriteLine($"\n\t\t---ERROR: {error.Message}");
}