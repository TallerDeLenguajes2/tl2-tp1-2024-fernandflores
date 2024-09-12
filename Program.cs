using System.Reflection.Emit;

var archivoCvs= new AccesoCvs();
var archivoJson= new AccesoJson();
var cadeteria= new Cadeteria();
var listadePedidos= new List<Pedido>(); // conexion debil, los pedidos existen independientemente del cadete exista o no, entonces se instancia en el program mientras que cliente se instancia en pedido
var pedido= new Pedido();
int opc;
var menu= new Menu();
Console.WriteLine("elija como cargar los datos\n1:Json\n2:CVS");
int opcionArchivo= int.Parse(Console.ReadLine());
if(opcionArchivo==1)cadeteria=archivoJson.LeerCadeteria("cadeteria.json", listadePedidos);
if(opcionArchivo==2)cadeteria=archivoCvs.LeerCadeteria("cadeteria.cvs", listadePedidos);
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
            pedido= AltaPedidoUI.AltaPedido();
            listadePedidos.Add(pedido);
            break;
        case 2:
            Console.WriteLine("elija un pedido para asignarlo a un cadete");
            foreach (var aux in cadeteria.ListaPedidos.Where(p=>p.Cadete==null))// tambien se puede usar solo listapedidos sin el cadeteria. ya que cadeteria.listadopedidos "apunta" a esa lista (listadoPedidos)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(aux); //usa el .tostring para mostrar
                Console.WriteLine("------------------------------");
            }
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine("elija un cadete al que asignar el pedido seleccionado");
            foreach (var cadete in cadeteria.ListaCadetes)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(cadete); //usa el .tostring para mostrar
                Console.WriteLine("------------------------------");
            }
            int.TryParse(Console.ReadLine(), out int idcadete);
            cadeteria.AsignarPedidoACadet(idcadete,num);
            break;
        case 3:
            Console.WriteLine("seleccione el pedido al que le cambiara el estado"); 
            foreach (var item in listadePedidos.Where(p=>p.Cadete!=null))
            {
                Console.WriteLine(item); // usa para mostrar el .tostring
                if(item.Cadete!=null)
                {
                    Console.WriteLine("cadete a cargo: "+item.Cadete.Nombre);
                }
                else
                {
                    Console.WriteLine("no tiene asignacion");
                }
            }
            int.TryParse(Console.ReadLine(), out num);

            if(!cadeteria.CambiarEstadoPedido(num))Console.WriteLine("no se encontro el pedido o no existe"); 
            break;
        case 4: 
            Console.WriteLine("seleccione el pedido al que le cambiara el estado"); 
            foreach (var item in listadePedidos.Where(p=>p.Cadete!=null))
            {
                Console.WriteLine(item);
                Console.WriteLine("cadete a cargo: "+item.Cadete.Nombre);
            }
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("elija un cadete al que reasignara el pedido seleccionado");
            foreach (var cadete in cadeteria.ListaCadetes)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(cadete);
                Console.WriteLine("------------------------------");
            }
            int.TryParse(Console.ReadLine(), out  idcadete);
            cadeteria.AsignarPedidoACadet(idcadete,num);
            break;
        case 5: 
            Funciones.Informe(cadeteria);
            break;
        default:
            Console.WriteLine("opcion erronea");
            break;
    }
}while(opc!=0);