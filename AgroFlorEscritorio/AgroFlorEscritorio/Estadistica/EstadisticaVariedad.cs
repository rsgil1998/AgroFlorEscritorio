using BEUAgroFlor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFlorEscritorio.Estadistica
{
    public abstract class EstadisticaVariedad
    {
        public abstract float productividad();
        public abstract float costoDeProduccion(variedades v,float precioMata);
    }
}
