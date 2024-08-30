public class Cadete
{
    private int id;
    private string nombre;
    private string tel;
    private List<Pedido> listaPedidos;

    public string Nombre { get => nombre; }
    public string Tel { get => tel;  }
    public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    public Cadete(int id, string nombre, string tel, List<Pedido>listaPedidos)
    {
        this.id= id;
        this.nombre=nombre;
        this.tel=tel;
        this.listaPedidos=listaPedidos;// composicion(conexion debil entre clases) porque los pedidos van a existir incluso si el cadete se destruye, se instancia afuera en el program
    }

    public Cadete()
    {
    }

    public int JornalACobrar()
    {
        int ganancia=500;
        int cantidadDePedidos= ListaPedidos.Count;
        return (ganancia*cantidadDePedidos);
    }
    public void VerDatosCadete()
    {
        Console.WriteLine("id: "+id);
        Console.WriteLine("nombre: "+nombre);
        Console.WriteLine("tel: "+tel);
    }
    public Cadete RetornarCadete(int identificacion, List<Cadete>listaCad)
    {
        var aux= new Cadete();
        bool encontrado=false;
        foreach (var cadete in listaCad)
        {
            if (cadete.id==identificacion)
            {
                aux= cadete;
                encontrado=true;
            }
        }
        if(encontrado==true)
        {
            return aux;
        }
        else
        {
            return null;
        }
    }
    public void VerTodosLosPedidos()
    {
        Console.WriteLine("cadete: "+nombre);
        foreach (var pedido in listaPedidos)
        {
            Console.WriteLine("\ndatos del pedido:\n");
            pedido.VerPedido();
            pedido.VerDireccionCliente();
        }
    }
    public void VerPedidosEntregados()
    {
        Console.WriteLine("cadete: "+nombre);
        foreach (var pedido in listaPedidos)
        {
            if (pedido.Estado=="entregado")
            {
                Console.WriteLine(pedido.Observacion);
            }
        }
    }
    public void VerPedidosPendientes()
    {
        foreach (var pedido in listaPedidos)
        {
            if (pedido.Estado=="pendiente")
            {
                Console.WriteLine(pedido.Observacion);
                pedido.VerDireccionCliente();
                
            }
        }
    }
}
