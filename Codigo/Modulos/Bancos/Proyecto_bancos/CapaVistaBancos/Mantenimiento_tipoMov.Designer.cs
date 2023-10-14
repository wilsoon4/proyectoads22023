
namespace CapaVistaBancos
{
    partial class Mantenimiento_tipoMov
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idtras = new System.Windows.Forms.TextBox();
            this.cb_transaexis = new System.Windows.Forms.ComboBox();
            this.txt_tipotrans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de transacción:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de transacción:";
            // 
            // txt_idtras
            // 
            this.txt_idtras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idtras.Location = new System.Drawing.Point(267, 135);
            this.txt_idtras.Name = "txt_idtras";
            this.txt_idtras.Size = new System.Drawing.Size(194, 26);
            this.txt_idtras.TabIndex = 4;
            this.txt_idtras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_transaexis
            // 
            this.cb_transaexis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_transaexis.FormattingEnabled = true;
            this.cb_transaexis.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Pago de nómina",
            "Pago a Proveedores"});
            this.cb_transaexis.Location = new System.Drawing.Point(267, 183);
            this.cb_transaexis.Name = "cb_transaexis";
            this.cb_transaexis.Size = new System.Drawing.Size(194, 28);
            this.cb_transaexis.TabIndex = 5;
            // 
            // txt_tipotrans
            // 
            this.txt_tipotrans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipotrans.Location = new System.Drawing.Point(267, 228);
            this.txt_tipotrans.Name = "txt_tipotrans";
            this.txt_tipotrans.Size = new System.Drawing.Size(194, 26);
            this.txt_tipotrans.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transacciones existentes:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(986, 232);
            this.dataGridView1.TabIndex = 8;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(20, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 9;
            // 
            // Mantenimiento_tipoMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 533);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tipotrans);
            this.Controls.Add(this.cb_transaexis);
            this.Controls.Add(this.txt_idtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Mantenimiento_tipoMov";
            this.Text = "Mantenimiento de Tipo de movimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idtras;
        private System.Windows.Forms.ComboBox cb_transaexis;
        private System.Windows.Forms.TextBox txt_tipotrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CapaVista.Navegador navegador1;
    }
}