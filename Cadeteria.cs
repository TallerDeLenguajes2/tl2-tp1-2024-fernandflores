using System.Runtime.InteropServices;

public class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> listaCadetes;
    private List<Pedido> listaPedidos;
    public string Nombre { get => nombre;}
    public string Telefono { get => telefono;  }
    public List<Cadete> ListaCadetes { get => listaCadetes;}
    public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    public Cadeteria()
    {
    }

    public Cadeteria(string nombre, string telefono, List<Cadete>listaCadetes)
    {
        this.nombre=nombre;
        this.telefono=telefono;
        this.listaCadetes=listaCadetes;
    }
     public Cadete RetornarCadete(int identificacion)
    {
        var aux= new Cadete();
        bool encontrado=false;
        foreach (var cadete in ListaCadetes)
        {
            if (cadete.Id==identificacion)
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
       public Pedido RetornarPedido(int numero)
    {
        var aux= new Pedido();
        bool encontrado=false;
        foreach (var pedido in listaPedidos)
        {
            if (pedido.Numero==numero)
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
    public int MontoSueldos()
    {
        int monto=ListaCadetes.Count*500;
        return monto;
    }
    public int JornalACobrar(int id)
    { 
        int monto=0;
        foreach (var pedido in listaPedidos)
        {
            if (id==RetornarCadete(id).Id)
            {
                monto+=500;
            }
        }
        return monto;
    }
    public void AsignarPedidoACadet(int id, int numPedido)
    {
    
        var pedidoSinAsignar= new Pedido();
        pedidoSinAsignar= RetornarPedido(numPedido);        
        var cadeteAsignado= new Cadete();
        cadeteAsignado= RetornarCadete(id);
        pedidoSinAsignar.Cadete=cadeteAsignado;
        //listadoPedidos.Remove(pedidoSinAsignar); // lo quitamos de la lista pues ya esta asignado
    }
}
