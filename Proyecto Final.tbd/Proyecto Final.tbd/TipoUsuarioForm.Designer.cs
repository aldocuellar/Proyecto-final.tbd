namespace Proyecto_Final.tbd
{
    partial class TipoUsuarioForm
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
            this.dgvTU = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarTU = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.tabTU = new System.Windows.Forms.TabControl();
            this.tabInsertTU = new System.Windows.Forms.TabPage();
            this.btnInsertTU = new System.Windows.Forms.Button();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.tbNombreTUInsert = new System.Windows.Forms.TextBox();
            this.tbIdTUInsert = new System.Windows.Forms.TextBox();
            this.tabModTU = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreTUMod = new System.Windows.Forms.TextBox();
            this.tbIdTUMod = new System.Windows.Forms.TextBox();
            this.btnModTU = new System.Windows.Forms.Button();
            this.tabDropTU = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreTUDrop = new System.Windows.Forms.TextBox();
            this.tbIdTUDrop = new System.Windows.Forms.TextBox();
            this.btnDropTU = new System.Windows.Forms.Button();
            this.tabSelectTU = new System.Windows.Forms.TabPage();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.cbSelectTU = new System.Windows.Forms.ComboBox();
            this.btnSelectTU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTU)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabTU.SuspendLayout();
            this.tabInsertTU.SuspendLayout();
            this.tabModTU.SuspendLayout();
            this.tabDropTU.SuspendLayout();
            this.tabSelectTU.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTU
            // 
            this.dgvTU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTU.Location = new System.Drawing.Point(4, 395);
            this.dgvTU.Name = "dgvTU";
            this.dgvTU.Size = new System.Drawing.Size(769, 150);
            this.dgvTU.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarTU);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 48);
            this.panel1.TabIndex = 5;
            // 
            // btnCerrarTU
            // 
            this.btnCerrarTU.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarTU.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarTU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarTU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarTU.Location = new System.Drawing.Point(1, 0);
            this.btnCerrarTU.Name = "btnCerrarTU";
            this.btnCerrarTU.Size = new System.Drawing.Size(41, 41);
            this.btnCerrarTU.TabIndex = 3;
            this.btnCerrarTU.Text = "X";
            this.btnCerrarTU.UseVisualStyleBackColor = false;
            this.btnCerrarTU.Click += new System.EventHandler(this.btnCerrarTU_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(299, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(169, 24);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Tipos de Usuario";
            // 
            // tabTU
            // 
            this.tabTU.Controls.Add(this.tabInsertTU);
            this.tabTU.Controls.Add(this.tabModTU);
            this.tabTU.Controls.Add(this.tabDropTU);
            this.tabTU.Controls.Add(this.tabSelectTU);
            this.tabTU.Location = new System.Drawing.Point(0, 54);
            this.tabTU.Name = "tabTU";
            this.tabTU.SelectedIndex = 0;
            this.tabTU.Size = new System.Drawing.Size(777, 337);
            this.tabTU.TabIndex = 4;
            // 
            // tabInsertTU
            // 
            this.tabInsertTU.Controls.Add(this.btnInsertTU);
            this.tabInsertTU.Controls.Add(this.lblNombreDeUsuario);
            this.tabInsertTU.Controls.Add(this.lblidUsuario);
            this.tabInsertTU.Controls.Add(this.tbNombreTUInsert);
            this.tabInsertTU.Controls.Add(this.tbIdTUInsert);
            this.tabInsertTU.Location = new System.Drawing.Point(4, 22);
            this.tabInsertTU.Name = "tabInsertTU";
            this.tabInsertTU.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertTU.Size = new System.Drawing.Size(769, 311);
            this.tabInsertTU.TabIndex = 0;
            this.tabInsertTU.Text = "Insertar";
            this.tabInsertTU.UseVisualStyleBackColor = true;
            // 
            // btnInsertTU
            // 
            this.btnInsertTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertTU.Location = new System.Drawing.Point(316, 229);
            this.btnInsertTU.Name = "btnInsertTU";
            this.btnInsertTU.Size = new System.Drawing.Size(135, 36);
            this.btnInsertTU.TabIndex = 38;
            this.btnInsertTU.Text = "Insertar Datos";
            this.btnInsertTU.UseVisualStyleBackColor = true;
            this.btnInsertTU.Click += new System.EventHandler(this.btnInsertTU_Click);
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(331, 110);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(107, 13);
            this.lblNombreDeUsuario.TabIndex = 29;
            this.lblNombreDeUsuario.Text = "Nombre Tipo Usuario";
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(341, 37);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(79, 13);
            this.lblidUsuario.TabIndex = 28;
            this.lblidUsuario.Text = "Id Tipo Usuario";
            // 
            // tbNombreTUInsert
            // 
            this.tbNombreTUInsert.Location = new System.Drawing.Point(311, 136);
            this.tbNombreTUInsert.Name = "tbNombreTUInsert";
            this.tbNombreTUInsert.Size = new System.Drawing.Size(150, 20);
            this.tbNombreTUInsert.TabIndex = 23;
            // 
            // tbIdTUInsert
            // 
            this.tbIdTUInsert.Location = new System.Drawing.Point(352, 61);
            this.tbIdTUInsert.Name = "tbIdTUInsert";
            this.tbIdTUInsert.Size = new System.Drawing.Size(58, 20);
            this.tbIdTUInsert.TabIndex = 22;
            // 
            // tabModTU
            // 
            this.tabModTU.Controls.Add(this.label1);
            this.tabModTU.Controls.Add(this.label2);
            this.tabModTU.Controls.Add(this.tbNombreTUMod);
            this.tabModTU.Controls.Add(this.tbIdTUMod);
            this.tabModTU.Controls.Add(this.btnModTU);
            this.tabModTU.Location = new System.Drawing.Point(4, 22);
            this.tabModTU.Name = "tabModTU";
            this.tabModTU.Padding = new System.Windows.Forms.Padding(3);
            this.tabModTU.Size = new System.Drawing.Size(769, 311);
            this.tabModTU.TabIndex = 1;
            this.tabModTU.Text = "Modificar";
            this.tabModTU.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre Tipo Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Id Tipo Usuario";
            // 
            // tbNombreTUMod
            // 
            this.tbNombreTUMod.Enabled = false;
            this.tbNombreTUMod.Location = new System.Drawing.Point(306, 141);
            this.tbNombreTUMod.Name = "tbNombreTUMod";
            this.tbNombreTUMod.Size = new System.Drawing.Size(150, 20);
            this.tbNombreTUMod.TabIndex = 57;
            // 
            // tbIdTUMod
            // 
            this.tbIdTUMod.Location = new System.Drawing.Point(350, 66);
            this.tbIdTUMod.Name = "tbIdTUMod";
            this.tbIdTUMod.Size = new System.Drawing.Size(58, 20);
            this.tbIdTUMod.TabIndex = 56;
            this.tbIdTUMod.TextChanged += new System.EventHandler(this.tbIdTUMod_TextChanged);
            // 
            // btnModTU
            // 
            this.btnModTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModTU.Location = new System.Drawing.Point(316, 228);
            this.btnModTU.Name = "btnModTU";
            this.btnModTU.Size = new System.Drawing.Size(135, 36);
            this.btnModTU.TabIndex = 55;
            this.btnModTU.Text = "Modificar Datos";
            this.btnModTU.UseVisualStyleBackColor = true;
            this.btnModTU.Click += new System.EventHandler(this.btnModTU_Click);
            // 
            // tabDropTU
            // 
            this.tabDropTU.Controls.Add(this.label3);
            this.tabDropTU.Controls.Add(this.label4);
            this.tabDropTU.Controls.Add(this.tbNombreTUDrop);
            this.tabDropTU.Controls.Add(this.tbIdTUDrop);
            this.tabDropTU.Controls.Add(this.btnDropTU);
            this.tabDropTU.Location = new System.Drawing.Point(4, 22);
            this.tabDropTU.Name = "tabDropTU";
            this.tabDropTU.Size = new System.Drawing.Size(769, 311);
            this.tabDropTU.TabIndex = 2;
            this.tabDropTU.Text = "Eliminar";
            this.tabDropTU.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nombre Tipo Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Id Tipo Usuario";
            // 
            // tbNombreTUDrop
            // 
            this.tbNombreTUDrop.Enabled = false;
            this.tbNombreTUDrop.Location = new System.Drawing.Point(309, 147);
            this.tbNombreTUDrop.Name = "tbNombreTUDrop";
            this.tbNombreTUDrop.Size = new System.Drawing.Size(150, 20);
            this.tbNombreTUDrop.TabIndex = 61;
            // 
            // tbIdTUDrop
            // 
            this.tbIdTUDrop.Location = new System.Drawing.Point(353, 72);
            this.tbIdTUDrop.Name = "tbIdTUDrop";
            this.tbIdTUDrop.Size = new System.Drawing.Size(58, 20);
            this.tbIdTUDrop.TabIndex = 60;
            // 
            // btnDropTU
            // 
            this.btnDropTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropTU.Location = new System.Drawing.Point(316, 224);
            this.btnDropTU.Name = "btnDropTU";
            this.btnDropTU.Size = new System.Drawing.Size(135, 36);
            this.btnDropTU.TabIndex = 55;
            this.btnDropTU.Text = "Eliminar Datos";
            this.btnDropTU.UseVisualStyleBackColor = true;
            this.btnDropTU.Click += new System.EventHandler(this.btnDropTU_Click);
            // 
            // tabSelectTU
            // 
            this.tabSelectTU.Controls.Add(this.lblConsulta);
            this.tabSelectTU.Controls.Add(this.cbSelectTU);
            this.tabSelectTU.Controls.Add(this.btnSelectTU);
            this.tabSelectTU.Location = new System.Drawing.Point(4, 22);
            this.tabSelectTU.Name = "tabSelectTU";
            this.tabSelectTU.Size = new System.Drawing.Size(769, 311);
            this.tabSelectTU.TabIndex = 3;
            this.tabSelectTU.Text = "Consultar";
            this.tabSelectTU.UseVisualStyleBackColor = true;
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
            // cbSelectTU
            // 
            this.cbSelectTU.FormattingEnabled = true;
            this.cbSelectTU.Location = new System.Drawing.Point(324, 128);
            this.cbSelectTU.Name = "cbSelectTU";
            this.cbSelectTU.Size = new System.Drawing.Size(121, 21);
            this.cbSelectTU.TabIndex = 4;
            // 
            // btnSelectTU
            // 
            this.btnSelectTU.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSelectTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTU.Location = new System.Drawing.Point(344, 188);
            this.btnSelectTU.Name = "btnSelectTU";
            this.btnSelectTU.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTU.TabIndex = 3;
            this.btnSelectTU.Text = "Consultar";
            this.btnSelectTU.UseVisualStyleBackColor = true;
            this.btnSelectTU.Click += new System.EventHandler(this.btnSelectTU_Click);
            // 
            // TipoUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 547);
            this.Controls.Add(this.dgvTU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabTU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoUsuarioForm";
            this.Text = "TipoUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTU)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTU.ResumeLayout(false);
            this.tabInsertTU.ResumeLayout(false);
            this.tabInsertTU.PerformLayout();
            this.tabModTU.ResumeLayout(false);
            this.tabModTU.PerformLayout();
            this.tabDropTU.ResumeLayout(false);
            this.tabDropTU.PerformLayout();
            this.tabSelectTU.ResumeLayout(false);
            this.tabSelectTU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarTU;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TabControl tabTU;
        private System.Windows.Forms.TabPage tabInsertTU;
        private System.Windows.Forms.Button btnInsertTU;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox tbNombreTUInsert;
        private System.Windows.Forms.TextBox tbIdTUInsert;
        private System.Windows.Forms.TabPage tabModTU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreTUMod;
        private System.Windows.Forms.TextBox tbIdTUMod;
        private System.Windows.Forms.Button btnModTU;
        private System.Windows.Forms.TabPage tabDropTU;
        private System.Windows.Forms.Button btnDropTU;
        private System.Windows.Forms.TabPage tabSelectTU;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.ComboBox cbSelectTU;
        private System.Windows.Forms.Button btnSelectTU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreTUDrop;
        private System.Windows.Forms.TextBox tbIdTUDrop;
    }
}