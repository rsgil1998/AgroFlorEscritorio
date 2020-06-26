using BEUAgroFlor;
using BEUAgroFlor.Transaction;
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
    public partial class frmVariedad : Form
    {
        public frmVariedad()
        {
            InitializeComponent();
        }

        private void frmVariedad_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            lstVariedades.ClearSelection();
            List<variedades> variedade = variedadBLL.List();
            Console.WriteLine(variedade.ToString());
            lstVariedades.DataSource = variedade;
            lstVariedades.Columns[3].Visible = false;
        }
        private void LimpiarPantalla()
        {
            txtNombre.Text = "";
            nudMatas.Value = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                variedades newvaried = new variedades();
                newvaried.nombre = txtNombre.Text;
                newvaried.total_matas = Convert.ToInt32(nudMatas.Value);
                variedadBLL.Create(newvaried);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(" "+ex.Message);
                throw;
            }
            Listar();
            LimpiarPantalla();
        }
    }
}
