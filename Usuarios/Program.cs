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
    if (Usuarios is not null)
    {
        Console.WriteLine("\n\t\t---USUARIOS---");
        Console.WriteLine($"\n| {"NOMBRE",-27} | {"CORREO",-25} | {"DIRECCIÓN",-50} |");
        Console.WriteLine(new string('-', 105));
        for (int i = 0; i < 5; i++)
        {
            Usuario U = Usuarios[i];
            Console.WriteLine($"| {U.Nombre,-27} | {U.Correo,-25} | {U.Direccion.Ciudad}, {U.Direccion.Calle} , {U.Direccion.Unidad}");
        }
        File.WriteAllText("Usuarios.json", JsonSerializer.Serialize(Usuarios, new JsonSerializerOptions { WriteIndented = true }));
        Console.WriteLine("\nArchivo 'usuarios.json' guardado correctamente.");
    }
}
catch (Exception error){
    Console.WriteLine("ERROR: " + error.Message);
}