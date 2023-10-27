using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControladorBancos;

namespace CapaVistaBancos
{
   public class negocios
    {

        public static string noCuenta1;
        public static string noCuenta2;
        public static string tMoneda;
        public static string bancoN;
        public static string banconom;
        public static string nomBanco;
        public static double saldo;
        public static string SCuenta;
        public static double VMoneda;
        string no_form = "5004";

        public static void tipodecompra1(string tipodecompra)
        {
            string ban;
            DataTable dts = ControladorBanco.Tipodecompras(tipodecompra);
            if (dts.Rows.Count > 0)
            {
                DataRow row = dts.Rows[0];
                ban = Convert.ToString(row["cori_tipo_de_compra"]);
                negocios.bancoN = ban;
            }
        }

        public static void ObtenerIdBanco(String noCuenta)
        {
            string nombreBanco;
            DataTable dtS = ControladorBanco.ObtenertMoneda1(noCuenta);
            if (dtS.Rows.Count > 0)
            {
                DataRow row = dtS.Rows[0];
                nombreBanco = Convert.ToString(row["fk_cori_tipo_de_moneda"]);
                negocios.nomBanco = nombreBanco;
            }
        }

        public static void ObtenerSaldo(String noCuen)
        {
            string saldoCuenta;
            DataTable dtS = ControladorBanco.ObtenerSaldo(noCuen);
            if (dtS.Rows.Count > 0)
            {
                DataRow row = dtS.Rows[0];
                saldoCuenta = Convert.ToString(row["cori_monto"]);
                saldo = Convert.ToDouble(saldoCuenta);
            }
        }

        public static void ObtenertMoneda1(String noCuen)
        {
            DataTable dtS = Controladorbanco.ObtenertMoneda1(noCuen);
            if (dtS.Rows.Count > 0)
            {
                DataRow row = dtS.Rows[0];
                negocios.tMoneda = Convert.ToString(row["fk_cori_tipo_de_moneda"]);
            }
        }

        public static void ObtenerBancoCuenta(String noCuen)
        {
            DataTable dtS = ControladorBanco.ObtenertMoneda1(noCuen);
            if (dtS.Rows.Count > 0)
            {
                DataRow row = dtS.Rows[0];
                negocios.banconom = Convert.ToString(row["fk_cori_tipo_de_moneda"]);
            }
        }

        public static void ObtenerValorM(string moneda)
        {
            string valorMoneda;
            DataTable dtS = ControladorBanco.ValorM(moneda);
            if (dtS.Rows.Count > 0)
            {
                DataRow row = dtS.Rows[0];
                valorMoneda = Convert.ToString(row["cdes_valor_de_compra"]);
                VMoneda = Convert.ToDouble(valorMoneda);
            }
        }

        public static void TraspasoSaldo(String noCuenO, String noCuenD, double saldoO, double saldoD, double traslado)
        {
            double NuevoSaldoO;
            double NuevoSaldoD;
            string tmonedaO, tmonedaD;
            negocios.ObtenertMoneda1(noCuenO);
            tmonedaO = negocios.tMoneda;
            negocios.ObtenertMoneda1(noCuenD);
            tmonedaD = negocios.tMoneda;

            if (saldoO < traslado)
            {
                MessageBox.Show("El saldo de la cuenta " + noCuenO + " es menor a la transacción, COMPRA NO AUTORIZADA");
            }
            else
            {
                if (tmonedaO == tmonedaD)
                {
                    NuevoSaldoO = saldoO - traslado;
                    ControladorBanco.trasladoS(noCuenO, NuevoSaldoO);

                    NuevoSaldoD = saldoD + traslado;
                    ControladorBanco.trasladoS(noCuenD, NuevoSaldoD);

                    MessageBox.Show("COMPRA AUTORIZADA");
                }
                else if ((tmonedaO == "Quetzales" || tmonedaO == "quetzales") && (tmonedaD == "Dolares" || tmonedaD == "dolares"))
                {
                    MessageBox.Show("La cuenta de origen está en quetzales, se realizará la conversión a dólares");
                    double valor, conver;
                    negocios.ObtenerValorM(tmonedaD);
                    valor = 7.34;
                    conver = traslado * valor;
                    if (saldoO < conver)
                    {
                        MessageBox.Show("El saldo de la cuenta " + noCuenO + " es menor a la transacción, COMPRA NO AUTORIZ");
                    }
                }
            }
        }
    }
}

