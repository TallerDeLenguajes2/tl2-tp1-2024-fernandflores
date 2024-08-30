public class Pedido
{
    private int numero;
    private string observacion;
    private string estado;
    private Cliente datosCliente;

    public string Estado { get => estado; set => estado = value; }
    public string Observacion { get => observacion;}

    public Pedido(int num, string obs, string nombreCliente, string dirCliente, string telCliente, string refCliente)
    {
        numero=num;
        observacion=obs;
        Estado= "pendiente";
        datosCliente= new Cliente(nombreCliente,dirCliente,telCliente,refCliente); //agregacion(conexion fuerte entre clases) se instancia dentro del constructor para que datosclientes exista solo si pedidos existe   
    }

    public Pedido()
    {
    }

    public void VerDireccionCliente()
    {
        datosCliente.VerDireccion();
    }
    public void VerDatosClientes()
    {
        datosCliente.VerDatos();
    }
    
    public Pedido AltaPedido(int num)
    {
        string observacion, direccion, tel, referencia, nombre;
        Console.WriteLine("ingrese producto a pedir");
        observacion=Console.ReadLine();
        Console.WriteLine("ingrese su nombre");
        nombre= Console.ReadLine();
        Console.WriteLine("ingrese su direccion");
        direccion=Console.ReadLine();
        Console.WriteLine("ingrese referencia sobre su casa");
        referencia=Console.ReadLine();
        Console.WriteLine("ingrese un numero de telefono");
        tel= Console.ReadLine();
        num++;
        var pedido= new Pedido(num,observacion,nombre,direccion,tel,referencia);
        return pedido;
    }
    public void VerPedido()
    {
        Console.WriteLine("pedido numero: "+numero);
        Console.WriteLine("observacion del pedido: "+observacion);
    }
    public Pedido RetornarPedido(List<Pedido> pedidos, int numero)
    {
        var aux= new Pedido();
        bool encontrado=false;
        foreach (var pedido in pedidos)
        {
            if (pedido.numero==numero)
            {
                aux= pedido;
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
    public void CambiarDeEstado()
    {
        if (estado=="pendiente")
        {
            estado="entregado";
        }
        else if(estado == "entregado")
        {
            estado= "pendiente";
        }
    }
    
}
