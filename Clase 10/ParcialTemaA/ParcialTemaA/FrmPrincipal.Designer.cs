namespace ParcialTemaA
{
    partial class FrmPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.lboxVehiculosParaVender = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCotizacionDolar = new System.Windows.Forms.NumericUpDown();
            this.cboxAdicionales = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCotizacionDolar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular Precio Vehiculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lboxVehiculosParaVender
            // 
            this.lboxVehiculosParaVender.FormattingEnabled = true;
            this.lboxVehiculosParaVender.Location = new System.Drawing.Point(61, 52);
            this.lboxVehiculosParaVender.Name = "lboxVehiculosParaVender";
            this.lboxVehiculosParaVender.Size = new System.Drawing.Size(477, 95);
            this.lboxVehiculosParaVender.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autos a vender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cotización del día";
            // 
            // nudCotizacionDolar
            // 
            this.nudCotizacionDolar.Location = new System.Drawing.Point(174, 161);
            this.nudCotizacionDolar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCotizacionDolar.Name = "nudCotizacionDolar";
            this.nudCotizacionDolar.Size = new System.Drawing.Size(120, 20);
            this.nudCotizacionDolar.TabIndex = 4;
            // 
            // cboxAdicionales
            // 
            this.cboxAdicionales.FormattingEnabled = true;
            this.cboxAdicionales.Location = new System.Drawing.Point(418, 183);
            this.cboxAdicionales.Name = "cboxAdicionales";
            this.cboxAdicionales.Size = new System.Drawing.Size(338, 94);
            this.cboxAdicionales.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxAdicionales);
            this.Controls.Add(this.nudCotizacionDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxVehiculosParaVender);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCotizacionDolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lboxVehiculosParaVender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCotizacionDolar;
        private System.Windows.Forms.CheckedListBox cboxAdicionales;
    }
}

