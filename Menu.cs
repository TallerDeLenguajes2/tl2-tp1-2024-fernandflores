
//metodos: obtener datos de cadeteria en cadete y ver info del pedido para cadete
public class Menu
{
    public int MenuDeOpciones()
    {
        int opc;
        do
        {
            Console.WriteLine("\t\t\t------ MENU -------");
            Console.WriteLine("\t\t\t1: alta pedido");
            Console.WriteLine("\t\t\t1: asignar pedido");
            Console.WriteLine("\t\t\t3: cambiar de estado de pedido");
            Console.WriteLine("\t\t\t4: reasignar pedido a otro cadete");
            Console.WriteLine("\t\t\t--seleccione una opcion--");
            if (int.TryParse(Console.ReadLine(), out opc)==false)
            {
                Console.WriteLine("caracter incorrecto");
            }
            else if (opc<1 || opc>4)
            {
                Console.WriteLine("eligio una opcion inexistente, vuelva a intentar");
            }
            
        }while(opc<0 || opc>4);
        return opc;
    }
}