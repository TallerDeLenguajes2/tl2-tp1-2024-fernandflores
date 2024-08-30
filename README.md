# RESPUESTAS A LAS PREGUNTAS DEL TP

## relaciones por agregacion:
- pedidos con cadetes: si el cadete no existe el pedido sigue estando
- cadete con cadeteria: si la cadeteria no existe, el cadete sigue existiendo

## relacion por composicion:

- cliente con pedido: si el pedido ya no existe, no es relevante tener la informacion del cliente

## metodos a agregar en cadete:

- deberia tener un metodo para poder ver el listado de pedidos total y uno con un filtro para los entregados y no entregados, el metodo con filtro de estados pendientes deberia contar con la posibilidad de ver la direccion del cliente, de este modo el cadete podra ver que puede llevar y a donde, usando esta informacion para su conveniencia

## metodos a agregar en cadeteria 

- un metodo que diga el monto total a pagar a los cadetes 

## metodo de ocultamiento

deberian ser publicos:
- estado en pedidos
- obs en pedidos
- nombre en cadete 
- telefono en cadete
- nombre en cadeteria
- telefono en cadeteria
- listado de cadetes en cadeteria
- lista de pedidos en cadete - lista de pedidos en cadete 
nota_  todas solo con get para mostrar el dato contenido desde cualquier parte del codigo, ya que no haria falta modificar cosas como nombre o telefono, a excepcion de "estado" en pedido ya que eso si seria necesario cambiarlo luego

deberian ser privados:
- todos atributos de cliente
- nro en pedidos
- cliente en pedidos
- id en cadete 
- drireccion en cadete 


## contructores para cliente:

- el constructor de cliente estara con todos sus atributos los cuales se instanciaran en el constructor de pedidos ya que la conexion entre estos es por composicion
- el constructor de pedidos tendra sus atributos y los de la clase cliente ya que en este se instancia cliente, este constructor sera invocado desde fuera de la clase de cadete, ya que la conexion entre estos es de agregacion (los pedidos existiran independientemente del que cadete exista o no)
- el constructor cadete tendra sus atributos menos la lista de pedidos, ya que como dijimos, la existencia de la lista de pedidos es independiente del cadete 
- el constructor de cadeteria estara completo con todos sus atributos 
 
## otro diseño

- podriamos haber cambiado la conexion del cadete->pedido a cadete->cliente. De esta forma podriamos hacer que el cadete elija un cliente en base a otros parametros (por ejemplo una lista de pedidos o direccion) y hacer que cada cliente pueda tener una lista limitada de pedidos (un carrito)