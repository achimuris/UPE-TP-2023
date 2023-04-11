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
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.btnMostrarID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearMateria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(12, 191);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(776, 247);
            this.dgvMaterias.TabIndex = 0;
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(526, 97);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(121, 21);
            this.cmbCarreras.TabIndex = 1;
            this.cmbCarreras.SelectedIndexChanged += new System.EventHandler(this.cmbCarreras_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materias de la carrera";
            // 
            // btnCrearMateria
            // 
            this.btnCrearMateria.Location = new System.Drawing.Point(443, 150);
            this.btnCrearMateria.Name = "btnCrearMateria";
            this.btnCrearMateria.Size = new System.Drawing.Size(111, 23);
            this.btnCrearMateria.TabIndex = 4;
            this.btnCrearMateria.Text = "Crear Materia";
            this.btnCrearMateria.UseVisualStyleBackColor = true;
            this.btnCrearMateria.Click += new System.EventHandler(this.btnCrearMateria_Click);
            // 
            // frmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarID);
            this.Controls.Add(this.cmbCarreras);
            this.Controls.Add(this.dgvMaterias);
            this.Name = "frmCarrera";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Button btnMostrarID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearMateria;
    }
}

