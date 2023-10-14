using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Menu_inicial : Form
    {
        public Menu_inicial()
        {
            InitializeComponent();
        }

        private void disponibilidadYTipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispo_tcambio ndispo = new Dispo_tcambio();
            ndispo.MdiParent = this;
            ndispo.Show();
        }

        private void movimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void conciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_bancaria ncon = new Con_bancaria();
            ncon.MdiParent = this;
            ncon.Show();
        }

        private void autorizaciónDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordenes_compra nordenes = new Ordenes_compra();
            nordenes.MdiParent = this;
            nordenes.Show();
        }

        private void Menu_inicial_Load(object sender, EventArgs e)
        {

        }

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_agregar_cuenta ncuenta = new Mantenimiento_agregar_cuenta();
            ncuenta.MdiParent = this;
            ncuenta.Show();
        }

        private void agregarTipoDeMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_tipoMov ntipo = new Mantenimiento_tipoMov();
            ntipo.MdiParent = this;
            ntipo.Show();
        }

        private void ingresarTransaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mov_bancarios nmov = new Mov_bancarios();
            nmov.MdiParent = this;
            nmov.Show();
        }

        private void agregarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
