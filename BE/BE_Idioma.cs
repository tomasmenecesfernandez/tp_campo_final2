using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Idioma
    {
        public int codigo { get; set; }
        public string idioma { get; set; }
        public int digito_verificador{get;set;}
        public BE_Idioma(string idioma1) { idioma = idioma1; }
        public BE_Idioma() { }
        public override string ToString()
        {
            return idioma;
        }
    }
}
