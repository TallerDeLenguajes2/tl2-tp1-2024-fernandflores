public class archivosCvs
{
    public Cadeteria LeerCadeteria(string nombreArchivo) //CREA A PARTIR DEL ARCHIVO JSON.TXT LAS CLASES (DESERIALIZACION)
    {
        var cadeteria= new Cadeteria();
        string ruta= "archivos/"+nombreArchivo;
        using (var archivoOpnen = new FileStream(ruta, FileMode.Open))
        {
            using (var aux= new StreamReader(archivoOpnen))
            {
                string linea=aux.ReadLine(); // salteamos el encabezado
                while ((linea= aux.ReadLine())!=null)
                {
                    var items= linea.Split(',');
                    cadeteria= new Cadeteria(items[0],items[1],LeerCadetes("cadetes.cvs"));
                }
            }
        }
        return cadeteria;
        }
        public List<Cadete> LeerCadetes(string nombreArchivo)
        {
            var cadetes= new List<Cadete>();
            string ruta="archivos/"+nombreArchivo;
            using (var archivoOpnen= new FileStream(ruta, FileMode.Open))
            {
                using (var aux= new StreamReader(archivoOpnen))
                {
                    string linea= aux.ReadLine(); // para saltear los datos del encabezado
                    while((linea=aux.ReadLine())!=null)
                    {
                        var items= linea.Split(',');
                        //var id=int.Parse(items[0].Trim());
                        var id= Convert.ToInt32(items[0]);
                        cadetes.Add(new Cadete(id,items[1],items[2]));
                    }
                }
            }
            return cadetes;
        }

}