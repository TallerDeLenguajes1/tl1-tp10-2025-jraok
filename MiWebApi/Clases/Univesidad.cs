using System.Text.Json.Serialization;
namespace EspacioUniversidad

{
    public class Universidad{
        [JsonPropertyName("name")]
    public string Nombre { get; set; }

    [JsonPropertyName("alpha_two_code")]
    public string CodigoPais { get; set; }

    [JsonPropertyName("country")]
    public string Pais { get; set; }

    [JsonPropertyName("state-province")]
    public string Provincia { get; set; }

    [JsonPropertyName("web_pages")]
    public List<string> PaginasWeb { get; set; }

    [JsonPropertyName("domains")]
    public List<string> Dominios { get; set; }
    }
}