using Microsoft.VisualBasic;
// var listadoDePedidos1= new List<Pedidos>();
// listadoDePedidos1.Add(new Pedidos(01,"sandwich", "cliente 1", "fer nan do", "bolivar 440 1D","3884090990","edificio de 11 pisos"));
// listadoDePedidos1.Add(new Pedidos(02,"jugo", "cliente 2", "hola mundo", "iturbe 422","3884090990","jujuy"));

// var listadoDePedidos2= new List<Pedidos>();
// listadoDePedidos2.Add(new Pedidos(03,"bondiola", "cliente 3", "chau mundo", "bolivar 440 1D","3884090990","edificio de 11 pisos"));
// listadoDePedidos2.Add(new Pedidos(04,"citric naranja mango", "cliente 4", "bienvenido mundo", "iturbe 422","3884090990","jujuy"));

// var cadetes= new List<Cadete>();
// cadetes.Add(new Cadete(1,"repartidor 1","3884090990",listadoDePedidos1));
// cadetes.Add(new Cadete(2, "repartidor 2","911", listadoDePedidos2));

// var cadeteria= new Cadeteria("pedidos ya", "3884848052",cadetes);
var archivo= new archivosCvs();
var cadeteria= new Cadeteria();
var listadePedidos= new List<Pedido>();
listadePedidos.Add(new Pedido(1,"sandiwch de milanesa", "cliente 1", "fernando flores", "bolivar 440 1D", "3884090990", "edificio"));
cadeteria=archivo.LeerCadeteria("cadeteria.cvs");
cadeteria.listaCadetes[0].listaPedidos= listadePedidos;
cadeteria.listaCadetes[0].listaPedidos[0].VerDireccionCliente();
cadeteria.listaCadetes[0].listaPedidos[0].VerDatosClientes();
Console.WriteLine("hola mundo"); 

