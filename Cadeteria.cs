using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

public class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> listaCadetes;
    private List<Pedido> listaPedidos;
    [JsonPropertyName("nombre")]
    public string Nombre { get => nombre; set => nombre=value;}
    [JsonPropertyName("telefono")]
    public string Telefono { get => telefono; set => telefono=value; }
   
    public List<Cadete> ListaCadetes { get => listaCadetes;}
    public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    public Cadeteria()
    {
    }

    public Cadeteria(string nombre, string telefono, List<Cadete>listaCadetes, List<Pedido>listaPedidos)
    {
        this.nombre=nombre;
        this.telefono=telefono;
        this.listaCadetes=listaCadetes;
        this.listaPedidos= listaPedidos;
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

    public bool CambiarEstadoPedido(int numPedido)
    {
        foreach (var item in listaPedidos)
        {
            if(item.Numero==numPedido)
            {
                item.CambiarDeEstado();
                return true;
            }
        }
        return false;
    }
}
