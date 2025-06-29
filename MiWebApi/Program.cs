using EspacioUniversidad;
using System.Text.Json;
using System.Net.Http;

// Cliente para realizar la solicitud
HttpClient Cliente = new HttpClient();
// Api con la lista de universidades en Reino Unido
string Api = "http://universities.hipolabs.com/search?country=United+Kingdom";

try
{
    Console.Clear();    /* limpieza de consola */
    Console.WriteLine($"\n\t\t---TALLER DE LENGUAJES I---");
    // Instancia para conectarse a la Api
    HttpResponseMessage Respuesta = await Cliente.GetAsync(Api);
    Respuesta.EnsureSuccessStatusCode();    /* corroboracion de la conexion */

    string JsonRespuesta = await Respuesta.Content.ReadAsStringAsync();  /* lectura del contenido a formato Json */
    List<Universidad> Universidades = JsonSerializer.Deserialize<List<Universidad>>(JsonRespuesta);/* lista con las universidades de reino unido */
    if (Universidades is not null)  /* verificacion del contenido de la lista */
    {
        /* muestra de la lista de universidades */
        Console.WriteLine($"\n\t\t---UNIVERSIDADES DE REINO UNIDO---");
        Console.WriteLine($"\n\t| {"NOMBRE",-51} | {"PAIS", -15} | {"PAGINA_WEB",-27} |");
        Console.WriteLine(new string('-',130));
        for (int i = 0; i < 10; i++)
        {
            Universidad UNI = Universidades[i];
            Console.WriteLine($"\t| { i+1+ "-" +UNI.Nombre,-51} | {UNI.Pais,-15} | {UNI.PaginasWeb[0],-27} |");
        }
        // serializacion del Json para guardar
        string jsonGuardado = JsonSerializer.Serialize(Universidades,new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText("Universidades_UK.json",jsonGuardado);    /* guardado del Json */
    }
}
catch (Exception error)
{
    Console.WriteLine($"\n\t\t---ERROR: {error.Message}");  /* mensaje de error para la conexion */
}