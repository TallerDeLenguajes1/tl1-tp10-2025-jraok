using System.Text.Json.Serialization;
namespace EspacioUsuarios;

public class Geolocalizacion
{
    [JsonPropertyName("lat")]
    public string Lat { get; set; }

    [JsonPropertyName("lng")]
    public string Lng { get; set; }
}

public class Direccion
{
    [JsonPropertyName("street")]
    public string Calle { get; set; }

    [JsonPropertyName("suite")]
    public string Unidad { get; set; }

    [JsonPropertyName("city")]
    public string Ciudad { get; set; }

    [JsonPropertyName("zipcode")]
    public string CodigoPostal { get; set; }

    [JsonPropertyName("geo")]
    public Geolocalizacion Geolocalizacion { get; set; }
}

public class Empresa
{
    [JsonPropertyName("name")]
    public string Nombre { get; set; }

    [JsonPropertyName("catchPhrase")]
    public string Eslogan { get; set; }

    [JsonPropertyName("bs")]
    public string Bs { get; set; }
}

public class Usuario
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Nombre { get; set; }

    [JsonPropertyName("username")]
    public string UserName { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("address")]
    public Direccion Direccion { get; set; }

    [JsonPropertyName("phone")]
    public string Telefono { get; set; }

    [JsonPropertyName("website")]
    public string SitioWeb { get; set; }

    [JsonPropertyName("company")]
    public Empresa Empresa { get; set; }
}