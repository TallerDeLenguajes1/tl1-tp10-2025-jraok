using EspacioTarea;
using System.Text.Json;
using System.Net.Http;
// Cliente para realizar la solicitud HTTP
HttpClient cliente = new HttpClient();
// URL del recurso JSON (tareas)
string url = "https://jsonplaceholder.typicode.com/todos";
// Instancia de HttpClient para conectarse a la API REST de tareas
HttpResponseMessage respuesta = await cliente.GetAsync(url);    // Solicitud GET a la API
respuesta.EnsureSuccessStatusCode();    // Lanza excepción si el estado no es exitoso
// Lee el contenido de la respuesta como string JSON
string jsonRespuesta = await respuesta.Content.ReadAsStringAsync();
// Lista con objetos deserializados del JSON
List<Tarea> listaTareas = JsonSerializer.Deserialize<List<Tarea>>(jsonRespuesta);
// Si la deserializacion no es nuula pasamos a sepaprar las tareas
if (listaTareas is not null)
{
    List<Tarea> pendientes = listaTareas.Where(unidad => !unidad.Completado).ToList();  /* Lista de tareas pendientes */
    List<Tarea> completadas = listaTareas.Where(unidad => unidad.Completado).ToList();  /* Lista de tareas completadas */

    /* Impresion de los datos de las tareas */
    Console.WriteLine("\n\t\t---TAREAS PENDIENTES---");
    if (pendientes.Any())/* Si la lista tiene algún elemento ingreso a la impresion */
    {  
        Console.WriteLine($"\n| {"ID_USER", -10} | {"ID_TAREA", -10} | {"TITULO", -40}");   /* Fila con los titulos de las columnas */
        Console.WriteLine(new string('-', 90)); /* Separador visual */
        foreach (Tarea tarea in pendientes) /* recorrido de la lista de pendientes */
        {
            Console.WriteLine($"|     {tarea.UsuarioId, -6} |     {tarea.TareaId, -6} | {tarea.Titulo,-40}");
        }
    }else{
        Console.WriteLine("\n\t\t---lista vacia---");
    }
    
    Console.WriteLine("\n\t\t---TAREAS COMPLETAS---");
    if (completadas.Any()) /* Si la lista tiene algún elemento ingreso a la impresion */
    {  
        Console.WriteLine($"\n| {"ID_USER", -10} | {"ID_TAREA", -10} | {"TITULO", -40}");   /* Fila con los titulos de las columnas */
        Console.WriteLine(new string('-', 90)); /* Separador visual */
        foreach (Tarea tarea in completadas) /* recorrido de la lista de completadas */
        {
            Console.WriteLine($"|     {tarea.UsuarioId, -6} |     {tarea.TareaId, -6} | {tarea.Titulo,-40}");
        }
    }else{
        Console.WriteLine("\n\t\t---lista vacia---");
    }
    // Proceso de guardado de la lista de completadas en un archivo JSON
    string jsonGuardado = JsonSerializer.Serialize(listaTareas,new JsonSerializerOptions {WriteIndented = true});/* Serializacion de la lista de objetos */
    File.WriteAllText("tareas.json",jsonGuardado);  /* creacion del archivo JSON */
}else{
    Console.WriteLine("---ERROR: No se pudo deserializar la respuesta");    /* mensaje de error */
}