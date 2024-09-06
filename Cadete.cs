using System.Text.Json;
using System.Text.Json.Serialization;

public class Cadete
{
    private int id;
    private string nombre;
    private string tel;
    [JsonPropertyName("nombre")]
    public string Nombre { get => nombre; set=> nombre=value;}
    [JsonPropertyName("telefono")]
    public string Tel { get => tel; set=> tel=value; }
    [JsonPropertyName("id")]
    public int Id { get => id; set => id= value;}

    public Cadete(int id, string nombre, string tel)
    {
        this.id= id;
        this.nombre=nombre;
        this.tel=tel;
    }

    public Cadete()
    {
    }
    //public override string ToString() // hacer que retorne la cadena de caracteres
    public void VerDatosCadete()
    {
        Console.WriteLine("id: "+Id);
        Console.WriteLine("nombre: "+nombre);
        Console.WriteLine("tel: "+tel);
    }
}
