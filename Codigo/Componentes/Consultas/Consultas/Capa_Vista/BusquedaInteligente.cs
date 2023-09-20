﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_ControladorConsultas;
using System.Data.Odbc;


//Función: Busqueda Inteligentes
namespace Capa_VistaConsultas
{
 
    public partial class Busqueda : Form
    {
       // Funcion: Inicializacion de la conexion ODBC

        csControldor cn = new csControldor();
        OdbcConnection con = new OdbcConnection("Dsn=consultas_Inteligentes");
        String tablabusqueda;
        public Busqueda()
        {
            InitializeComponent();
            string BD = "consultas_Inteligentes";
            cn.CargarTablas(cboTabla, BD);
            cn.CargarTablas(cboTablaConsultaSimple, BD);

            panel13.Enabled = false;
            panel15.Enabled = false;
            groupBox3.Enabled = false;
            groupBox6.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;


        }
        string consulta = "";

    
        // Funcion: Boton Cancelar cuando se crean consultas

        private void iconButton7_Click(object sender, EventArgs e)
        {
           
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            comboBox11.ResetText();
            textBox11.Clear();

        }

        //Funcion: Boton Agregar cuando se crean consultas

        private void button2_Click(object sender, EventArgs e)
        {

            string[] datos = { comboBox13.Text, comboBox12.Text, textBox16.Text };
            string[] tipos = { "operador_consulta", "campos_consulta", "valor_consultas" };
            cn.ingresar(tipos, datos, "tbl_consultainteligente1");
        }

        //Funcion: Boton Cancelar cuando se crean consultas

        private void button6_Click(object sender, EventArgs e)
        {

            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
        }


        //Funcion: Boton Cancelar en la creacion de consultas

        private void iconButton9_Click(object sender, EventArgs e)
        {
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
        }

        //Funcion: Boton Agregar creando consultas con condicionales

        private void button4_Click(object sender, EventArgs e)
        {

            string[] datos = { comboBox16.Text, comboBox17.Text };
            string[] tipos = { "ordenar_consulta", "campo_consulta" };
            cn.ingresar(tipos, datos, "tbl_consultainteligente2");

        }

        //Funcion: Boton Cancelar creando consultas con condicionales

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox16.ResetText();
            comboBox17.ResetText();
        }
        
        //Funcion: Boton Eliminar creando consultas con condicionales

        private void button8_Click(object sender, EventArgs e)
        {
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            comboBox11.ResetText();
            textBox11.Clear();
            comboBox16.ResetText();
            comboBox17.ResetText();
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
            comboBox14.ResetText();
            comboBox15.ResetText();
            textBox9.Clear();
            textBox8.Clear();
            textBox1.Clear();
        }


        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        //Funcion: Aun por definir
        private void iconButton2_Click(object sender, EventArgs e)
        {
            
            // textBox1.Text = txtNombreConsulta.Text+ cboTabla.Text+ comboBox11.Text+ textBox11.Text;
        }

       
        //Funcion: Actualizacion de consultas 

        public void actualizaconsultas(DataGridView dataGridView)
        {
            DataTable dt = cn.llenartb2();
            dataGridView.DataSource = dt;
        }

        //Funcion: Boton eliminar de la forma Buscar/Eliminar 
        private void button12_Click(object sender, EventArgs e)
        {

            cn.ejecutarconsulta(txtNombreConsultaBusquedaElimar.Text);
            if (MessageBox.Show("Desea eliminar el registro", "Desea eliminar el registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                MessageBox.Show("Las consultas con nombre " + txtNombreConsultaBusquedaElimar.Text + " Han sido eliminadas");
                actualizaconsultas(dgvBUSCARyELIMINAR);
                txtNombreConsultaBusquedaElimar.Text = "";
            }
        }
        public void actualizaconsultas2(string condicion)
        {
            DataTable dt = cn.llenartb3(condicion);
            dgvBUSCARyELIMINAR.DataSource = dt;
        }

        // Funcion: Aun en proceso

        //private void ConsultasInteligentes_Load(object sender, EventArgs e)
        //{

        //    llenarcboquery();
        //    tablaseditar();
        //}



        private void cbonombreconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTablaConsultaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txttablaeditar.Text = cboTablaConsultaSimple.SelectedItem.ToString();
            //chkSelectTodosConsultaSimple.Enabled = true;
        }

