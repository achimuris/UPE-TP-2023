namespace ParcialTemaA
{
    partial class FrmDetalleVenta
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
            this.dgvAdicionales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioEnDolares = new System.Windows.Forms.TextBox();
            this.txtPrecioEnPesos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorFinalEnPesos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdicionales
            // 
            this.dgvAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionales.Location = new System.Drawing.Point(12, 93);
            this.dgvAdicionales.Name = "dgvAdicionales";
            this.dgvAdicionales.Size = new System.Drawing.Size(776, 150);
            this.dgvAdicionales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio en Dolares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio en Pesos";
            // 
            // txtPrecioEnDolares
            // 
            this.txtPrecioEnDolares.Location = new System.Drawing.Point(111, 39);
            this.txtPrecioEnDolares.Name = "txtPrecioEnDolares";
            this.txtPrecioEnDolares.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioEnDolares.TabIndex = 4;
            // 
            // txtPrecioEnPesos
            // 
            this.txtPrecioEnPesos.Location = new System.Drawing.Point(416, 36);
            this.txtPrecioEnPesos.Name = "txtPrecioEnPesos";
            this.txtPrecioEnPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioEnPesos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor final:";
            // 
            // txtValorFinalEnPesos
            // 
            this.txtValorFinalEnPesos.Location = new System.Drawing.Point(99, 313);
            this.txtValorFinalEnPesos.Name = "txtValorFinalEnPesos";
            this.txtValorFinalEnPesos.Size = new System.Drawing.Size(100, 20);
            this.txtValorFinalEnPesos.TabIndex = 7;
            // 
            // FrmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValorFinalEnPesos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioEnPesos);
            this.Controls.Add(this.txtPrecioEnDolares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAdicionales);
            this.Name = "FrmDetalleVenta";
            this.Text = "FrmDetalleVenta";
            this.Load += new System.EventHandler(this.FrmDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdicionales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioEnDolares;
        private System.Windows.Forms.TextBox txtPrecioEnPesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorFinalEnPesos;
    }
}