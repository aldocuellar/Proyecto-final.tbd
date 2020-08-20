namespace Proyecto_Final.tbd
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnTU = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pbLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.pbLogoLateral = new System.Windows.Forms.PictureBox();
            this.btnTP = new System.Windows.Forms.Button();
            this.btnFP = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnMP = new System.Windows.Forms.Button();
            this.btnDV = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.BarraSuperior.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLateral)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(214)))));
            this.BarraSuperior.Controls.Add(this.btnCerrar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(972, 37);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Location = new System.Drawing.Point(934, -3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 41);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.pbLogoPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(194, 43);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(777, 547);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(214)))));
            this.panelLateral.Controls.Add(this.pbLogoLateral);
            this.panelLateral.Controls.Add(this.panelBotones);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 37);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(196, 551);
            this.panelLateral.TabIndex = 2;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnEntradas);
            this.panelBotones.Controls.Add(this.btnDV);
            this.panelBotones.Controls.Add(this.btnMP);
            this.panelBotones.Controls.Add(this.btnVenta);
            this.panelBotones.Controls.Add(this.btnFP);
            this.panelBotones.Controls.Add(this.btnTP);
            this.panelBotones.Controls.Add(this.btnTU);
            this.panelBotones.Controls.Add(this.btnProductos);
            this.panelBotones.Controls.Add(this.btnUsuarios);
            this.panelBotones.Location = new System.Drawing.Point(3, 122);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(190, 422);
            this.panelBotones.TabIndex = 1;
            // 
            // btnTU
            // 
            this.btnTU.FlatAppearance.BorderSize = 0;
            this.btnTU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTU.ForeColor = System.Drawing.Color.White;
            this.btnTU.Location = new System.Drawing.Point(1, 4);
            this.btnTU.Name = "btnTU";
            this.btnTU.Size = new System.Drawing.Size(190, 40);
            this.btnTU.TabIndex = 1;
            this.btnTU.Text = "Tipo Usuario";
            this.btnTU.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(3, 234);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(190, 40);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(2, 188);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(190, 40);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pbLogoPrincipal
            // 
            this.pbLogoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoPrincipal.Image")));
            this.pbLogoPrincipal.Location = new System.Drawing.Point(229, 119);
            this.pbLogoPrincipal.Name = "pbLogoPrincipal";
            this.pbLogoPrincipal.Size = new System.Drawing.Size(290, 310);
            this.pbLogoPrincipal.TabIndex = 0;
            this.pbLogoPrincipal.TabStop = false;
            // 
            // pbLogoLateral
            // 
            this.pbLogoLateral.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoLateral.Image")));
            this.pbLogoLateral.Location = new System.Drawing.Point(39, 3);
            this.pbLogoLateral.Name = "pbLogoLateral";
            this.pbLogoLateral.Size = new System.Drawing.Size(119, 113);
            this.pbLogoLateral.TabIndex = 1;
            this.pbLogoLateral.TabStop = false;
            // 
            // btnTP
            // 
            this.btnTP.FlatAppearance.BorderSize = 0;
            this.btnTP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTP.ForeColor = System.Drawing.Color.White;
            this.btnTP.Location = new System.Drawing.Point(1, 50);
            this.btnTP.Name = "btnTP";
            this.btnTP.Size = new System.Drawing.Size(190, 40);
            this.btnTP.TabIndex = 2;
            this.btnTP.Text = "Tipo Producto";
            this.btnTP.UseVisualStyleBackColor = true;
            // 
            // btnFP
            // 
            this.btnFP.FlatAppearance.BorderSize = 0;
            this.btnFP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFP.ForeColor = System.Drawing.Color.White;
            this.btnFP.Location = new System.Drawing.Point(1, 97);
            this.btnFP.Name = "btnFP";
            this.btnFP.Size = new System.Drawing.Size(190, 40);
            this.btnFP.TabIndex = 3;
            this.btnFP.Text = "Familia";
            this.btnFP.UseVisualStyleBackColor = true;
            // 
            // btnVenta
            // 
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Location = new System.Drawing.Point(1, 280);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(190, 40);
            this.btnVenta.TabIndex = 4;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // btnMP
            // 
            this.btnMP.FlatAppearance.BorderSize = 0;
            this.btnMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMP.ForeColor = System.Drawing.Color.White;
            this.btnMP.Location = new System.Drawing.Point(1, 142);
            this.btnMP.Name = "btnMP";
            this.btnMP.Size = new System.Drawing.Size(190, 40);
            this.btnMP.TabIndex = 5;
            this.btnMP.Text = "Marca";
            this.btnMP.UseVisualStyleBackColor = true;
            // 
            // btnDV
            // 
            this.btnDV.FlatAppearance.BorderSize = 0;
            this.btnDV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDV.ForeColor = System.Drawing.Color.White;
            this.btnDV.Location = new System.Drawing.Point(3, 326);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(190, 40);
            this.btnDV.TabIndex = 6;
            this.btnDV.Text = "Detalle Venta";
            this.btnDV.UseVisualStyleBackColor = true;
            // 
            // btnEntradas
            // 
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.ForeColor = System.Drawing.Color.White;
            this.btnEntradas.Location = new System.Drawing.Point(1, 374);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(190, 40);
            this.btnEntradas.TabIndex = 7;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 588);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "t";
            this.BarraSuperior.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLateral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnTU;
        private System.Windows.Forms.PictureBox pbLogoPrincipal;
        private System.Windows.Forms.PictureBox pbLogoLateral;
        private System.Windows.Forms.Button btnTP;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnDV;
        private System.Windows.Forms.Button btnMP;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnFP;
    }
}

