namespace Proyecto_Final.tbd
{
    partial class TipoProductoForm
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
            this.dgvTP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarTP = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.tabTU = new System.Windows.Forms.TabControl();
            this.tabInsertMP = new System.Windows.Forms.TabPage();
            this.btnInsertTP = new System.Windows.Forms.Button();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.tbNombreTPInsert = new System.Windows.Forms.TextBox();
            this.tbIdTUPInsert = new System.Windows.Forms.TextBox();
            this.tabModMP = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreTPMod = new System.Windows.Forms.TextBox();
            this.tbIdTPMod = new System.Windows.Forms.TextBox();
            this.btnModTP = new System.Windows.Forms.Button();
            this.tabDropMP = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreTPDrop = new System.Windows.Forms.TextBox();
            this.tbIdTPDrop = new System.Windows.Forms.TextBox();
            this.btnDropTP = new System.Windows.Forms.Button();
            this.tabSelectMP = new System.Windows.Forms.TabPage();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.cbSelectTP = new System.Windows.Forms.ComboBox();
            this.btnSelectTP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabTU.SuspendLayout();
            this.tabInsertMP.SuspendLayout();
            this.tabModMP.SuspendLayout();
            this.tabDropMP.SuspendLayout();
            this.tabSelectMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTP
            // 
            this.dgvTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTP.Location = new System.Drawing.Point(4, 396);
            this.dgvTP.Name = "dgvTP";
            this.dgvTP.Size = new System.Drawing.Size(769, 150);
            this.dgvTP.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarTP);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 48);
            this.panel1.TabIndex = 8;
            // 
            // btnCerrarTP
            // 
            this.btnCerrarTP.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarTP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarTP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarTP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarTP.Location = new System.Drawing.Point(1, 0);
            this.btnCerrarTP.Name = "btnCerrarTP";
            this.btnCerrarTP.Size = new System.Drawing.Size(41, 41);
            this.btnCerrarTP.TabIndex = 3;
            this.btnCerrarTP.Text = "X";
            this.btnCerrarTP.UseVisualStyleBackColor = false;
            this.btnCerrarTP.Click += new System.EventHandler(this.btnCerrarTP_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(293, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(182, 24);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Tipos de Producto";
            // 
            // tabTU
            // 
            this.tabTU.Controls.Add(this.tabInsertMP);
            this.tabTU.Controls.Add(this.tabModMP);
            this.tabTU.Controls.Add(this.tabDropMP);
            this.tabTU.Controls.Add(this.tabSelectMP);
            this.tabTU.Location = new System.Drawing.Point(0, 57);
            this.tabTU.Name = "tabTU";
            this.tabTU.SelectedIndex = 0;
            this.tabTU.Size = new System.Drawing.Size(777, 337);
            this.tabTU.TabIndex = 7;
            // 
            // tabInsertMP
            // 
            this.tabInsertMP.Controls.Add(this.btnInsertTP);
            this.tabInsertMP.Controls.Add(this.lblNombreDeUsuario);
            this.tabInsertMP.Controls.Add(this.lblidUsuario);
            this.tabInsertMP.Controls.Add(this.tbNombreTPInsert);
            this.tabInsertMP.Controls.Add(this.tbIdTUPInsert);
            this.tabInsertMP.Location = new System.Drawing.Point(4, 22);
            this.tabInsertMP.Name = "tabInsertMP";
            this.tabInsertMP.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertMP.Size = new System.Drawing.Size(769, 311);
            this.tabInsertMP.TabIndex = 0;
            this.tabInsertMP.Text = "Insertar";
            this.tabInsertMP.UseVisualStyleBackColor = true;
            // 
            // btnInsertTP
            // 
            this.btnInsertTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertTP.Location = new System.Drawing.Point(316, 229);
            this.btnInsertTP.Name = "btnInsertTP";
            this.btnInsertTP.Size = new System.Drawing.Size(135, 36);
            this.btnInsertTP.TabIndex = 38;
            this.btnInsertTP.Text = "Insertar Datos";
            this.btnInsertTP.UseVisualStyleBackColor = true;
            this.btnInsertTP.Click += new System.EventHandler(this.btnInsertTP_Click);
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(328, 110);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(114, 13);
            this.lblNombreDeUsuario.TabIndex = 29;
            this.lblNombreDeUsuario.Text = "Nombre Tipo Producto";
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(341, 37);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(86, 13);
            this.lblidUsuario.TabIndex = 28;
            this.lblidUsuario.Text = "Id Tipo Producto";
            // 
            // tbNombreTPInsert
            // 
            this.tbNombreTPInsert.Location = new System.Drawing.Point(311, 136);
            this.tbNombreTPInsert.Name = "tbNombreTPInsert";
            this.tbNombreTPInsert.Size = new System.Drawing.Size(150, 20);
            this.tbNombreTPInsert.TabIndex = 23;
            // 
            // tbIdTUPInsert
            // 
            this.tbIdTUPInsert.Location = new System.Drawing.Point(352, 61);
            this.tbIdTUPInsert.Name = "tbIdTUPInsert";
            this.tbIdTUPInsert.Size = new System.Drawing.Size(58, 20);
            this.tbIdTUPInsert.TabIndex = 22;
            // 
            // tabModMP
            // 
            this.tabModMP.Controls.Add(this.label1);
            this.tabModMP.Controls.Add(this.label2);
            this.tabModMP.Controls.Add(this.tbNombreTPMod);
            this.tabModMP.Controls.Add(this.tbIdTPMod);
            this.tabModMP.Controls.Add(this.btnModTP);
            this.tabModMP.Location = new System.Drawing.Point(4, 22);
            this.tabModMP.Name = "tabModMP";
            this.tabModMP.Padding = new System.Windows.Forms.Padding(3);
            this.tabModMP.Size = new System.Drawing.Size(769, 311);
            this.tabModMP.TabIndex = 1;
            this.tabModMP.Text = "Modificar";
            this.tabModMP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre Tipo Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Id Tipo Producto";
            // 
            // tbNombreTPMod
            // 
            this.tbNombreTPMod.Enabled = false;
            this.tbNombreTPMod.Location = new System.Drawing.Point(306, 141);
            this.tbNombreTPMod.Name = "tbNombreTPMod";
            this.tbNombreTPMod.Size = new System.Drawing.Size(150, 20);
            this.tbNombreTPMod.TabIndex = 57;
            // 
            // tbIdTPMod
            // 
            this.tbIdTPMod.Location = new System.Drawing.Point(350, 66);
            this.tbIdTPMod.Name = "tbIdTPMod";
            this.tbIdTPMod.Size = new System.Drawing.Size(58, 20);
            this.tbIdTPMod.TabIndex = 56;
            // 
            // btnModTP
            // 
            this.btnModTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModTP.Location = new System.Drawing.Point(316, 228);
            this.btnModTP.Name = "btnModTP";
            this.btnModTP.Size = new System.Drawing.Size(135, 36);
            this.btnModTP.TabIndex = 55;
            this.btnModTP.Text = "Modificar Datos";
            this.btnModTP.UseVisualStyleBackColor = true;
            // 
            // tabDropMP
            // 
            this.tabDropMP.Controls.Add(this.label3);
            this.tabDropMP.Controls.Add(this.label4);
            this.tabDropMP.Controls.Add(this.tbNombreTPDrop);
            this.tabDropMP.Controls.Add(this.tbIdTPDrop);
            this.tabDropMP.Controls.Add(this.btnDropTP);
            this.tabDropMP.Location = new System.Drawing.Point(4, 22);
            this.tabDropMP.Name = "tabDropMP";
            this.tabDropMP.Size = new System.Drawing.Size(769, 311);
            this.tabDropMP.TabIndex = 2;
            this.tabDropMP.Text = "Eliminar";
            this.tabDropMP.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nombre Tipo Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Id Tipo Producto";
            // 
            // tbNombreTPDrop
            // 
            this.tbNombreTPDrop.Enabled = false;
            this.tbNombreTPDrop.Location = new System.Drawing.Point(308, 147);
            this.tbNombreTPDrop.Name = "tbNombreTPDrop";
            this.tbNombreTPDrop.Size = new System.Drawing.Size(150, 20);
            this.tbNombreTPDrop.TabIndex = 61;
            // 
            // tbIdTPDrop
            // 
            this.tbIdTPDrop.Location = new System.Drawing.Point(353, 72);
            this.tbIdTPDrop.Name = "tbIdTPDrop";
            this.tbIdTPDrop.Size = new System.Drawing.Size(58, 20);
            this.tbIdTPDrop.TabIndex = 60;
            // 
            // btnDropTP
            // 
            this.btnDropTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropTP.Location = new System.Drawing.Point(316, 224);
            this.btnDropTP.Name = "btnDropTP";
            this.btnDropTP.Size = new System.Drawing.Size(135, 36);
            this.btnDropTP.TabIndex = 55;
            this.btnDropTP.Text = "Eliminar Datos";
            this.btnDropTP.UseVisualStyleBackColor = true;
            // 
            // tabSelectMP
            // 
            this.tabSelectMP.Controls.Add(this.lblConsulta);
            this.tabSelectMP.Controls.Add(this.cbSelectTP);
            this.tabSelectMP.Controls.Add(this.btnSelectTP);
            this.tabSelectMP.Location = new System.Drawing.Point(4, 22);
            this.tabSelectMP.Name = "tabSelectMP";
            this.tabSelectMP.Size = new System.Drawing.Size(769, 311);
            this.tabSelectMP.TabIndex = 3;
            this.tabSelectMP.Text = "Consultar";
            this.tabSelectMP.UseVisualStyleBackColor = true;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(328, 99);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(109, 13);
            this.lblConsulta.TabIndex = 5;
            this.lblConsulta.Text = "Consultar por Nombre";
            // 
            // cbSelectTP
            // 
            this.cbSelectTP.FormattingEnabled = true;
            this.cbSelectTP.Location = new System.Drawing.Point(324, 128);
            this.cbSelectTP.Name = "cbSelectTP";
            this.cbSelectTP.Size = new System.Drawing.Size(121, 21);
            this.cbSelectTP.TabIndex = 4;
            // 
            // btnSelectTP
            // 
            this.btnSelectTP.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSelectTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTP.Location = new System.Drawing.Point(344, 188);
            this.btnSelectTP.Name = "btnSelectTP";
            this.btnSelectTP.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTP.TabIndex = 3;
            this.btnSelectTP.Text = "Consultar";
            this.btnSelectTP.UseVisualStyleBackColor = true;
            // 
            // TipoProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 547);
            this.Controls.Add(this.dgvTP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabTU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoProductoForm";
            this.Text = "TipoProductoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTU.ResumeLayout(false);
            this.tabInsertMP.ResumeLayout(false);
            this.tabInsertMP.PerformLayout();
            this.tabModMP.ResumeLayout(false);
            this.tabModMP.PerformLayout();
            this.tabDropMP.ResumeLayout(false);
            this.tabDropMP.PerformLayout();
            this.tabSelectMP.ResumeLayout(false);
            this.tabSelectMP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarTP;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TabControl tabTU;
        private System.Windows.Forms.TabPage tabInsertMP;
        private System.Windows.Forms.Button btnInsertTP;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox tbNombreTPInsert;
        private System.Windows.Forms.TextBox tbIdTUPInsert;
        private System.Windows.Forms.TabPage tabModMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreTPMod;
        private System.Windows.Forms.TextBox tbIdTPMod;
        private System.Windows.Forms.Button btnModTP;
        private System.Windows.Forms.TabPage tabDropMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreTPDrop;
        private System.Windows.Forms.TextBox tbIdTPDrop;
        private System.Windows.Forms.Button btnDropTP;
        private System.Windows.Forms.TabPage tabSelectMP;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.ComboBox cbSelectTP;
        private System.Windows.Forms.Button btnSelectTP;
    }
}