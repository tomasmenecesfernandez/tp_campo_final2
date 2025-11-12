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

         string idioma{get;set;}

        public idiomas() { }
        public idiomas(string idioma1) { idioma = idioma1; }
        DALidioma DALidioma = new DALidioma();
        static acceso acceso = new acceso();
        public static List<Iobservertraduccion> lista_observer = new List<Iobservertraduccion>();

        public string Idioma
        {
            get { return idioma; }
            set
            {
                idioma = value;
                notificar_a_todos(value);
            }
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
        public void borrar_idioma(int cod_idioma)
        {
            DALidioma.borrar_idioma(cod_idioma);
        }
        public static int CalcularDigitoVerificadorDesdeTexto(string texto)
        {
            int suma = 0;
            int v = 0;
            foreach (char c in texto)
            {
                v += 1;
                suma += (int)c*c * 17 + c/v ;
            }
            suma=suma % 197317;
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
                else {throw new Exception($"error en codigo verificador en el idioma { idioma.idioma }."); }
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
                throw new Exception("el observer ya esta en la lista");
            }
        }
        public void eliminar_observer(Iobservertraduccion observer)
        {
            if (lista_observer.Contains(observer))
            {
                lista_observer.Remove(observer);
            }
            else
            {
                throw new Exception("el observer no esta en la lista");
            }
        }
        public override string ToString()
        {
            return idioma;
        }

    }
}
