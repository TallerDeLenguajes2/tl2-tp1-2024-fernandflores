using System.Reflection.Emit;

var archivo= new archivosCvs();
var cadeteria= new Cadeteria();
var listadePedidos= new List<Pedido>(); // conexion debil, los pedidos existen independientemente del cadete exista o no, entonces se instancia en el program mientras que cliente se instancia en pedido
cadeteria=archivo.LeerCadeteria("cadeteria.cvs");
var pedido= new Pedido();
int opc;
var menu= new Menu();
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
            break;
        case 2:
            Console.WriteLine("elija un pedido para asignarlo a un cadete");
            foreach (var aux in cadeteria.ListaPedidos)
            {
                Console.WriteLine("------------------------------");
                aux.VerPedido();
                Console.WriteLine("------------------------------");
            }
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine("elija un cadete al que asignar el pedido seleccionado");
            foreach (var cadete in cadeteria.ListaCadetes)
            {
                Console.WriteLine("------------------------------");
                cadete.VerDatosCadete();
                Console.WriteLine("------------------------------");
            }
            int.TryParse(Console.ReadLine(), out int idcadete);
            cadeteria.AsignarPedidoACadet(idcadete,num);
            break;
        case 3:
            Console.WriteLine("seleccione el pedido al que le cambiara el estado"); 
            foreach (var item in listadePedidos)
            {
                item.VerPedido();
                Console.WriteLine("cadete a cargo: "+item.Cadete.Nombre);
            }
            int.TryParse(Console.ReadLine(), out num);
            bool findCambioEstado=false;
            foreach (var item in listadePedidos)
            {
                if(item.Numero==num)
                {
                    item.CambiarDeEstado();
                    findCambioEstado=true;
                }
            }
            if (!findCambioEstado)Console.WriteLine("no se encontro el pedido o no existe"); 
            break;
        default:
            Console.WriteLine("opcion erronea");
            break;
    }
}while(opc!=0);