namespace MiAppConORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMaterias = new DataGridView();
            btnObtenerMateriaPorId = new Button();
            txtIdMateria = new TextBox();
            btnAgregaNuevaMateria = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // dgvMaterias
            // 
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new Point(12, 32);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new Size(776, 154);
            dgvMaterias.TabIndex = 0;
            // 
            // btnObtenerMateriaPorId
            // 
            btnObtenerMateriaPorId.Location = new Point(300, 332);
            btnObtenerMateriaPorId.Name = "btnObtenerMateriaPorId";
            btnObtenerMateriaPorId.Size = new Size(237, 23);
            btnObtenerMateriaPorId.TabIndex = 1;
            btnObtenerMateriaPorId.Text = "Obtener materia por ID";
            btnObtenerMateriaPorId.UseVisualStyleBackColor = true;
            btnObtenerMateriaPorId.Click += btnObtenerMateriaPorId_Click;
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new Point(63, 332);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new Size(100, 23);
            txtIdMateria.TabIndex = 2;
            // 
            // btnAgregaNuevaMateria
            // 
            btnAgregaNuevaMateria.Location = new Point(282, 214);
            btnAgregaNuevaMateria.Name = "btnAgregaNuevaMateria";
            btnAgregaNuevaMateria.Size = new Size(237, 23);
            btnAgregaNuevaMateria.TabIndex = 3;
            btnAgregaNuevaMateria.Text = "Agrega SW y Los Nuevos Escenarios";
            btnAgregaNuevaMateria.UseVisualStyleBackColor = true;
            btnAgregaNuevaMateria.Click += btnAgregaNuevaMateria_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregaNuevaMateria);
            Controls.Add(txtIdMateria);
            Controls.Add(btnObtenerMateriaPorId);
            Controls.Add(dgvMaterias);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMaterias;
        private Button btnObtenerMateriaPorId;
        private TextBox txtIdMateria;
        private Button btnAgregaNuevaMateria;
    }
}