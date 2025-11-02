using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;

namespace Servicios.observer
{
    public class idiomas : Iidiomas
    {
        public int codigo { get; set; }
        public int digito_varificador { get; set; }

        public string idioma{get;set;}

        public idiomas() { }
        DALidioma DALidioma = new DALidioma();
        DALtraducciones daltraducciones = new DALtraducciones();
        static acceso acceso = new acceso();
        public static List<Iobservertraduccion> lista_observer = new List<Iobservertraduccion>();

        public idiomas(string idiom)
        {
            idioma = idiom;
        }

        public void notificar_a_todos(string idioma_actual)
        {
            foreach (var observer in lista_observer)
            {
                observer.actualizar_idioma();
            }
        }
        public void agregar_idioma(idiomas idioma)
        {
            DALidioma.agregar_idioma(idioma.idioma,CalcularDigitoVerificadorDesdeTexto(idioma.idioma));
        }
        public static int CalcularDigitoVerificadorDesdeTexto(string texto)
        {
            int suma = 0;
            int v = 0;
            foreach (char c in texto)
            {
                suma += (int)c * v;
                v+=2;
            }

            return suma;
        }
        public static List<idiomas> leer_idiomas()
        {
                string comando = "leer_idiomas";
                DataTable tabla = acceso.leer_tabla(comando, null);
                List<idiomas> lista = new List<idiomas>();
                foreach (DataRow fila in tabla.Rows)
                {
                    idiomas idioma = new idiomas(fila["Nombre"].ToString());
                    idioma.codigo = (int)fila["codigo"];
                    if (CalcularDigitoVerificadorDesdeTexto(idioma.idioma) == (int)fila["digito_verificador"])
                    {
                        idioma.digito_varificador = (int)fila["digito_verificador"];
                        lista.Add(idioma);
                }
                else { throw new Exception($"error en codigo verificador en el idioma { idioma.idioma }."); }
                }
            
            return lista;
        }
        public void guardar_observer(Iobservertraduccion observer)
        {
            if (!lista_observer.Contains(observer))
            {
                lista_observer.Add(observer);
            }
            else
            {
                throw new Exception("ya la traduccion esta en el sistema");
            }
        }
        public override string ToString()
        {
            return idioma;
        }

    }
}
