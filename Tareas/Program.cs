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
