using System.Runtime.InteropServices;

public class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> listaCadetes;

    public string Nombre { get => nombre;}
    public string Telefono { get => telefono;  }
    public List<Cadete> ListaCadetes { get => listaCadetes;}

    public Cadeteria()
    {
    }

    public Cadeteria(string nombre, string telefono, List<Cadete>listaCadetes)
    {
        this.nombre=nombre;
        this.telefono=telefono;
        this.listaCadetes=listaCadetes;
    }
    public int MontoSueldos()
    {
        int monto=ListaCadetes.Count*500;
        return monto;
    }
    public void AsignarPedidoACadete(List<Pedido> listadoPedidos)
    {
        Console.WriteLine("elija un pedido");
        foreach (var pedido in listadoPedidos)
        {
            Console.WriteLine("------------------------------");
            pedido.VerPedido();
            Console.WriteLine("------------------------------");
        }
        int.TryParse(Console.ReadLine(), out int num);
        var pedidoSinAsignar= new Pedido();
        pedidoSinAsignar=pedidoSinAsignar.RetornarPedido(listadoPedidos, num);
        Console.WriteLine("elija un cadete al que asignar el pedido seleccionado");
        foreach (var cadete in listaCadetes)
        {
            Console.WriteLine("------------------------------");
            cadete.VerDatosCadete();
            Console.WriteLine("------------------------------");
        }
        int.TryParse(Console.ReadLine(), out int idcadete);
        var cadeteAsignado= new Cadete();
        cadeteAsignado= cadeteAsignado.RetornarCadete(idcadete, listaCadetes);
        cadeteAsignado.ListaPedidos.Add(pedidoSinAsignar);
        listadoPedidos.Remove(pedidoSinAsignar); // lo quitamos de la lista pues ya esta asignado
    }
}
