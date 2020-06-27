using AgroFlorEscritorio.Estadistica;
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
    public partial class frmEstadistica : Form
    {
        List<variedades> variedade = variedadBLL.List();
        public frmEstadistica()
        {
            InitializeComponent();
        }
        public void Listar()
        {          
            foreach (var item in variedade)
            {
                cmbVariedad.Items.Add(item.nombre);                
            }            
        }

        private void frmEstadistica_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public variedades BuscarVariedad()
        {
            variedades v=null;
            foreach (var item in variedade)
            {
                if (item.nombre==cmbVariedad.SelectedItem.ToString())
                {
                    v = item;
                }
            }
            lblmatas.Text = v.total_matas.ToString();
            return v;
        }

        private void btnCalcularEst_Click(object sender, EventArgs e)
        {
            EstadisticaVariedad es=CreadorDeEstadisticas.CreadordeEstadisticas();
            float costo=es.costoDeProduccion(BuscarVariedad(),(float)nudPrecioPorMata.Value);
            lblCosto.Text = costo.ToString();
        }
    }
}
