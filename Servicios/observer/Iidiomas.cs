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

        void guardar_observer(BEtraducciones traduccion);
        void notificar(string idioma_actual);
    }
}
