public class Cadeteria
{
    private string nombre;
    private string telefono;
    public List<Cadete> listaCadetes;

    public Cadeteria()
    {
    }

    public Cadeteria(string nombre, string telefono, List<Cadete> cadetes)
    {
        this.nombre=nombre;
        this.telefono=telefono;
        listaCadetes= cadetes;
    }
}
