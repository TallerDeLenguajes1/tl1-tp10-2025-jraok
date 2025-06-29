using System.Text.Json.Serialization;
namespace EspacioTarea;

public class Tarea{
    
    [JsonPropertyName("userId")]
    public int UsuarioId { get; set; }

    [JsonPropertyName("id")]
    public int TareaId { get; set; }

    [JsonPropertyName("title")]
    public string Titulo { get; set; }
    
    [JsonPropertyName("completed")]
    public bool Completado { get; set; }

}