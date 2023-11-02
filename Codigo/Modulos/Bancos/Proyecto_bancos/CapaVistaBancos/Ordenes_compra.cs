using System;
using System.Windows.Forms;
<<<<<<< HEAD
using CapaControladorBancos;
=======

>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c
namespace CapaVistaBancos
{
    public partial class Ordenes_compra : Form
    {
        public Ordenes_compra()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void label1_Click(object sender, EventArgs e)
        {

=======
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
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

            string noCuenta = textBox1.Text;
            negocios.ObtenerSaldo(noCuenta);
            MessageBox.Show("El saldo de la cuenta " + noCuenta + " es " + negocios.SCuenta);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nCuenta = textBox1.Text;
            negocios.ObtenertMoneda(nCuenta);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // string nBancoO;
            string noCuentaO = textBox1.Text;
            //nBancoO = Convert.ToString(oBancoCB.SelectedItem.ToString());
            //negocios.ObtenerID(nBancoO);

            negocios.ObtenerSaldo(noCuentaO);
            negocios.ObtenertMoneda(noCuentaO);
            negocios.ObtenerIdBanco(noCuentaO);
            negocios.ObtenerID(negocios.nomBanco);

            lbl_saldo.Text = Convert.ToString(negocios.saldo);
            lbl_Tmoneda.Text = negocios.tMoneda;
            lbl_nBancoO.Text = negocios.bancoN;
            string noCuentaD = textBox4.Text;
            //string nBancoD;

            //nBancoD = Convert.ToString(dBancoCB.SelectedItem.ToString());
            //negocios.ObtenerID(nBancoD);
            negocios.ObtenerSaldo(noCuentaD);
            negocios.ObtenertMoneda(noCuentaD);
            negocios.ObtenerIdBanco(noCuentaD);
            negocios.ObtenerID(negocios.nomBanco);

            lbl_SaldoD.Text = Convert.ToString(negocios.saldo);
            lbl_tMonedaD.Text = negocios.tMoneda;
            lbl_nBancoD.Text = negocios.bancoN;



        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        public void Habilitador_timer()
        {
            timer1.Interval = 50400000;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ControladorBanco.actualizacion_saldos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            negocios.ObtenerValorM("Dolares"); //Prueba de funcion Obtener ValorM   AUN NO FUNCIONAL
            MessageBox.Show("Valor: " + negocios.VMoneda); //Muestra valor moneda AUN NO FUNCIONAL

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_traslado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //Datos de origen/////////////////////////////////////////////////

            string noCuentaO = textBox1.Text;
            negocios.ObtenerSaldo(noCuentaO);
            negocios.ObtenertMoneda(noCuentaO);
            double saldoO = negocios.saldo;

            //Datos del destino////////////////////////////////////////////////
            string noCuentaD = textBox4.Text;
            negocios.ObtenerSaldo(noCuentaD);
            negocios.ObtenertMoneda(noCuentaD);
            double saldoD = negocios.saldo;

            //Monto del traslado///////////////////////////////////////
            double tras = Convert.ToDouble(txt_traslado.Text);

            // LLamada a negocios ////////////////////////////////////
            negocios.TraspasoSaldo(noCuentaO, noCuentaD, saldoO, saldoD, tras);
            //Carga de labels;

            negocios.ObtenerSaldo(noCuentaO);
            negocios.ObtenertMoneda(noCuentaO);

            lbl_saldo.Text = Convert.ToString(negocios.saldo);
            lbl_Tmoneda.Text = negocios.tMoneda;

            // string noCuentaD = textBox4.Text;
            //string nBancoD;

            //nBancoD = Convert.ToString(dBancoCB.SelectedItem.ToString());
            //negocios.ObtenerID(nBancoD);
            negocios.ObtenerSaldo(noCuentaD);
            negocios.ObtenertMoneda(noCuentaD);
            lbl_SaldoD.Text = Convert.ToString(negocios.saldo);
            lbl_tMonedaD.Text = negocios.tMoneda;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            lbl_SaldoD.Text = "";
            lbl_tMonedaD.Text = "";
            lbl_nBancoD.Text = "";
            lbl_saldo.Text = "";
            lbl_Tmoneda.Text = "";
            lbl_nBancoO.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
        }
=======
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c
    }
}
