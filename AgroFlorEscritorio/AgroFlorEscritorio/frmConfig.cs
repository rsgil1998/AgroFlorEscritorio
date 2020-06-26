using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroFlorEscritorio
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }
        private void frmConfig_Load(object sender, EventArgs e)
        {
            ConfigSingleton conf = ConfigSingleton.GetConfig();
            lblMedidas.Text = conf.medidas;
            lblTallosbonche.Text = conf.tallosBonche.ToString();
        }
    }
}
