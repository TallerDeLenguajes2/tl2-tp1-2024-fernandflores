using System.Reflection.Emit;

var archivo= new archivosCvs();
var cadeteria= new Cadeteria();
var listadePedidos= new List<Pedido>(); // conexion debil, los pedidos existen independientemente del cadete exista o no, entonces se instancia en el program mientras que cliente se instancia en pedido
var ListaPedidoSinAsignar= new List<Pedido>();
cadeteria=archivo.LeerCadeteria("cadeteria.cvs");
// foreach (var cadete in cadeteria.ListaCadetes)  si no pondria en el constructor: "new List<Pedido>()" de archivos.cs leerCadetes usaria esta parte del codigo para crear las listas vacias a cada cadete
// {
//     cadete.ListaPedidos=new List<Pedido>();
// }
var pedido= new Pedido();
int opc;
var menu= new Menu();
// do
// {
//    
//     if (opc==1)listadePedidos.Add(pedido.AltaPedido(listadePedidos.Count)); 
//     if (opc==2)cadeteria.AsignarPedidoACadete(listadePedidos);
// }while(opc!=0);

do
{   
     opc=menu.MenuDeOpciones();
    switch (opc)
    {
        case 0: 
            Console.Clear();
            Console.WriteLine("gracias por usar el programa");
            Thread.Sleep(4000);
            break;
        case 1: 
            pedido= pedido.AltaPedido(listadePedidos.Count);
            listadePedidos.Add(pedido);
            ListaPedidoSinAsignar.Add(pedido);
            break;
        case 2:
            cadeteria.AsignarPedidoACadete(ListaPedidoSinAsignar);
            break;
        case 3:
            // Console.WriteLine("elegir numero de pedido a cambiar"); ES OTRA FORMA SOLO CAMBIA LA FORMA EN LA QUE SE MUESTRAN LAS COSAS
            // foreach (var item in listadePedidos)
            // {
            //     item.VerPedido();
            //     Console.WriteLine("Estado: "+item.Estado);
            // } 
            // int.TryParse(Console.ReadLine(), out int num);
            // var aux1= new Pedido();
            // foreach (var item in listadePedidos)
            // {
            //     aux1= item.RetornarPedido(listadePedidos,num);
            // }
            // if (aux1.Estado!=null)
            // {
            //     aux1.CambiarDeEstado();
            // }
            int numAux=1;
            Console.WriteLine("seleccione el pedido al que le cambiara el estado"); 
            for (int i = 0; i < cadeteria.ListaCadetes.Count; i++)
            {
                if (cadeteria.ListaCadetes[i].ListaPedidos.Count>=1)
                {
                    Console.WriteLine("\n\t\t\tcadete n° "+numAux);
                    cadeteria.ListaCadetes[i].VerTodosLosPedidos();
                    numAux++;
                }
            }
            int.TryParse(Console.ReadLine(), out int numeroDePedido);
            var pedidotemp= new Pedido();
            foreach (var cadete in cadeteria.ListaCadetes)
            {
                if(cadete.ListaPedidos.Count>=1)pedidotemp= pedidotemp.RetornarPedido(cadete.ListaPedidos, numeroDePedido);
            }
            if (pedidotemp.Estado!=null)
            {
                pedidotemp.CambiarDeEstado();
            }
            else
            {
                Console.WriteLine("no se encontro el pedido o no existe");
            }
            break;
        default:
            Console.WriteLine("opcion erronea");
            break;
    }
}while(opc!=0);
//metodos: obtener datos de cadeteria en cadete y ver info del pedido para cadete
Console.WriteLine("hola");
Console.WriteLine(opc);