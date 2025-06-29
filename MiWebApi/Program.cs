using EspacioUniversidad;
using System.Text.Json;
using System.Net.Http;

// Cliente para realizar la solicitud
HttpClient Cliente = new HttpClient();
// Api con la lista de universidades en Reino Unido
string Api = "http://universities.hipolabs.com/search?country=United+Kingdom";

try
{
    Console.Clear();
    Console.WriteLine($"\n\t\t---TALLER DE LENGUAJES I---");
    HttpResponseMessage Respuesta = await Cliente.GetAsync(Api);
    Respuesta.EnsureSuccessStatusCode();
    string JsonRespuesta =await Respuesta.Content.ReadAsStringAsync();
    List<Universidad> Universidades = JsonSerializer.Deserialize<List<Universidad>>(JsonRespuesta);
    if (Universidades is not null)
    {
        Console.WriteLine($"\n\t\t---UNIVERSIDADES DE REINO UNIDO---");
        Console.WriteLine($"\n\t| {"NOMBRE",-51} | {"PAIS", -15} | {"PAGINA_WEB",-27} |");
        Console.WriteLine(new string('-',130));
        for (int i = 0; i < 10; i++)
        {
            Universidad UNI = Universidades[i];
            Console.WriteLine($"\t| { i+1+ "-" +UNI.Nombre,-51} | {UNI.Pais,-15} | {UNI.PaginasWeb[0],-27} |");
        }
        string jsonGuardado = JsonSerializer.Serialize(Universidades,new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText("Universidades_UK.json",jsonGuardado);
    }
}
catch (Exception error)
{
    Console.WriteLine($"\n\t\t---ERROR: {error.Message}");
}