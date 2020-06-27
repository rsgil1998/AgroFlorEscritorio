using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroFlorEscritorio
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        
        public void ClonarGb()
        {
           NumericUpDown a = nudTotalTallos;
            
        }
        private void Clonar(object src, object tgt)
        {
            PropertyInfo[] props = src.GetType().GetProperties();
            foreach (PropertyInfo pi in props)
            {
                if (pi.CanWrite)
                    pi.SetValue(tgt, pi.GetValue(src, null), null);
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {           
            
            
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            //gbRegistro.Visible = false
        }
    }
}
