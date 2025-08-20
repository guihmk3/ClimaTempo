namespace ClimaTempo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblClima = new System.Windows.Forms.Label();
            this.txbTemp = new System.Windows.Forms.TextBox();
            this.btnVerificador = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.pibClima = new System.Windows.Forms.PictureBox();
            this.lblDia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibClima)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClima
            // 
            this.lblClima.AutoSize = true;
            this.lblClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClima.Location = new System.Drawing.Point(60, 53);
            this.lblClima.Name = "lblClima";
            this.lblClima.Size = new System.Drawing.Size(252, 24);
            this.lblClima.TabIndex = 0;
            this.lblClima.Text = "Digite a temperatua em °C";
            // 
            // txbTemp
            // 
            this.txbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTemp.Location = new System.Drawing.Point(115, 105);
            this.txbTemp.Name = "txbTemp";
            this.txbTemp.Size = new System.Drawing.Size(123, 29);
            this.txbTemp.TabIndex = 1;
            this.txbTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTemp_KeyDown);
            this.txbTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTemp_KeyPress);
            // 
            // btnVerificador
            // 
            this.btnVerificador.BackColor = System.Drawing.Color.Lime;
            this.btnVerificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerificador.Location = new System.Drawing.Point(64, 167);
            this.btnVerificador.Name = "btnVerificador";
            this.btnVerificador.Size = new System.Drawing.Size(249, 91);
            this.btnVerificador.TabIndex = 2;
            this.btnVerificador.Text = "Verificar";
            this.btnVerificador.UseVisualStyleBackColor = false;
            this.btnVerificador.Click += new System.EventHandler(this.btnVerificador_Click);
            this.btnVerificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTemp_KeyPress);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(244, 105);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(47, 31);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "°C";
            // 
            // pibClima
            // 
            this.pibClima.Location = new System.Drawing.Point(12, 264);
            this.pibClima.Name = "pibClima";
            this.pibClima.Size = new System.Drawing.Size(363, 174);
            this.pibClima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibClima.TabIndex = 4;
            this.pibClima.TabStop = false;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(21, 139);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(72, 25);
            this.lblDia.TabIndex = 5;
            this.lblDia.Text = "DATA\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.pibClima);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.btnVerificador);
            this.Controls.Add(this.txbTemp);
            this.Controls.Add(this.lblClima);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Verificador De Clima";
            ((System.ComponentModel.ISupportInitialize)(this.pibClima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClima;
        private System.Windows.Forms.TextBox txbTemp;
        private System.Windows.Forms.Button btnVerificador;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.PictureBox pibClima;
        private System.Windows.Forms.Label lblDia;
    }
}

