using BEUAgroFlor;
using BEUAgroFlor.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFlorEscritorio
{
    public class ConfigSingleton
    {
        private static ConfigSingleton configu;
        public string medidas { get; set; }
        public int tallosBonche { get; set; }

        private ConfigSingleton()
        {
            this.medidas = ObtenerMedidas();
            this.tallosBonche = 25;
        }
        private static void CrearConfiguracion()
        {
            if (configu==null)
            {
                configu = new ConfigSingleton();
            }
        }
        public static ConfigSingleton GetConfig()
        {
            if (configu==null)
            {
                CrearConfiguracion();
            }
            return configu;
        }

        public string ObtenerMedidas()
        {
            config c = configBLL.Get(4);         
            return c.medidas;
        }
        public int ObtenerTallosBonche()
        {
            config c = configBLL.Get(4);
            return c.tallos_bonche;
        }
    }
}
