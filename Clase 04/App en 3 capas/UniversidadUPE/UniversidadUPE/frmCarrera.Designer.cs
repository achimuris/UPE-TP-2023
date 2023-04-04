namespace UniversidadUPE
{
    partial class frmCarrera
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
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.btnMostrarID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Location = new System.Drawing.Point(12, 191);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.Size = new System.Drawing.Size(776, 247);
            this.dgvCarreras.TabIndex = 0;
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(526, 97);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(121, 21);
            this.cmbCarreras.TabIndex = 1;
            // 
            // btnMostrarID
            // 
            this.btnMostrarID.Location = new System.Drawing.Point(131, 95);
            this.btnMostrarID.Name = "btnMostrarID";
            this.btnMostrarID.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarID.TabIndex = 2;
            this.btnMostrarID.Text = "Mostrar ID";
            this.btnMostrarID.UseVisualStyleBackColor = true;
            this.btnMostrarID.Click += new System.EventHandler(this.btnMostrarID_Click);
            // 
            // frmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarID);
            this.Controls.Add(this.cmbCarreras);
            this.Controls.Add(this.dgvCarreras);
            this.Name = "frmCarrera";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Button btnMostrarID;
    }
}

