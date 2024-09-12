public static class AltaPedidoUI
{
public static int i=0;
    public static Pedido AltaPedido()
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
        i++;
        var pedido= new Pedido(i,observacion,nombre,direccion,tel,referencia);
        return pedido;
    }
}