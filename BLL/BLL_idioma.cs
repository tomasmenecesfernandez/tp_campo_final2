using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;
using Servicios;
namespace BLL
{
    public class BLL_idioma
    {
        public DALidioma DAL_idioma = new DALidioma();
        public void agregar_idioma(BE_Idioma idioma)
        {
            DAL_idioma.agregar_idioma(idioma.idioma, CalcularDigitoVerificadorDesdeTexto(idioma.idioma));
        }
        public void borrar_idioma(int cod_idioma)
        {
            DAL_idioma.borrar_idioma(cod_idioma);
        }
        public static int CalcularDigitoVerificadorDesdeTexto(string texto)
        {
            texto = encryptacion.Hash(texto);
            int suma = 0;
            int v = 0;
            foreach (char c in texto)
            {
                v++;
                suma += c * v;
            }
            suma = suma % 197317;
            return suma;
        }
        public List<BE_Idioma> leer_idiomas()
        {
            List<BE_Idioma> lista = DAL_idioma.leer_idiomas();
            foreach (BE_Idioma idioma in lista)
            {
                if (CalcularDigitoVerificadorDesdeTexto(idioma.idioma) != idioma.digito_verificador) throw new Exception($"error en codigo verificador en el idioma { idioma.idioma }.");
            }
            return lista;
        }
       
    }
    
}
