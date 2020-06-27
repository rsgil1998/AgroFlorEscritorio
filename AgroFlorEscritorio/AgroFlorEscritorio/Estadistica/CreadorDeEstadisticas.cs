using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFlorEscritorio.Estadistica
{
    public class CreadorDeEstadisticas
    {
        public static EstadisticaVariedad CreadordeEstadisticas()
        {
            return new VariedadEsta();
        }
    }
}
