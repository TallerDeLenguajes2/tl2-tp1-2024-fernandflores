public class Pedido
{
    private int numero;
    private string observacion;
    private string cliente;
    private string estado;
    private Cliente datosCliente;

    public Pedido(int numero, string obs, string cliente, string nombreCliente, string dirCliente, string telCliente, string refCliente)
    {
        this.numero=numero;
        observacion=obs;
        this.cliente=cliente;
        estado= "pendiente";
        datosCliente= new Cliente(nombreCliente,dirCliente,telCliente,refCliente); //agregacion(conexion fuerte entre clases) se instancia dentro del constructor para que datosclientes exista solo si pedidos existe   
    }
    public void VerDireccionCliente()
    {
        datosCliente.VerDireccion();
    }
    public void VerDatosClientes()
    {
        datosCliente.VerDatos();
    }
}
