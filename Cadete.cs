public class Cadete
{
    private int id;
    private string nombre;
    private string tel;
    public List<Pedido> listaPedidos;

    public Cadete(int id, string nombre, string tel)
    {
        this.id= id;
        this.nombre=nombre;
        this.tel=tel;
     
         // composicion(conexion debil entre clases) porque los pedidos van a existir incluso si el cadete se destruye, se instancia afuera en el program
    }
    public int JornalACobrar()
    {
        int ganancia=500;
        int cantidadDePedidos= listaPedidos.Count;
        return (ganancia*cantidadDePedidos);
    }
}
