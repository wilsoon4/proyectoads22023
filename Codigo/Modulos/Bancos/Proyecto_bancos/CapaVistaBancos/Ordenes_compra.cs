using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Ordenes_compra : Form
    {
        public Ordenes_compra()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string noCuenta = textBox1.Text;
            negocios1.ObtenerSaldo(noCuenta);
            MessageBox.Show("El saldo de la cuenta " + noCuenta + " es " + negocios1.SCuenta);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string noCuenta = textBox1.Text;
            negocios1.ObtenertMoneda1(noCuenta);
            // Aquí puedes utilizar la información de la moneda, por ejemplo, mostrarla en un control.
            // Ejemplo: lbl_Tmoneda.Text = negocios.tMoneda;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string noCuentaO = textBox1.Text;
            string noCuentaD = textBox4.Text;

            // Obtener información de las cuentas de origen y destino
            negocios1.ObtenerSaldo(noCuentaO);
            negocios1.ObtenertMoneda1(noCuentaO);
            negocios1.ObtenerIdBanco(noCuentaO);
            negocios1.tipodecompra1(negocios1.nomBanco);


            lbl_saldo.Text = Convert.ToString(negocios1.saldo);
            lbl_Tmoneda.Text = negocios1.tMoneda;
            lbl_nBancoO.Text = negocios1.bancoN;

            negocios1.ObtenerSaldo(noCuentaD);
            negocios1.ObtenertMoneda1(noCuentaD);
            negocios1.ObtenerIdBanco(noCuentaD);
            negocios1.tipodecompra1(negocios1.nomBanco);

            lbl_SaldoD.Text = Convert.ToString(negocios1.saldo);
            lbl_tMonedaD.Text = negocios1.tMoneda;
            lbl_nBancoD.Text = negocios1.bancoN;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Datos de origen
            string noCuentaO = textBox1.Text;
            negocios1.ObtenerSaldo(noCuentaO);
            negocios1.ObtenertMoneda1(noCuentaO);
            double saldoO = negocios1.saldo;

            // Datos del destino
            string noCuentaD = textBox4.Text;
            negocios1.ObtenerSaldo(noCuentaD);
            negocios1.ObtenertMoneda1(noCuentaD);
            double saldoD = negocios1.saldo;

            // Monto del traspaso
            double traspaso = Convert.ToDouble(txt_traslado.Text);

            // Llamada a la función de traspaso
            negocios1.TraspasoSaldo(noCuentaO, noCuentaD, saldoO, saldoD, traspaso);

            // Actualizar información de saldos y monedas
            negocios1.ObtenerSaldo(noCuentaO);
            negocios1.ObtenertMoneda1(noCuentaO);
            lbl_saldo.Text = Convert.ToString(negocios1.saldo);
            lbl_Tmoneda.Text = negocios1.tMoneda;

            negocios1.ObtenerSaldo(noCuentaD);
            negocios1.ObtenertMoneda1(noCuentaD);
            lbl_SaldoD.Text = Convert.ToString(negocios1.saldo);
            lbl_tMonedaD.Text = negocios1.tMoneda;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
