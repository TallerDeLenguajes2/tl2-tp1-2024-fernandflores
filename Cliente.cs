public class Cliente
{
    private string nombre;
    private string direccion;
    private string tele;
    private string referencia;

    public Cliente(string nombre, string direccion, string tele, string referencia)
    {
        this.nombre=nombre;
        this.direccion= direccion;
        this.tele=tele;
        this.referencia=referencia;
    }
    public void VerDireccion()
    {
        Console.WriteLine("direccion del cliente: "+direccion);
        Console.WriteLine("referencias: "+referencia);
    }
    public void VerDatos()
    {
        Console.WriteLine("nombre del cliente: "+nombre);
        Console.WriteLine("telefono: "+tele);
    }
}