public class Cadete
{
    private int id;
    private string nombre;
    private string tel;
    private List<Pedido> listaPedidos;

    public string Nombre { get => nombre; }
    public string Tel { get => tel;  }
    public int Id { get => id;}

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
