using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;

namespace Servicios.observer
{
    public class idiomas : Iidiomas
    {
        public int codigo { get; set; }
        public int digito_varificador { get; set; }

         string idioma{get;set;}
        public static List<Iobservertraduccion> lista_observer = new List<Iobservertraduccion>();

        public idiomas() { }
        public idiomas(string idioma1) { idioma = idioma1; }

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