        string query = "registro_consultas";

        //Funcion: Boton Editar / Agregar de consulta avanzada

        private void button14_Click(object sender, EventArgs e)
        {

            actualizaconsultas(dgvBUSCARyELIMINAR);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarConsultas(cboQueryy);
            CargarConsultas(cbonombrebuscar);
        }

        private void cboCampoAgruparEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Funcion: Edicion de los campos de la BD

        private void cboAgruparEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAgruparEditar.SelectedIndex == 1)
            {
                groupBox7.Enabled = true;
            }
            else
            {
                groupBox7.Enabled = false;
                rdbAscEDITAR.Checked = false;
                rdbdescEDITAR.Checked = false;
            }
        }

        //Funcion: Boton Agregar y editar en la Busqueda compleja
        private void btnAgregarAgruparOrdenarEDITAR_Click(object sender, EventArgs e)
        {
            string[] datos = { cboAgruparEditar.Text, cboCampoAgruparEditar.Text };
            string[] tipos = { "ordenar_consulta", "campo_consulta" };
            cn.ingresar(tipos, datos, "tbl_consultainteligente2");
        }

        //Funcion: Boton Guardar los datos de busqueda compleja
        private void btnAgregarComparacionEDITAR_Click(object sender, EventArgs e)
        {

            string[] datos = { cboTipoComparadorEditar.Text, cboCampoEditar.Text, txtValorComparacionEDITAR.Text };
            string[] tipos = { "operador_consulta", "campos_consulta", "valor_consultas" };
            cn.ingresar(tipos, datos, "tbl_consultainteligente1");
        }
        
        private void btnagregarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {

            string[] datos = { cboOperadorLogicoEDITAR.Text, cboCampoConsultaComplejaEditar.Text, txtvalorConsultaComplejaEDITAR.Text };
            string[] tipos = { "operador_consulta", "campos_consulta", "valor_consultas" };
            cn.ingresar(tipos, datos, "tbl_consultainteligente1");
            
        }

        private void chkcondicioneseditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcondicioneseditar.Checked == true)

            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
            }

        }


        private void btnAgregarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {

            string[] datos = { txtcamposelectoseditar.Text, cboTablaConsultaSimple.Text, cboCamposEDITAR.Text, txtNombreAlias.Text, txtCadenaGeneradaEDITAR.Text };
            string[] tipos = { "nombre_consulta", "tabla_consulta", "campos_consultas", "alias_consultas", "cadena_consultas" };
            cn.actualizar(tipos, datos, "tbl_consultainteligente", idact);
            txtTablaConsulta.Text = (txtcamposelectoseditar.Text + "+" + cboTablaConsultaSimple.Text + "+" + cboCamposEDITAR.Text + "+" + txtNombreAlias.Text +"+" + txtCadenaGeneradaEDITAR.Text + "+");
            string columnasbd = comboBox11.Text;
           
        }



        private void button10_Click(object sender, EventArgs e)
        {

            actualizaconsultas2(txtNombreConsultaBusquedaElimar.Text);
        }
        //Funcion: Boton Actualizar las consultas
        private void button11_Click(object sender, EventArgs e)
        {
            string transfiere = txtNombreConsultaBusquedaElimar.Text;
            cbonombrebuscar.Text = transfiere;
            txtTablaConsulta.Text = transfiere;
            groupBox2.Enabled = true;
            tbpBuscarEliminar.Show();
            tbpEditar.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            textBox8.Text = "SELECT FROM" + "*" + "_" + "WHERE" + query + "_" + "INSERTED" + "";
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            comboBox11.ResetText();
            textBox11.Clear();
            comboBox16.ResetText();
            comboBox17.ResetText();
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
            comboBox14.ResetText();
            comboBox15.ResetText();
            textBox9.Clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {



            if (checkBox3.Checked == true)

            {
                panel15.Enabled = true;
                panel13.Enabled = true;
            }
            else
            {
                panel15.Enabled = false;
                panel13.Enabled = false;
                //checkBox3.Checked = false;

            }


        }
        //Aun en Proceso
        public void habilitaciones()
        {
            panel15.Enabled = false;
            panel13.Enabled = false;
            checkBox3.Checked = false;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Funcion: Muestra la cadena generada
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboQueryy.SelectedIndex = cboQueryy.SelectedIndex;
            txtCadenaGeneradaConsulta.Text = cboQueryy.SelectedItem.ToString();
            consulta = txtCadenaGeneradaConsulta.Text;
        }

        private void cbosubquery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Aun en proceso

        //private void iconButton27_Click(object sender, EventArgs e)
        //{
        //    actualizardatagrid();
        //}

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataTable dt = cn.llenartb1(consulta);
        //    dataGridView2.DataSource = dt;
        //}

        private void cbonombreconsulta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTablaConsulta.Text = cbonombrebuscar.SelectedItem.ToString();
            groupBox2.Enabled = true;
        }
        //Funcion: Seleccionar tabla
        private void cboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablabusqueda = "";
            comboBox11.Items.Clear();
            comboBox12.Items.Clear();
            comboBox15.Items.Clear();
            comboBox17.Items.Clear();
            tablabusqueda = cboTabla.Text;
            CargarColumnas(comboBox11, comboBox12, comboBox15, comboBox17, tablabusqueda);

        }
        //Funcion: Despliegue de tablas

        private void CargarColumnas(ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, ComboBox comboBox4, string @string)
        {
            DataTable dt = new DataTable();
            try
            {
                string cadena = " SELECT  * FROM " + tablabusqueda;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgv_prueba.DataSource = dt;
                    int ndgv = dgv_prueba.Columns.Count;

                    for (int i = 0; i < ndgv; i++)
                    {
                        String nameC;
                        nameC = dgv_prueba.Columns[i].HeaderText;
                        int ncbx = comboBox1.Items.Count;
                        if (ncbx < ndgv)
                        {
                            comboBox1.Items.Add(nameC);
                            comboBox2.Items.Add(nameC);
                            comboBox3.Items.Add(nameC);
                            comboBox4.Items.Add(nameC);
                        }
                    }
                }
            }
            catch
            {

            }
            con.Close();
        }

        private void cboCamposEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cboTablaConsultaSimple_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tablabusqueda = "";
            cboCamposEDITAR.Items.Clear();
            cboCampoConsultaComplejaEditar.Items.Clear();
            cboCampoEditar.Items.Clear();
            cboCampoAgruparEditar.Items.Clear();
            tablabusqueda = cboTablaConsultaSimple.Text;
            CargarColumnas(cboCamposEDITAR,cboCampoConsultaComplejaEditar,cboCampoEditar,cboCampoAgruparEditar, tablabusqueda); 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbpEditar_Click(object sender, EventArgs e)
        {

        }

        private void tbpCreacion_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        public void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTabla_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cboTabla_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTabla_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {

        }

        private void cboCampoConsultaComplejaEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCampoEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTablaConsulta_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnCancelarAgruparOrdenarEDITAR_Click(object sender, EventArgs e)
        {

            cboAgruparEditar.ResetText();
            cboCampoAgruparEditar.ResetText();
        }
        private void btnCancelarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {

            cboOperadorLogicoEDITAR.ResetText();
            cboCampoConsultaComplejaEditar.ResetText();

            txtvalorConsultaComplejaEDITAR.Clear();
        }

        private void txtcancelarComparacionEDITAR_Click(object sender, EventArgs e)
        {

            cboTipoComparadorEditar.ResetText();
            cboCampoEditar.ResetText();

            txtValorComparacionEDITAR.Clear();
        }

        private void btnCancelarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {

            txtcamposelectoseditar.Clear();
            cboTablaConsultaSimple.ResetText();
            cboCamposEDITAR.ResetText();
            txtNombreAlias.Clear();
            txtTablaConsulta.Clear();
        }

        //Limpia los campos al hacer click en iconButton1_Clic
        private void iconButton1_Click(object sender, EventArgs e)
        {

            txtcamposelectoseditar.Clear();
            cboTablaConsultaSimple.ResetText();
            cboCamposEDITAR.ResetText();
            txtNombreAlias.Clear();
            txtTablaConsulta.Clear();

            cboOperadorLogicoEDITAR.ResetText();
            cboCampoConsultaComplejaEditar.ResetText();

            txtvalorConsultaComplejaEDITAR.Clear();
            cboTipoComparadorEditar.ResetText();
            cboCampoEditar.ResetText();

            txtValorComparacionEDITAR.Clear();
            cboAgruparEditar.ResetText();
            cboCampoAgruparEditar.ResetText();
            txtCadenaGeneradaEDITAR.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {


            cn.editarconsulta(cboTablaConsultaSimple.Text, cboCamposEDITAR.Text, txtNombreAlias.Text, txtcamposelectoseditar.Text);
            cn.editarconsulta1(cboOperadorLogicoEDITAR.Text, cboCampoConsultaComplejaEditar.Text, txtvalorConsultaComplejaEDITAR.Text, cbocompand.Text);
            cn.editarconsulta2(cboAgruparEditar.Text, cboCampoAgruparEditar.Text);
            cn.editarconsulta3(cboCamposEDITAR.Text, txtvalorConsultaComplejaEDITAR.Text);


            Capa_ControladorConsultas.csControldor crud2 = new Capa_ControladorConsultas.csControldor();
            txtCadenaGeneradaEDITAR.Text = "SELECT FROM" + "*" + "_" + "WHERE" + query + "_" + "INSERTED" + "";
            
            
            //clear
            //txtcamposelectoseditar.Clear();
            //cboTablaConsultaSimple.ResetText();
            //cboCamposEDITAR.ResetText();
            //txtNombreAlias.Clear();
            //txtTablaConsulta.Clear();

            //cboOperadorLogicoEDITAR.ResetText();
            //cboCampoConsultaComplejaEditar.ResetText();
            //cbocompand.ResetText();
            //txtvalorConsultaComplejaEDITAR.Clear();
            //cboTipoComparadorEditar.ResetText();
            //cboCampoEditar.ResetText();
            //cbocompwhere.ResetText();
            //txtValorComparacionEDITAR.Clear();
            //cboAgruparEditar.ResetText();
            //cboCampoAgruparEditar.ResetText();
            //txtCadenaGeneradaEDITAR.Clear();


        }
        String datobuscar = "";
        String buscaren = "";
        private void button9_Click(object sender, EventArgs e)
        {
            actualizaconsultas(dataGridView2);


            datobuscar = txtCadenaGeneradaConsulta.Text;
            buscaren = cboQueryy.Text;
            actualizaconsultas2(txtCadenaGeneradaConsulta.Text);


            Capa_ControladorConsultas.csControldor crudbuscar = new Capa_ControladorConsultas.csControldor();
            txtCadenaGeneradaConsulta.Text = "SELECT FROM" + "*" + "_" + "WHERE" + query + "_" + "INSERTED" + "";


        }

        private void btnagregarcamposeditar_Click(object sender, EventArgs e)
        {

        }

        private void x(object sender, EventArgs e)
        {

        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            
        }

        private void tbpCreacion_HelpRequested(object sender, HelpEventArgs hlpevent)
        {


        }

        public void CargarConsultas(ComboBox cboQueryy)
        {
            con.Open();
            DataTable dt2 = new DataTable();
            OdbcCommand comand = new OdbcCommand();
            comand.Connection = con;
            comand.CommandType = CommandType.Text;
            string cadena = "SELECT nombre_consulta FROM tbl_consultainteligente";
            comand.CommandText = cadena;
            OdbcDataAdapter datos = new OdbcDataAdapter(comand);
            datos.Fill(dt2);
            cboQueryy.DataSource = dt2;
            cboQueryy.DisplayMember = "tbl_consultainteligente";
            cboQueryy.ValueMember = "nombre_consulta";
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBUSCARyELIMINAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

         //boton agregar de creacion de consulta
        private void button1_Click(object sender, EventArgs e)
        {

            string[] datos = { txtNombreConsulta.Text, cboTabla.Text, comboBox11.Text, textBox11.Text, textBox8.Text };
            string[] tipos = { "nombre_consulta", "tabla_consulta", "campos_consultas", "alias_consultas", "cadena_consultas" };
            cn.ingresar(tipos, datos, "tbl_consultainteligente");

            textBox1.Text = (txtNombreConsulta.Text + "+" + cboTabla.Text + "+" + comboBox11.Text + "+" + textBox11.Text + "+");
            string columnasbd = comboBox11.Text;
        }

        private void tbcBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string[] datos = { comboBox14.Text, comboBox15.Text, textBox9.Text };
            string[] tipos = { "operador_consulta", "campos_consulta", "valor_consultas" };
            cn.ingresar(tipos, datos, "tbl_consultainteligente1");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
 }
    
    



