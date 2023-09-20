﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_ModeloConsultas;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;


namespace Capa_ControladorConsultas 
{
    public class csControldor
    {
        Sentencias sn = new Sentencias();


        public DataTable llenartb2()
        {
            string consulta = "select * from tbl_consultainteligente";
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void CargarTablas(ComboBox comboBox1, string BD)
        {
            OdbcDataAdapter dt = sn.buscartbl(BD);
            DataTable table = new DataTable();
            dt.Fill(table);
            int contador = 0;
            comboBox1.Items.Clear();
            foreach (DataRow Row in table.Rows) { 
                comboBox1.Items.Add(table.Rows[contador][0].ToString());
                contador++;
            }
        }
        public DataTable llenartb3(string condicion)
        {
            string consulta = "select * from tbl_consultainteligente where nombre_consulta= " + '"' + condicion + '"';
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

   
        public void ejecutarconsulta(string condicion)
        {
            string sql = "DELETE FROM tbl_consultainteligente where nombre_consulta = " + '"' + condicion + '"' + ";";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void editarconsulta(string nombre_consulta, string tabla_consulta, string campos_consulta, string alias_consulta)
        {
            string sql = "update" +
                " tbl_consultainteligente set tabla ='" + tabla_consulta + "'" + "'campos ='"+ campos_consulta + "'alias ='" + alias_consulta + "where nombre = '" + nombre_consulta + "'";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
        

        public void editarconsulta1(string operador_consulta, string campos_consultas, string valor_consultas, string PkId)
        {
            string sql = "update" +
                " tbl_consultainteligente1 set operador ='" + operador_consulta + "'" + "'campos ='" + campos_consultas + "'valor ='" + valor_consultas + "where id = '" + PkId + "'";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
 
        public void editarconsulta2(string ordernar_consulta, string campo_consulta)
        {
            string sql = "update" +
                " tbl_consultainteligente2 set ordernar ='" + ordernar_consulta + "'" + "'campos ='" + campo_consulta;           
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void editarconsulta3(string campoeditar_consulta, string valoreditar_consulta)
        {
            string sql = "update" +
                " tbl_consultainteligente3 set campo ='" + campoeditar_consulta + "'" + "'valor ='" + valoreditar_consulta; 
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public DataTable BuscarPor(string datobuscar, string buscaren, string tableN, DataTable dt, Label lbl_cadena)
        {
            OdbcConnection con = new OdbcConnection("Dsn=consultas_Inteligentes");
            if (string.IsNullOrEmpty(datobuscar))
            {
                String textalert = " El campo buscar, se encuentra vacio ";
                MessageBox.Show(textalert);
            }
            else
            {
                try
                {

                    String cadenaB = "";
                    con.Open();
                    cadenaB = " SELECT * FROM " + tableN + " WHERE " + buscaren + " LIKE ('%" + datobuscar.Trim() + "%')";
                    lbl_cadena.Text = "Buscando : " + datobuscar + " En Columna : " + buscaren;
                    OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                    datos.Fill(dt);
                    OdbcCommand comando = new OdbcCommand(cadenaB, con);
                    OdbcDataReader leer;
                    leer = comando.ExecuteReader();

                }
                catch
                {
                    String textalert = " El dato : " + datobuscar + " No se encuentra en la Columna : " + buscaren;
                    MessageBox.Show(textalert);
                }

                con.Close();
            }
            return dt;
        }


        public void ingresar(string[] tipos, string [] datos, string tabla)
        {
            try
            {
                    string dato = " ";
                    string tipo = " ";
                    for (int x = 0; x < datos.Length; x++)
                    {

                        if (x == datos.Length - 1)
                        {
                            dato += "'" + datos[x] + "'";
                            tipo += tipos[x];
                        }
                        else
                        {
                            dato += "'" + datos[x] + "',";
                            tipo += tipos[x] + ",";
                        }

                    }
                    sn.insertar(dato, tipo, tabla);

                    MessageBox.Show("Dato Insertado");
                    
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

        public void actualizar(string[] tipos, string[] datos, string tabla, TextBox id)
        {   try
            {

               string dato = " ";

               string condicion = "(" + id.Tag.ToString() + " = '" + id.Text + "')";

                        for (int x = 1; x < tipos.Length; x++)
                        {

                            if (x == tipos.Length - 1)
                            {
                                dato += " " + tipos[x] + " = '" + datos[x] + "' ";

                            }
                            else if (x == 1)
                            {
                                dato += "SET " + tipos[x] + " = '" + datos[x] + "', ";

                            }
                            else
                            {
                                dato += " " + tipos[x] + " = '" + datos[x] + "', ";

                            }

                        }
                        sn.actualizar(dato, condicion, tabla);
                        
                        MessageBox.Show("Dato actualizado");             
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }
    }
}

