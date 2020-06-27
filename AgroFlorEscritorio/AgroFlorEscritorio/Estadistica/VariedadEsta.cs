using BEUAgroFlor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFlorEscritorio.Estadistica
{
    public class VariedadEsta : EstadisticaVariedad
    {
        public override float costoDeProduccion(variedades v,float precioMata)
        {
            
           return v.total_matas * precioMata;
        }

        public override float productividad()
        {
            throw new NotImplementedException();
        }
    }
}
