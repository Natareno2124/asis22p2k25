using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_Seguridad;
using Capa_Vista_Navegador;

namespace CapaVista_Menu
{
    public partial class MenuGeneral : Form
    {

        public MenuGeneral()
        {
            InitializeComponent();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Mensaje",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();//Cierra el formulario
        }

        private void consultaBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista_Seguridad.frmBitacora bitacora = new CapaVista_Seguridad.frmBitacora();
            bitacora.ShowDialog();
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_1 frm = new Mant_1();
            frm.Show();
        }


        private void identificacionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Identificacion frm = new Identificacion();
            frm.Show();
        }
    }
}
