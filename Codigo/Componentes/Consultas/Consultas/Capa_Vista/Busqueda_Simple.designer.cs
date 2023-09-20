
namespace Capa_VistaConsultas
{
    partial class Busqueda_Simple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda_Simple));
            this.dgvDato = new System.Windows.Forms.DataGridView();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lbl_cadena = new System.Windows.Forms.Label();
            this.cbox_columnas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BuscaPor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDato
            // 
            this.dgvDato.AllowUserToAddRows = false;
            this.dgvDato.AllowUserToDeleteRows = false;
            this.dgvDato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDato.Location = new System.Drawing.Point(12, 117);
            this.dgvDato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDato.Name = "dgvDato";
            this.dgvDato.RowHeadersWidth = 51;
            this.dgvDato.Size = new System.Drawing.Size(851, 181);
            this.dgvDato.TabIndex = 0;
            this.dgvDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDato_CellContentClick);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.panelResultado.Controls.Add(this.panel1);
            this.panelResultado.Location = new System.Drawing.Point(3, 9);
            this.panelResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(1017, 439);
            this.panelResultado.TabIndex = 11;
            this.panelResultado.Visible = false;
            this.panelResultado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultado_Paint);
            // 
            // lbl_cadena
            // 
            this.lbl_cadena.AutoSize = true;
            this.lbl_cadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadena.Location = new System.Drawing.Point(8, 344);
            this.lbl_cadena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cadena.Name = "lbl_cadena";
            this.lbl_cadena.Size = new System.Drawing.Size(94, 20);
            this.lbl_cadena.TabIndex = 40;
            this.lbl_cadena.Text = "Buscando :";
            // 
            // cbox_columnas
            // 
            this.cbox_columnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_columnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_columnas.FormattingEnabled = true;
            this.cbox_columnas.Location = new System.Drawing.Point(526, 67);
            this.cbox_columnas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_columnas.Name = "cbox_columnas";
            this.cbox_columnas.Size = new System.Drawing.Size(203, 28);
            this.cbox_columnas.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Buscar Por :";
            // 
            // txt_BuscaPor
            // 
            this.txt_BuscaPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscaPor.Location = new System.Drawing.Point(154, 71);
            this.txt_BuscaPor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BuscaPor.Name = "txt_BuscaPor";
            this.txt_BuscaPor.Size = new System.Drawing.Size(213, 26);
            this.txt_BuscaPor.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Buscar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Busqueda Simple Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_cadena);
            this.panel1.Controls.Add(this.cbox_columnas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_BuscaPor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvDato);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 415);
            this.panel1.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(768, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 61);
            this.button1.TabIndex = 41;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(789, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 65);
            this.button2.TabIndex = 42;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Busqueda_Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(902, 442);
            this.Controls.Add(this.panelResultado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Busqueda_Simple";
            this.Text = "Consulta Usuario Simple";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDato;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BuscaPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_columnas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cadena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}