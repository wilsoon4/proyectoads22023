using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_inicial_nav
{
    public partial class MDIbase : Form
    {
        public MDIbase()
        {
            InitializeComponent();
            labels();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Mensaje",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();//Cierra el formulario
        }

        private void integrante1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntegrante1 formIntegrante1 = new frmIntegrante1();
            formIntegrante1.MdiParent = this;
            formIntegrante1.Show();

            
        }

        public void labels()
        {
            Label DavidCarrillo = new Label();
            Label Carnet = new Label();

            DavidCarrillo.Text = "David Alejandro Carrillo de la Roca";
            Carnet.Text = "0901-20-3201";

        }

        private void MDIbase_Load(object sender, EventArgs e)
        {

        }
    }
}
