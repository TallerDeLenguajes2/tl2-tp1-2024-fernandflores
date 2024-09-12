

    public class Funciones
    {
        
        public static int TotalPedidosEntregados(List<Pedido> ListaPedidos)
        {
            var listaAux= ListaPedidos.Where(p=>p.Estado=="entregado").ToList();
            return listaAux.Count;
        }
        public static int TotalSueldos(List<Pedido> ListaPedidos)
        {
            var listaAux= ListaPedidos.Where(p=>p.Estado=="entregado").ToList();
            return listaAux.Count*500;
        }
        public static int EntregadosPorCadete(int id, List<Pedido>ListaPedidos)
        {
        var listaPedidosAux= ListaPedidos.Where(c=>c.Cadete.Id==id && c.Estado=="entregado").ToList();
        return listaPedidosAux.Count;
        }
        public static int SueldoPorCadete(int id, List<Pedido>ListaPedidos)
        {
            var listaPedidosAux= ListaPedidos.Where(c=>c.Estado=="entregado" && c.Cadete.Id==id && c.Cadete!=null).ToList();
            return listaPedidosAux.Count*500;
        }
        public static void Informe(Cadeteria cadeteria)
        {
            int monto, cantidad;
            var listaAux= cadeteria.ListaPedidos.Where(p=>p.Cadete!=null).ToList();
            foreach (var cadete in cadeteria.ListaCadetes)
            {
                cantidad= EntregadosPorCadete(cadete.Id, listaAux);
                monto= SueldoPorCadete(cadete.Id, listaAux);
                Console.WriteLine("\n----------------------");
                Console.WriteLine("cadete: "+cadete.Nombre);
                Console.WriteLine("cantidad de pedidos entregados: "+ cantidad);
                Console.WriteLine("ganancias del cadete: "+monto);
            }        
            Console.WriteLine("total de pedidos entregados: "+ TotalPedidosEntregados(cadeteria.ListaPedidos));
            Console.WriteLine("total de ganancias de los cadetes: "+TotalSueldos(cadeteria.ListaPedidos));
        }
    }
