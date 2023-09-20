using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_ModeloConsultas
{
    public class Conexion
    {
            //Función: Clase de conexión por medio de ODBC
            public OdbcConnection conexion()
            {
                
                
                OdbcConnection conn = new OdbcConnection("Dsn=consultas_Inteligentes");
                try
                {
                    conn.Open();
                }
                catch (OdbcException)
                {
                    Console.WriteLine("No Conectó");
                }
                return conn;
            }

            
            public void desconexion(OdbcConnection conn)
            {
                try
                {
                    conn.Close();
                }
                catch (OdbcException)
                {
                    Console.WriteLine("No Conectó");
                }
            }
        }
}
