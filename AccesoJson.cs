using System.Text.Json;

public class AccesoJson: iAccesosDatos
{
    public Cadeteria LeerCadeteria(string nombreArchivo, List<Pedido> pedidos)
    {
        string cadenaCadeteria;
        string ruta="archivos/"+nombreArchivo;
        using (var archivoOpnen= new FileStream(ruta, FileMode.Open))
        {
            using (var aux = new StreamReader(archivoOpnen))
            {
                cadenaCadeteria=aux.ReadToEnd();
                archivoOpnen.Close();
            }
        }
        var cadeteriaAux= JsonSerializer.Deserialize<Cadeteria>(cadenaCadeteria);
        var cadeteria= new Cadeteria(cadeteriaAux.Nombre, cadeteriaAux.Telefono, LeerCadetes("cadetes.json"),pedidos);
        return cadeteria;
    }
    public List<Cadete> LeerCadetes(string nombreArchivo)
    {
        string cadenaCadetes;
        string ruta= "archivos/"+nombreArchivo;
        using (var archivoOpnen = new FileStream(ruta, FileMode.Open))
        {
            using (var aux = new StreamReader(archivoOpnen))
            {
                cadenaCadetes=aux.ReadToEnd();
                archivoOpnen.Close();
            }
        }
        var cadetes=JsonSerializer.Deserialize<List<Cadete>>(cadenaCadetes);
        return cadetes;
    }
}