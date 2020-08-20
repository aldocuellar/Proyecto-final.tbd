namespace Proyecto_Final.tbd
{
    partial class VentaForm
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
            this.btnCerrarMP = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.tabTU = new System.Windows.Forms.TabControl();
            this.tabInsertMP = new System.Windows.Forms.TabPage();
            this.btnInsertMP = new System.Windows.Forms.Button();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.tbNombreMPInsert = new System.Windows.Forms.TextBox();
            this.tbIdMPInsert = new System.Windows.Forms.TextBox();
            this.tabModMP = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreMPMod = new System.Windows.Forms.TextBox();
            this.tbIdMPMod = new System.Windows.Forms.TextBox();
            this.btnModMP = new System.Windows.Forms.Button();
            this.tabDropMP = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreMPDrop = new System.Windows.Forms.TextBox();
            this.tbIdMPDrop = new System.Windows.Forms.TextBox();
            this.btnDropMP = new System.Windows.Forms.Button();
            this.tabSelectMP = new System.Windows.Forms.TabPage();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.cbSelectFP = new System.Windows.Forms.ComboBox();
            this.btnSelectMP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabTU.SuspendLayout();
            this.tabInsertMP.SuspendLayout();
            this.tabModMP.SuspendLayout();
            this.tabDropMP.SuspendLayout();
            this.tabSelectMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFP
            // 
            this.dgvFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFP.Location = new System.Drawing.Point(4, 396);
            this.dgvFP.Name = "dgvFP";
            this.dgvFP.Size = new System.Drawing.Size(769, 150);
            this.dgvFP.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarMP);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 48);
            this.panel1.TabIndex = 14;
            // 
            // btnCerrarMP
            // 
            this.btnCerrarMP.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarMP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarMP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarMP.Location = new System.Drawing.Point(1, 0);
            this.btnCerrarMP.Name = "btnCerrarMP";
            this.btnCerrarMP.Size = new System.Drawing.Size(41, 41);
            this.btnCerrarMP.TabIndex = 3;
            this.btnCerrarMP.Text = "X";
            this.btnCerrarMP.UseVisualStyleBackColor = false;
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(347, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(64, 24);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Venta";
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
            this.tabTU.TabIndex = 13;
            // 
            // tabInsertMP
            // 
            this.tabInsertMP.Controls.Add(this.btnInsertMP);
            this.tabInsertMP.Controls.Add(this.lblNombreDeUsuario);
            this.tabInsertMP.Controls.Add(this.lblidUsuario);
            this.tabInsertMP.Controls.Add(this.tbNombreMPInsert);
            this.tabInsertMP.Controls.Add(this.tbIdMPInsert);
            this.tabInsertMP.Location = new System.Drawing.Point(4, 22);
            this.tabInsertMP.Name = "tabInsertMP";
            this.tabInsertMP.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertMP.Size = new System.Drawing.Size(769, 311);
            this.tabInsertMP.TabIndex = 0;
            this.tabInsertMP.Text = "Insertar";
            this.tabInsertMP.UseVisualStyleBackColor = true;
            // 
            // btnInsertMP
            // 
            this.btnInsertMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertMP.Location = new System.Drawing.Point(312, 228);
            this.btnInsertMP.Name = "btnInsertMP";
            this.btnInsertMP.Size = new System.Drawing.Size(135, 36);
            this.btnInsertMP.TabIndex = 38;
            this.btnInsertMP.Text = "Insertar Datos";
            this.btnInsertMP.UseVisualStyleBackColor = true;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(339, 110);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(77, 13);
            this.lblNombreDeUsuario.TabIndex = 29;
            this.lblNombreDeUsuario.Text = "Nombre Marca";
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(330, 37);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(95, 13);
            this.lblidUsuario.TabIndex = 28;
            this.lblidUsuario.Text = "Id Marca Producto";
            // 
            // tbNombreMPInsert
            // 
            this.tbNombreMPInsert.Location = new System.Drawing.Point(304, 136);
            this.tbNombreMPInsert.Name = "tbNombreMPInsert";
            this.tbNombreMPInsert.Size = new System.Drawing.Size(150, 20);
            this.tbNombreMPInsert.TabIndex = 23;
            // 
            // tbIdMPInsert
            // 
            this.tbIdMPInsert.Location = new System.Drawing.Point(349, 61);
            this.tbIdMPInsert.Name = "tbIdMPInsert";
            this.tbIdMPInsert.Size = new System.Drawing.Size(58, 20);
            this.tbIdMPInsert.TabIndex = 22;
            // 
            // tabModMP
            // 
            this.tabModMP.Controls.Add(this.label1);
            this.tabModMP.Controls.Add(this.label2);
            this.tabModMP.Controls.Add(this.tbNombreMPMod);
            this.tabModMP.Controls.Add(this.tbIdMPMod);
            this.tabModMP.Controls.Add(this.btnModMP);
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
            this.label1.Location = new System.Drawing.Point(344, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Id Marca Producto";
            // 
            // tbNombreMPMod
            // 
            this.tbNombreMPMod.Enabled = false;
            this.tbNombreMPMod.Location = new System.Drawing.Point(309, 142);
            this.tbNombreMPMod.Name = "tbNombreMPMod";
            this.tbNombreMPMod.Size = new System.Drawing.Size(150, 20);
            this.tbNombreMPMod.TabIndex = 57;
            // 
            // tbIdMPMod
            // 
            this.tbIdMPMod.Location = new System.Drawing.Point(354, 67);
            this.tbIdMPMod.Name = "tbIdMPMod";
            this.tbIdMPMod.Size = new System.Drawing.Size(58, 20);
            this.tbIdMPMod.TabIndex = 56;
            // 
            // btnModMP
            // 
            this.btnModMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModMP.Location = new System.Drawing.Point(316, 228);
            this.btnModMP.Name = "btnModMP";
            this.btnModMP.Size = new System.Drawing.Size(135, 36);
            this.btnModMP.TabIndex = 55;
            this.btnModMP.Text = "Modificar Datos";
            this.btnModMP.UseVisualStyleBackColor = true;
            // 
            // tabDropMP
            // 
            this.tabDropMP.Controls.Add(this.label3);
            this.tabDropMP.Controls.Add(this.label4);
            this.tabDropMP.Controls.Add(this.tbNombreMPDrop);
            this.tabDropMP.Controls.Add(this.tbIdMPDrop);
            this.tabDropMP.Controls.Add(this.btnDropMP);
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
            this.label3.Location = new System.Drawing.Point(332, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nombre Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Id Marca Producto";
            // 
            // tbNombreMPDrop
            // 
            this.tbNombreMPDrop.Enabled = false;
            this.tbNombreMPDrop.Location = new System.Drawing.Point(298, 147);
            this.tbNombreMPDrop.Name = "tbNombreMPDrop";
            this.tbNombreMPDrop.Size = new System.Drawing.Size(150, 20);
            this.tbNombreMPDrop.TabIndex = 61;
            // 
            // tbIdMPDrop
            // 
            this.tbIdMPDrop.Location = new System.Drawing.Point(343, 72);
            this.tbIdMPDrop.Name = "tbIdMPDrop";
            this.tbIdMPDrop.Size = new System.Drawing.Size(58, 20);
            this.tbIdMPDrop.TabIndex = 60;
            // 
            // btnDropMP
            // 
            this.btnDropMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropMP.Location = new System.Drawing.Point(306, 224);
            this.btnDropMP.Name = "btnDropMP";
            this.btnDropMP.Size = new System.Drawing.Size(135, 36);
            this.btnDropMP.TabIndex = 55;
            this.btnDropMP.Text = "Eliminar Datos";
            this.btnDropMP.UseVisualStyleBackColor = true;
            // 
            // tabSelectMP
            // 
            this.tabSelectMP.Controls.Add(this.lblConsulta);
            this.tabSelectMP.Controls.Add(this.cbSelectFP);
            this.tabSelectMP.Controls.Add(this.btnSelectMP);
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
            // btnSelectMP
            // 
            this.btnSelectMP.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSelectMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMP.Location = new System.Drawing.Point(344, 188);
            this.btnSelectMP.Name = "btnSelectMP";
            this.btnSelectMP.Size = new System.Drawing.Size(75, 23);
            this.btnSelectMP.TabIndex = 3;
            this.btnSelectMP.Text = "Consultar";
            this.btnSelectMP.UseVisualStyleBackColor = true;
            // 
            // VentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 547);
            this.Controls.Add(this.dgvFP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabTU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentaForm";
            this.Text = "VentaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP)).EndInit();
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

        private System.Windows.Forms.DataGridView dgvFP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarMP;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TabControl tabTU;
        private System.Windows.Forms.TabPage tabInsertMP;
        private System.Windows.Forms.Button btnInsertMP;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox tbNombreMPInsert;
        private System.Windows.Forms.TextBox tbIdMPInsert;
        private System.Windows.Forms.TabPage tabModMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreMPMod;
        private System.Windows.Forms.TextBox tbIdMPMod;
        private System.Windows.Forms.Button btnModMP;
        private System.Windows.Forms.TabPage tabDropMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreMPDrop;
        private System.Windows.Forms.TextBox tbIdMPDrop;
        private System.Windows.Forms.Button btnDropMP;
        private System.Windows.Forms.TabPage tabSelectMP;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.ComboBox cbSelectFP;
        private System.Windows.Forms.Button btnSelectMP;
    }
}