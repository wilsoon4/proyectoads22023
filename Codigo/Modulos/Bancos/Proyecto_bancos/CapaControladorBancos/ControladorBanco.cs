using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaModeloBancos;
using System.Data.Odbc;


namespace CapaControladorBancos
{
    public class ControladorBanco
    {
        private SentenciasBanco sentencias ;

        public ControladorBanco()
        {
            sentencias = new SentenciasBanco();
           
        }
        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento, string numCuenta, string tipoTransaccion, string estado)
        {
            sentencias.InsertarMovimiento(valorMovimiento, descripcionMovimiento, numCuenta, tipoTransaccion, estado);
        }
        public DataTable llenarTbl(string tabla)
        {
            return sentencias.llenarTbl(tabla);
        }

        public class Controlador
        {
            string no_form = "5004";
        public static OdbcConnection ObtenerConexion()
        {
            // Cadena de conexión ODBC
            string connectionString = "DSN=hotelfase";

            OdbcConnection conectar = new OdbcConnection(connectionString);

            conectar.Open(); // Abriendo la conexión
            return conectar; // Regresa la conexión
        }

        public static DataTable ObtenerIdBanco(string Banco)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT nombre FROM banco WHERE idBanco = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comandoB = new OdbcCommand(consulta, connection))
            {
                comandoB.Parameters.AddWithValue("Banco", Banco); // Agrega los parámetros a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comandoB); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static DataTable idmoncu(string noCuenta)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT idBanco FROM cuentabanco WHERE noCuenta = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("noCuenta", noCuenta); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static DataTable ObtenerSaldo(string noCuenta)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT saldoDisponible FROM cuentabanco, banco WHERE cuentabanco.noCuenta = ? AND banco.idBanco = cuentabanco.idBanco;"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("noCuenta", noCuenta); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static DataTable ObtenertMoneda(string noCuenta)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT tipoMoneda FROM cuentabanco, banco WHERE cuentabanco.noCuenta = ? AND banco.idBanco = cuentabanco.idBanco;"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("noCuenta", noCuenta); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static DataTable ValorM(string moneda)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT valor FROM moneda WHERE moneda.moneda = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("nombre", moneda); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static void trasladoS(string noCuenta, double saldo)
        {
            string updateQuery = "UPDATE cuentabanco SET saldoDisponible = ? WHERE cuentabanco.noCuenta = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(updateQuery, connection))
            {
                comando.Parameters.AddWithValue("saldo", saldo); // Parámetros que se agregan a la consulta
                comando.Parameters.AddWithValue("noCuenta", noCuenta); // Parámetros que se agregan a la consulta
                comando.ExecuteNonQuery(); // Ejecución del query para realizar la actualización
            }
        }

        public static void actualizacion_saldos()
        {
            string updateQuery = "UPDATE cuentabanco SET saldoActual = saldoDisponible;"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(updateQuery, connection))
            {
                comando.ExecuteNonQuery(); // Ejecución del query para realizar la actualización
            }
        }
    }
}
}
