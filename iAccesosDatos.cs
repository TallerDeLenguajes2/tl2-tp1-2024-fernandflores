public interface iAccesosDatos 
{
    List<Cadete> LeerCadetes(string nombreArchivo);
    Cadeteria LeerCadeteria(string nombreArchivo, List<Pedido> pedidos);
}