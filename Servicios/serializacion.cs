using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Servicios
{
    public class serializacion
    {
        static string rutaArchivo = @"C:\Users\user\Desktop\universidad\introducion a la programacion\3 año\wwwww\trabajo practico\bitacora.json";
        public static void serializar(object objeto)
        {
            string json = JsonConvert.SerializeObject(objeto);
            using (StreamWriter sw = new StreamWriter(rutaArchivo, append: true))
            {
                sw.WriteLine(json);
            }
        }
        public static List<T> LeerObjetos<T>()
        {
            List<T> lista = new List<T>();

            if (!File.Exists(rutaArchivo))
                return lista;

            foreach (string linea in File.ReadLines(rutaArchivo))
            {
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    T obj = JsonConvert.DeserializeObject<T>(linea);
                    lista.Add(obj);
                }
            }

            return lista;
        }
    }
}
