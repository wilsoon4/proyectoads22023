using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaModeloBancos;
using System.Data.Odbc;
<<<<<<< HEAD


=======
using System.Data;
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c
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

<<<<<<< HEAD
        public class Controlador
        {
            string no_form = "5004";
        public static OdbcConnection ObtenerConexion()
        {
            // Cadena de conexión ODBC
            string connectionString = "DSN=hotelfase";

            OdbcConnection conectar = new OdbcConnection(connectionString);
=======
        

        public static OdbcConnection ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("DSN=base"); // Reemplaza "nombreDSN" con tus propios valores.
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c

            conectar.Open(); // Abriendo la conexión
            return conectar; // Regresa la conexión
        }

<<<<<<< HEAD
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
=======
        public static DataTable Tipodecompras(string tipocompra)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT cdes_tipo_de_compra FROM tbl_cuentadestino WHERE cdes_id_proveedor = ?";

            OdbcCommand comando = new OdbcCommand(consulta, ObtenerConexion());
            comando.Parameters.AddWithValue("?", tipocompra);

            OdbcDataAdapter adapter = new OdbcDataAdapter(comando);
            adapter.Fill(dt);
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c

            return dt;
        }

<<<<<<< HEAD
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
=======
        public static DataTable idcuentaban(String tipoCompra)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT cdes_tipo_de_compra FROM tbl_cuentadestino WHERE cdes_id_proveedor = ?";

            OdbcCommand comando = new OdbcCommand(consulta, ObtenerConexion());
            comando.Parameters.AddWithValue("?", tipoCompra);

            OdbcDataAdapter adapter = new OdbcDataAdapter(comando);
            adapter.Fill(dt);
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c

            return dt;
        }

<<<<<<< HEAD
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
=======
        public static DataTable ObtenerSaldo(String noCuenta)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT cori_monto FROM tbl_cuentaorigen WHERE cori_id_numcuenta = ?";

            OdbcCommand comando = new OdbcCommand(consulta, ObtenerConexion());
            comando.Parameters.AddWithValue("?", noCuenta);

            OdbcDataAdapter adap = new OdbcDataAdapter(comando);
            adap.Fill(dt);
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c

            return dt;
        }

<<<<<<< HEAD
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
=======
        public static DataTable ObtenertMoneda1(String noCuenta)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT fk_cori_tipo_de_moneda FROM tbl_cuentaorigen WHERE cori_id_numcuenta = ?";

            OdbcCommand comando = new OdbcCommand(consulta, ObtenerConexion());
            comando.Parameters.AddWithValue("?", noCuenta);

            OdbcDataAdapter adap = new OdbcDataAdapter(comando);
            adap.Fill(dt);
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c

            return dt;
        }

        public static DataTable ValorM(string moneda)
        {
            DataTable dt = new DataTable();

<<<<<<< HEAD
            string consulta = "SELECT valor FROM moneda WHERE moneda.moneda = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("nombre", moneda); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }
=======
            string consulta = "SELECT cdes_valor_de_compra FROM tbl_cuentadestino WHERE cdes_tipo_de_compra = ?";

            OdbcCommand comando = new OdbcCommand(consulta, ObtenerConexion());
            comando.Parameters.AddWithValue("?", moneda);

            OdbcDataAdapter adap = new OdbcDataAdapter(comando);
            adap.Fill(dt);
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c

            return dt;
        }

<<<<<<< HEAD
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
=======
        public static void trasladoS(String noCuenta, double saldo)
        {
            string update = "UPDATE tbl_cuentaorigen SET cori_monto = ? WHERE cori_id_numcuenta = ?"; // Consulta
            OdbcCommand comando = new OdbcCommand(update, ObtenerConexion());
            comando.Parameters.AddWithValue("?", saldo);
            comando.Parameters.AddWithValue("?", noCuenta);
            comando.ExecuteNonQuery();
>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c
        }

        public static void actualizacion_saldos()
        {
<<<<<<< HEAD
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
=======
            string actu = "UPDATE tbl_cuentadestino SET cdes_valor_de_compra = cdes_valor_de_compra - 1;"; // Consulta de ejemplo
            OdbcCommand comando = new OdbcCommand(actu, ObtenerConexion());
            comando.ExecuteNonQuery();
            
        }
        }
    }
    


>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c
