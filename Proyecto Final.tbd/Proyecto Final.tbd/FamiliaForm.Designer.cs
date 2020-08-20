namespace Proyecto_Final.tbd
{
    partial class FamiliaForm
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
            this.dgvFP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarFP = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.tabTU = new System.Windows.Forms.TabControl();
            this.tabInsertFP = new System.Windows.Forms.TabPage();
            this.btnInsertFP = new System.Windows.Forms.Button();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.tbNombreFPInsert = new System.Windows.Forms.TextBox();
            this.tbIdFPInsert = new System.Windows.Forms.TextBox();
            this.tabModFP = new System.Windows.Forms.TabPage();
            this.btnModFP = new System.Windows.Forms.Button();
            this.tabDropFP = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreTUDrop = new System.Windows.Forms.TextBox();
            this.tbIdTUDrop = new System.Windows.Forms.TextBox();
            this.btnDropFP = new System.Windows.Forms.Button();
            this.tabSelectFP = new System.Windows.Forms.TabPage();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.cbSelectFP = new System.Windows.Forms.ComboBox();
            this.btnSelectFP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreFPMod = new System.Windows.Forms.TextBox();
            this.tbIdFPMod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabTU.SuspendLayout();
            this.tabInsertFP.SuspendLayout();
            this.tabModFP.SuspendLayout();
            this.tabDropFP.SuspendLayout();
            this.tabSelectFP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFP
            // 
            this.dgvFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFP.Location = new System.Drawing.Point(4, 396);
            this.dgvFP.Name = "dgvFP";
            this.dgvFP.Size = new System.Drawing.Size(769, 150);
            this.dgvFP.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarFP);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 48);
            this.panel1.TabIndex = 8;
            // 
            // btnCerrarFP
            // 
            this.btnCerrarFP.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarFP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarFP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarFP.Location = new System.Drawing.Point(1, 0);
            this.btnCerrarFP.Name = "btnCerrarFP";
            this.btnCerrarFP.Size = new System.Drawing.Size(41, 41);
            this.btnCerrarFP.TabIndex = 3;
            this.btnCerrarFP.Text = "X";
            this.btnCerrarFP.UseVisualStyleBackColor = false;
            this.btnCerrarFP.Click += new System.EventHandler(this.btnCerrarFP_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(299, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(167, 24);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Familia Producto";
            // 
            // tabTU
            // 
            this.tabTU.Controls.Add(this.tabInsertFP);
            this.tabTU.Controls.Add(this.tabModFP);
            this.tabTU.Controls.Add(this.tabDropFP);
            this.tabTU.Controls.Add(this.tabSelectFP);
            this.tabTU.Location = new System.Drawing.Point(0, 57);
            this.tabTU.Name = "tabTU";
            this.tabTU.SelectedIndex = 0;
            this.tabTU.Size = new System.Drawing.Size(777, 337);
            this.tabTU.TabIndex = 7;
            // 
            // tabInsertFP
            // 
            this.tabInsertFP.Controls.Add(this.btnInsertFP);
            this.tabInsertFP.Controls.Add(this.lblNombreDeUsuario);
            this.tabInsertFP.Controls.Add(this.lblidUsuario);
            this.tabInsertFP.Controls.Add(this.tbNombreFPInsert);
            this.tabInsertFP.Controls.Add(this.tbIdFPInsert);
            this.tabInsertFP.Location = new System.Drawing.Point(4, 22);
            this.tabInsertFP.Name = "tabInsertFP";
            this.tabInsertFP.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertFP.Size = new System.Drawing.Size(769, 311);
            this.tabInsertFP.TabIndex = 0;
            this.tabInsertFP.Text = "Insertar";
            this.tabInsertFP.UseVisualStyleBackColor = true;
            // 
            // btnInsertFP
            // 
            this.btnInsertFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFP.Location = new System.Drawing.Point(312, 228);
            this.btnInsertFP.Name = "btnInsertFP";
            this.btnInsertFP.Size = new System.Drawing.Size(135, 36);
            this.btnInsertFP.TabIndex = 38;
            this.btnInsertFP.Text = "Insertar Datos";
            this.btnInsertFP.UseVisualStyleBackColor = true;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(339, 110);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(79, 13);
            this.lblNombreDeUsuario.TabIndex = 29;
            this.lblNombreDeUsuario.Text = "Nombre Familia";
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(330, 37);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(97, 13);
            this.lblidUsuario.TabIndex = 28;
            this.lblidUsuario.Text = "Id Familia Producto";
            // 
            // tbNombreFPInsert
            // 
            this.tbNombreFPInsert.Location = new System.Drawing.Point(304, 136);
            this.tbNombreFPInsert.Name = "tbNombreFPInsert";
            this.tbNombreFPInsert.Size = new System.Drawing.Size(150, 20);
            this.tbNombreFPInsert.TabIndex = 23;
            // 
            // tbIdFPInsert
            // 
            this.tbIdFPInsert.Location = new System.Drawing.Point(349, 61);
            this.tbIdFPInsert.Name = "tbIdFPInsert";
            this.tbIdFPInsert.Size = new System.Drawing.Size(58, 20);
            this.tbIdFPInsert.TabIndex = 22;
            // 
            // tabModFP
            // 
            this.tabModFP.Controls.Add(this.label1);
            this.tabModFP.Controls.Add(this.label2);
            this.tabModFP.Controls.Add(this.tbNombreFPMod);
            this.tabModFP.Controls.Add(this.tbIdFPMod);
            this.tabModFP.Controls.Add(this.btnModFP);
            this.tabModFP.Location = new System.Drawing.Point(4, 22);
            this.tabModFP.Name = "tabModFP";
            this.tabModFP.Padding = new System.Windows.Forms.Padding(3);
            this.tabModFP.Size = new System.Drawing.Size(769, 311);
            this.tabModFP.TabIndex = 1;
            this.tabModFP.Text = "Modificar";
            this.tabModFP.UseVisualStyleBackColor = true;
            // 
            // btnModFP
            // 
            this.btnModFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModFP.Location = new System.Drawing.Point(316, 228);
            this.btnModFP.Name = "btnModFP";
            this.btnModFP.Size = new System.Drawing.Size(135, 36);
            this.btnModFP.TabIndex = 55;
            this.btnModFP.Text = "Modificar Datos";
            this.btnModFP.UseVisualStyleBackColor = true;
            // 
            // tabDropFP
            // 
            this.tabDropFP.Controls.Add(this.label3);
            this.tabDropFP.Controls.Add(this.label4);
            this.tabDropFP.Controls.Add(this.tbNombreTUDrop);
            this.tabDropFP.Controls.Add(this.tbIdTUDrop);
            this.tabDropFP.Controls.Add(this.btnDropFP);
            this.tabDropFP.Location = new System.Drawing.Point(4, 22);
            this.tabDropFP.Name = "tabDropFP";
            this.tabDropFP.Size = new System.Drawing.Size(769, 311);
            this.tabDropFP.TabIndex = 2;
            this.tabDropFP.Text = "Eliminar";
            this.tabDropFP.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nombre Familia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Id Familia Producto";
            // 
            // tbNombreTUDrop
            // 
            this.tbNombreTUDrop.Enabled = false;
            this.tbNombreTUDrop.Location = new System.Drawing.Point(298, 147);
            this.tbNombreTUDrop.Name = "tbNombreTUDrop";
            this.tbNombreTUDrop.Size = new System.Drawing.Size(150, 20);
            this.tbNombreTUDrop.TabIndex = 61;
            // 
            // tbIdTUDrop
            // 
            this.tbIdTUDrop.Location = new System.Drawing.Point(343, 72);
            this.tbIdTUDrop.Name = "tbIdTUDrop";
            this.tbIdTUDrop.Size = new System.Drawing.Size(58, 20);
            this.tbIdTUDrop.TabIndex = 60;
            // 
            // btnDropFP
            // 
            this.btnDropFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropFP.Location = new System.Drawing.Point(306, 224);
            this.btnDropFP.Name = "btnDropFP";
            this.btnDropFP.Size = new System.Drawing.Size(135, 36);
            this.btnDropFP.TabIndex = 55;
            this.btnDropFP.Text = "Eliminar Datos";
            this.btnDropFP.UseVisualStyleBackColor = true;
            // 
            // tabSelectFP
            // 
            this.tabSelectFP.Controls.Add(this.lblConsulta);
            this.tabSelectFP.Controls.Add(this.cbSelectFP);
            this.tabSelectFP.Controls.Add(this.btnSelectFP);
            this.tabSelectFP.Location = new System.Drawing.Point(4, 22);
            this.tabSelectFP.Name = "tabSelectFP";
            this.tabSelectFP.Size = new System.Drawing.Size(769, 311);
            this.tabSelectFP.TabIndex = 3;
            this.tabSelectFP.Text = "Consultar";
            this.tabSelectFP.UseVisualStyleBackColor = true;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(326, 99);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(109, 13);
            this.lblConsulta.TabIndex = 5;
            this.lblConsulta.Text = "Consultar por Nombre";
            // 
            // cbSelectFP
            // 
            this.cbSelectFP.FormattingEnabled = true;
            this.cbSelectFP.Location = new System.Drawing.Point(320, 128);
            this.cbSelectFP.Name = "cbSelectFP";
            this.cbSelectFP.Size = new System.Drawing.Size(121, 21);
            this.cbSelectFP.TabIndex = 4;
            // 
            // btnSelectFP
            // 
            this.btnSelectFP.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSelectFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFP.Location = new System.Drawing.Point(344, 188);
            this.btnSelectFP.Name = "btnSelectFP";
            this.btnSelectFP.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFP.TabIndex = 3;
            this.btnSelectFP.Text = "Consultar";
            this.btnSelectFP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre Familia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Id Familia Producto";
            // 
            // tbNombreFPMod
            // 
            this.tbNombreFPMod.Enabled = false;
            this.tbNombreFPMod.Location = new System.Drawing.Point(309, 142);
            this.tbNombreFPMod.Name = "tbNombreFPMod";
            this.tbNombreFPMod.Size = new System.Drawing.Size(150, 20);
            this.tbNombreFPMod.TabIndex = 57;
            // 
            // tbIdFPMod
            // 
            this.tbIdFPMod.Location = new System.Drawing.Point(354, 67);
            this.tbIdFPMod.Name = "tbIdFPMod";
            this.tbIdFPMod.Size = new System.Drawing.Size(58, 20);
            this.tbIdFPMod.TabIndex = 56;
            // 
            // FamiliaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 547);
            this.Controls.Add(this.dgvFP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabTU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FamiliaForm";
            this.Text = "FamiliaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTU.ResumeLayout(false);
            this.tabInsertFP.ResumeLayout(false);
            this.tabInsertFP.PerformLayout();
            this.tabModFP.ResumeLayout(false);
            this.tabModFP.PerformLayout();
            this.tabDropFP.ResumeLayout(false);
            this.tabDropFP.PerformLayout();
            this.tabSelectFP.ResumeLayout(false);
            this.tabSelectFP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarFP;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TabControl tabTU;
        private System.Windows.Forms.TabPage tabInsertFP;
        private System.Windows.Forms.Button btnInsertFP;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox tbNombreFPInsert;
        private System.Windows.Forms.TextBox tbIdFPInsert;
        private System.Windows.Forms.TabPage tabModFP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreFPMod;
        private System.Windows.Forms.TextBox tbIdFPMod;
        private System.Windows.Forms.Button btnModFP;
        private System.Windows.Forms.TabPage tabDropFP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreTUDrop;
        private System.Windows.Forms.TextBox tbIdTUDrop;
        private System.Windows.Forms.Button btnDropFP;
        private System.Windows.Forms.TabPage tabSelectFP;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.ComboBox cbSelectFP;
        private System.Windows.Forms.Button btnSelectFP;
    }
}