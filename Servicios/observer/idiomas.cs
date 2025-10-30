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
        
        string idioma;
        public string Idioma {
            get { return idioma; }
            set {
                this.idioma = value;
                this.notificar(this.idioma); }
        }
        public idiomas(string idiom)
        {
            Idioma = idiom;
        }
        public idiomas() { }
        DALidioma DALidioma = new DALidioma();
        DALtraducciones daltraducciones = new DALtraducciones();
         acceso acceso = new acceso();
        public static List<BEtraducciones> lista_traducciones = new List<BEtraducciones>();

        public void guardar_observer(BEtraducciones traduccion)
        {
            if (!lista_traducciones.Contains(traduccion))
            {
                lista_traducciones.Add(traduccion);
            }
            else
            {
                throw new Exception("ya la traduccion esta en el sistema");
            }
        }
        public void cargar_listatraducciones(string idioma_actual)
        {
            lista_traducciones.Clear();
            lista_traducciones=daltraducciones.leer_traducciones(idioma_actual);
        }
        public void notificar(string idioma_actual)
        {
            cargar_listatraducciones(idioma_actual);
        }

        public void quitar_observer(BEtraducciones traduccion)
        {
            if (lista_traducciones.Contains(traduccion))
            {
                lista_traducciones.Remove(traduccion);
            }
            else
            {
                throw new Exception("la traduccion no estaba en el sistema.");
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
        public  List<idiomas> leer_idiomas()
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
    }
}
