using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using BE;
namespace Servicios.observer
{
   public interface Iidiomas
    {

        void guardar_observer(Iobservertraduccion observer);
        void notificar_a_todos(string idioma_actual);
    }
}
