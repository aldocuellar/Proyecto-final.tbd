namespace Proyecto_Final.tbd
{
    partial class EntradasForm
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
            this.btnCerrarVenta = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.tabTU = new System.Windows.Forms.TabControl();
            this.tabInsertV = new System.Windows.Forms.TabPage();
            this.cbIdPEInsert = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertE = new System.Windows.Forms.Button();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblTicketVenta = new System.Windows.Forms.Label();
            this.tbTotalVentaInsert = new System.Windows.Forms.TextBox();
            this.tbFolioInsert = new System.Windows.Forms.TextBox();
            this.tabModV = new System.Windows.Forms.TabPage();
            this.cbIdUVMod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHoraVentaMod = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVentaMod = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTotalVentaMod = new System.Windows.Forms.TextBox();
            this.tbTicketVentaMod = new System.Windows.Forms.TextBox();
            this.btnModV = new System.Windows.Forms.Button();
            this.tabDropV = new System.Windows.Forms.TabPage();
            this.cbIdUVDrop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpHoraVentaDrop = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVentaDrop = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTotalVentaDrop = new System.Windows.Forms.TextBox();
            this.tbTicketVentaDrop = new System.Windows.Forms.TextBox();
            this.btnDropV = new System.Windows.Forms.Button();
            this.tabSelectV = new System.Windows.Forms.TabPage();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.cbSelectIdUV = new System.Windows.Forms.ComboBox();
            this.btnSelectV = new System.Windows.Forms.Button();
            this.dtpEntradasInsert = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabTU.SuspendLayout();
            this.tabInsertV.SuspendLayout();
            this.tabModV.SuspendLayout();
            this.tabDropV.SuspendLayout();
            this.tabSelectV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFP
            // 
            this.dgvFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFP.Location = new System.Drawing.Point(4, 396);
            this.dgvFP.Name = "dgvFP";
            this.dgvFP.Size = new System.Drawing.Size(769, 150);
            this.dgvFP.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarVenta);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 48);
            this.panel1.TabIndex = 17;
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarVenta.Location = new System.Drawing.Point(1, 0);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(41, 41);
            this.btnCerrarVenta.TabIndex = 3;
            this.btnCerrarVenta.Text = "X";
            this.btnCerrarVenta.UseVisualStyleBackColor = false;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(334, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(92, 24);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Entradas";
            // 
            // tabTU
            // 
            this.tabTU.Controls.Add(this.tabInsertV);
            this.tabTU.Controls.Add(this.tabModV);
            this.tabTU.Controls.Add(this.tabDropV);
            this.tabTU.Controls.Add(this.tabSelectV);
            this.tabTU.Location = new System.Drawing.Point(0, 57);
            this.tabTU.Name = "tabTU";
            this.tabTU.SelectedIndex = 0;
            this.tabTU.Size = new System.Drawing.Size(777, 337);
            this.tabTU.TabIndex = 16;
            // 
            // tabInsertV
            // 
            this.tabInsertV.Controls.Add(this.textBox1);
            this.tabInsertV.Controls.Add(this.dtpEntradasInsert);
            this.tabInsertV.Controls.Add(this.cbIdPEInsert);
            this.tabInsertV.Controls.Add(this.label7);
            this.tabInsertV.Controls.Add(this.label6);
            this.tabInsertV.Controls.Add(this.label5);
            this.tabInsertV.Controls.Add(this.btnInsertE);
            this.tabInsertV.Controls.Add(this.lblNombreDeUsuario);
            this.tabInsertV.Controls.Add(this.lblTicketVenta);
            this.tabInsertV.Controls.Add(this.tbTotalVentaInsert);
            this.tabInsertV.Controls.Add(this.tbFolioInsert);
            this.tabInsertV.Location = new System.Drawing.Point(4, 22);
            this.tabInsertV.Name = "tabInsertV";
            this.tabInsertV.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertV.Size = new System.Drawing.Size(769, 311);
            this.tabInsertV.TabIndex = 0;
            this.tabInsertV.Text = "Insertar";
            this.tabInsertV.UseVisualStyleBackColor = true;
            // 
            // cbIdPEInsert
            // 
            this.cbIdPEInsert.FormattingEnabled = true;
            this.cbIdPEInsert.Location = new System.Drawing.Point(269, 96);
            this.cbIdPEInsert.Name = "cbIdPEInsert";
            this.cbIdPEInsert.Size = new System.Drawing.Size(58, 21);
            this.cbIdPEInsert.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cantidad";
            // 
            // btnInsertE
            // 
            this.btnInsertE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertE.Location = new System.Drawing.Point(312, 228);
            this.btnInsertE.Name = "btnInsertE";
            this.btnInsertE.Size = new System.Drawing.Size(135, 36);
            this.btnInsertE.TabIndex = 38;
            this.btnInsertE.Text = "Insertar Datos";
            this.btnInsertE.UseVisualStyleBackColor = true;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(268, 80);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(62, 13);
            this.lblNombreDeUsuario.TabIndex = 29;
            this.lblNombreDeUsuario.Text = "Id Producto";
            // 
            // lblTicketVenta
            // 
            this.lblTicketVenta.AutoSize = true;
            this.lblTicketVenta.Location = new System.Drawing.Point(355, 18);
            this.lblTicketVenta.Name = "lblTicketVenta";
            this.lblTicketVenta.Size = new System.Drawing.Size(41, 13);
            this.lblTicketVenta.TabIndex = 28;
            this.lblTicketVenta.Text = "Id Folio";
            // 
            // tbTotalVentaInsert
            // 
            this.tbTotalVentaInsert.Location = new System.Drawing.Point(428, 96);
            this.tbTotalVentaInsert.Name = "tbTotalVentaInsert";
            this.tbTotalVentaInsert.Size = new System.Drawing.Size(58, 20);
            this.tbTotalVentaInsert.TabIndex = 23;
            // 
            // tbFolioInsert
            // 
            this.tbFolioInsert.Location = new System.Drawing.Point(346, 34);
            this.tbFolioInsert.Name = "tbFolioInsert";
            this.tbFolioInsert.Size = new System.Drawing.Size(58, 20);
            this.tbFolioInsert.TabIndex = 22;
            // 
            // tabModV
            // 
            this.tabModV.Controls.Add(this.cbIdUVMod);
            this.tabModV.Controls.Add(this.label1);
            this.tabModV.Controls.Add(this.label2);
            this.tabModV.Controls.Add(this.label8);
            this.tabModV.Controls.Add(this.dtpHoraVentaMod);
            this.tabModV.Controls.Add(this.dtpFechaVentaMod);
            this.tabModV.Controls.Add(this.label9);
            this.tabModV.Controls.Add(this.label10);
            this.tabModV.Controls.Add(this.tbTotalVentaMod);
            this.tabModV.Controls.Add(this.tbTicketVentaMod);
            this.tabModV.Controls.Add(this.btnModV);
            this.tabModV.Location = new System.Drawing.Point(4, 22);
            this.tabModV.Name = "tabModV";
            this.tabModV.Padding = new System.Windows.Forms.Padding(3);
            this.tabModV.Size = new System.Drawing.Size(769, 311);
            this.tabModV.TabIndex = 1;
            this.tabModV.Text = "Modificar";
            this.tabModV.UseVisualStyleBackColor = true;
            // 
            // cbIdUVMod
            // 
            this.cbIdUVMod.FormattingEnabled = true;
            this.cbIdUVMod.Location = new System.Drawing.Point(430, 161);
            this.cbIdUVMod.Name = "cbIdUVMod";
            this.cbIdUVMod.Size = new System.Drawing.Size(58, 21);
            this.cbIdUVMod.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Id Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Hora";
            // 
            // dtpHoraVentaMod
            // 
            this.dtpHoraVentaMod.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraVentaMod.Location = new System.Drawing.Point(414, 98);
            this.dtpHoraVentaMod.Name = "dtpHoraVentaMod";
            this.dtpHoraVentaMod.Size = new System.Drawing.Size(91, 20);
            this.dtpHoraVentaMod.TabIndex = 61;
            // 
            // dtpFechaVentaMod
            // 
            this.dtpFechaVentaMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVentaMod.Location = new System.Drawing.Point(251, 161);
            this.dtpFechaVentaMod.Name = "dtpFechaVentaMod";
            this.dtpFechaVentaMod.Size = new System.Drawing.Size(91, 20);
            this.dtpFechaVentaMod.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Ticket Venta";
            // 
            // tbTotalVentaMod
            // 
            this.tbTotalVentaMod.Location = new System.Drawing.Point(269, 98);
            this.tbTotalVentaMod.Name = "tbTotalVentaMod";
            this.tbTotalVentaMod.Size = new System.Drawing.Size(58, 20);
            this.tbTotalVentaMod.TabIndex = 57;
            // 
            // tbTicketVentaMod
            // 
            this.tbTicketVentaMod.Location = new System.Drawing.Point(349, 36);
            this.tbTicketVentaMod.Name = "tbTicketVentaMod";
            this.tbTicketVentaMod.Size = new System.Drawing.Size(58, 20);
            this.tbTicketVentaMod.TabIndex = 56;
            // 
            // btnModV
            // 
            this.btnModV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModV.Location = new System.Drawing.Point(316, 228);
            this.btnModV.Name = "btnModV";
            this.btnModV.Size = new System.Drawing.Size(135, 36);
            this.btnModV.TabIndex = 55;
            this.btnModV.Text = "Modificar Datos";
            this.btnModV.UseVisualStyleBackColor = true;
            // 
            // tabDropV
            // 
            this.tabDropV.Controls.Add(this.cbIdUVDrop);
            this.tabDropV.Controls.Add(this.label3);
            this.tabDropV.Controls.Add(this.label4);
            this.tabDropV.Controls.Add(this.label11);
            this.tabDropV.Controls.Add(this.dtpHoraVentaDrop);
            this.tabDropV.Controls.Add(this.dtpFechaVentaDrop);
            this.tabDropV.Controls.Add(this.label12);
            this.tabDropV.Controls.Add(this.label13);
            this.tabDropV.Controls.Add(this.tbTotalVentaDrop);
            this.tabDropV.Controls.Add(this.tbTicketVentaDrop);
            this.tabDropV.Controls.Add(this.btnDropV);
            this.tabDropV.Location = new System.Drawing.Point(4, 22);
            this.tabDropV.Name = "tabDropV";
            this.tabDropV.Size = new System.Drawing.Size(769, 311);
            this.tabDropV.TabIndex = 2;
            this.tabDropV.Text = "Eliminar";
            this.tabDropV.UseVisualStyleBackColor = true;
            // 
            // cbIdUVDrop
            // 
            this.cbIdUVDrop.FormattingEnabled = true;
            this.cbIdUVDrop.Location = new System.Drawing.Point(431, 158);
            this.cbIdUVDrop.Name = "cbIdUVDrop";
            this.cbIdUVDrop.Size = new System.Drawing.Size(58, 21);
            this.cbIdUVDrop.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Id Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Hora";
            // 
            // dtpHoraVentaDrop
            // 
            this.dtpHoraVentaDrop.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraVentaDrop.Location = new System.Drawing.Point(415, 95);
            this.dtpHoraVentaDrop.Name = "dtpHoraVentaDrop";
            this.dtpHoraVentaDrop.Size = new System.Drawing.Size(91, 20);
            this.dtpHoraVentaDrop.TabIndex = 61;
            // 
            // dtpFechaVentaDrop
            // 
            this.dtpFechaVentaDrop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVentaDrop.Location = new System.Drawing.Point(252, 158);
            this.dtpFechaVentaDrop.Name = "dtpFechaVentaDrop";
            this.dtpFechaVentaDrop.Size = new System.Drawing.Size(91, 20);
            this.dtpFechaVentaDrop.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Ticket Venta";
            // 
            // tbTotalVentaDrop
            // 
            this.tbTotalVentaDrop.Location = new System.Drawing.Point(270, 95);
            this.tbTotalVentaDrop.Name = "tbTotalVentaDrop";
            this.tbTotalVentaDrop.Size = new System.Drawing.Size(58, 20);
            this.tbTotalVentaDrop.TabIndex = 57;
            // 
            // tbTicketVentaDrop
            // 
            this.tbTicketVentaDrop.Location = new System.Drawing.Point(350, 33);
            this.tbTicketVentaDrop.Name = "tbTicketVentaDrop";
            this.tbTicketVentaDrop.Size = new System.Drawing.Size(58, 20);
            this.tbTicketVentaDrop.TabIndex = 56;
            // 
            // btnDropV
            // 
            this.btnDropV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropV.Location = new System.Drawing.Point(306, 224);
            this.btnDropV.Name = "btnDropV";
            this.btnDropV.Size = new System.Drawing.Size(135, 36);
            this.btnDropV.TabIndex = 55;
            this.btnDropV.Text = "Eliminar Datos";
            this.btnDropV.UseVisualStyleBackColor = true;
            // 
            // tabSelectV
            // 
            this.tabSelectV.Controls.Add(this.lblConsulta);
            this.tabSelectV.Controls.Add(this.cbSelectIdUV);
            this.tabSelectV.Controls.Add(this.btnSelectV);
            this.tabSelectV.Location = new System.Drawing.Point(4, 22);
            this.tabSelectV.Name = "tabSelectV";
            this.tabSelectV.Size = new System.Drawing.Size(769, 311);
            this.tabSelectV.TabIndex = 3;
            this.tabSelectV.Text = "Consultar";
            this.tabSelectV.UseVisualStyleBackColor = true;
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
            // cbSelectIdUV
            // 
            this.cbSelectIdUV.FormattingEnabled = true;
            this.cbSelectIdUV.Location = new System.Drawing.Point(320, 128);
            this.cbSelectIdUV.Name = "cbSelectIdUV";
            this.cbSelectIdUV.Size = new System.Drawing.Size(121, 21);
            this.cbSelectIdUV.TabIndex = 4;
            // 
            // btnSelectV
            // 
            this.btnSelectV.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSelectV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectV.Location = new System.Drawing.Point(344, 188);
            this.btnSelectV.Name = "btnSelectV";
            this.btnSelectV.Size = new System.Drawing.Size(75, 23);
            this.btnSelectV.TabIndex = 3;
            this.btnSelectV.Text = "Consultar";
            this.btnSelectV.UseVisualStyleBackColor = true;
            // 
            // dtpEntradasInsert
            // 
            this.dtpEntradasInsert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntradasInsert.Location = new System.Drawing.Point(411, 159);
            this.dtpEntradasInsert.Name = "dtpEntradasInsert";
            this.dtpEntradasInsert.Size = new System.Drawing.Size(96, 20);
            this.dtpEntradasInsert.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 47;
            // 
            // EntradasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 547);
            this.Controls.Add(this.dgvFP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabTU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntradasForm";
            this.Text = "EntradasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTU.ResumeLayout(false);
            this.tabInsertV.ResumeLayout(false);
            this.tabInsertV.PerformLayout();
            this.tabModV.ResumeLayout(false);
            this.tabModV.PerformLayout();
            this.tabDropV.ResumeLayout(false);
            this.tabDropV.PerformLayout();
            this.tabSelectV.ResumeLayout(false);
            this.tabSelectV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarVenta;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TabControl tabTU;
        private System.Windows.Forms.TabPage tabInsertV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpEntradasInsert;
        private System.Windows.Forms.ComboBox cbIdPEInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertE;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Label lblTicketVenta;
        private System.Windows.Forms.TextBox tbTotalVentaInsert;
        private System.Windows.Forms.TextBox tbFolioInsert;
        private System.Windows.Forms.TabPage tabModV;
        private System.Windows.Forms.ComboBox cbIdUVMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHoraVentaMod;
        private System.Windows.Forms.DateTimePicker dtpFechaVentaMod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTotalVentaMod;
        private System.Windows.Forms.TextBox tbTicketVentaMod;
        private System.Windows.Forms.Button btnModV;
        private System.Windows.Forms.TabPage tabDropV;
        private System.Windows.Forms.ComboBox cbIdUVDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpHoraVentaDrop;
        private System.Windows.Forms.DateTimePicker dtpFechaVentaDrop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTotalVentaDrop;
        private System.Windows.Forms.TextBox tbTicketVentaDrop;
        private System.Windows.Forms.Button btnDropV;
        private System.Windows.Forms.TabPage tabSelectV;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.ComboBox cbSelectIdUV;
        private System.Windows.Forms.Button btnSelectV;
    }
}