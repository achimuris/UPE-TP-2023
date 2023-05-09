namespace GUIEmpresaDeMudanza
{
    partial class Form1
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
            this.btnAgregarAlCamion = new System.Windows.Forms.Button();
            this.lboxMediosDeTransportes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxEmpleados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreObjeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxEsFragil = new System.Windows.Forms.CheckBox();
            this.nudAlto = new System.Windows.Forms.NumericUpDown();
            this.nudLargo = new System.Windows.Forms.NumericUpDown();
            this.nudAncho = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.btnMostrarObjetosDelCamion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAlCamion
            // 
            this.btnAgregarAlCamion.Location = new System.Drawing.Point(159, 360);
            this.btnAgregarAlCamion.Name = "btnAgregarAlCamion";
            this.btnAgregarAlCamion.Size = new System.Drawing.Size(166, 32);
            this.btnAgregarAlCamion.TabIndex = 0;
            this.btnAgregarAlCamion.Text = "Agregar al camión";
            this.btnAgregarAlCamion.UseVisualStyleBackColor = true;
            this.btnAgregarAlCamion.Click += new System.EventHandler(this.btnAgregarAlCamion_Click);
            // 
            // lboxMediosDeTransportes
            // 
            this.lboxMediosDeTransportes.FormattingEnabled = true;
            this.lboxMediosDeTransportes.Location = new System.Drawing.Point(23, 60);
            this.lboxMediosDeTransportes.Name = "lboxMediosDeTransportes";
            this.lboxMediosDeTransportes.Size = new System.Drawing.Size(263, 95);
            this.lboxMediosDeTransportes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medios de transporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // lboxEmpleados
            // 
            this.lboxEmpleados.FormattingEnabled = true;
            this.lboxEmpleados.Location = new System.Drawing.Point(472, 60);
            this.lboxEmpleados.Name = "lboxEmpleados";
            this.lboxEmpleados.Size = new System.Drawing.Size(252, 95);
            this.lboxEmpleados.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // txtNombreObjeto
            // 
            this.txtNombreObjeto.Location = new System.Drawing.Point(81, 180);
            this.txtNombreObjeto.Name = "txtNombreObjeto";
            this.txtNombreObjeto.Size = new System.Drawing.Size(120, 20);
            this.txtNombreObjeto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Largo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ancho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Peso";
            // 
            // cboxEsFragil
            // 
            this.cboxEsFragil.AutoSize = true;
            this.cboxEsFragil.Location = new System.Drawing.Point(37, 317);
            this.cboxEsFragil.Name = "cboxEsFragil";
            this.cboxEsFragil.Size = new System.Drawing.Size(75, 17);
            this.cboxEsFragil.TabIndex = 12;
            this.cboxEsFragil.Text = "¿Es fragil?";
            this.cboxEsFragil.UseVisualStyleBackColor = true;
            // 
            // nudAlto
            // 
            this.nudAlto.Location = new System.Drawing.Point(81, 210);
            this.nudAlto.Name = "nudAlto";
            this.nudAlto.Size = new System.Drawing.Size(120, 20);
            this.nudAlto.TabIndex = 13;
            // 
            // nudLargo
            // 
            this.nudLargo.Location = new System.Drawing.Point(81, 236);
            this.nudLargo.Name = "nudLargo";
            this.nudLargo.Size = new System.Drawing.Size(120, 20);
            this.nudLargo.TabIndex = 14;
            // 
            // nudAncho
            // 
            this.nudAncho.Location = new System.Drawing.Point(81, 262);
            this.nudAncho.Name = "nudAncho";
            this.nudAncho.Size = new System.Drawing.Size(120, 20);
            this.nudAncho.TabIndex = 15;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(81, 291);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(120, 20);
            this.nudPeso.TabIndex = 16;
            // 
            // btnMostrarObjetosDelCamion
            // 
            this.btnMostrarObjetosDelCamion.Location = new System.Drawing.Point(472, 215);
            this.btnMostrarObjetosDelCamion.Name = "btnMostrarObjetosDelCamion";
            this.btnMostrarObjetosDelCamion.Size = new System.Drawing.Size(230, 84);
            this.btnMostrarObjetosDelCamion.TabIndex = 17;
            this.btnMostrarObjetosDelCamion.Text = "Mostrar objetos del camión";
            this.btnMostrarObjetosDelCamion.UseVisualStyleBackColor = true;
            this.btnMostrarObjetosDelCamion.Click += new System.EventHandler(this.btnMostrarObjetosDelCamion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarObjetosDelCamion);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.nudAncho);
            this.Controls.Add(this.nudLargo);
            this.Controls.Add(this.nudAlto);
            this.Controls.Add(this.cboxEsFragil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreObjeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxMediosDeTransportes);
            this.Controls.Add(this.btnAgregarAlCamion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAlCamion;
        private System.Windows.Forms.ListBox lboxMediosDeTransportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreObjeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cboxEsFragil;
        private System.Windows.Forms.NumericUpDown nudAlto;
        private System.Windows.Forms.NumericUpDown nudLargo;
        private System.Windows.Forms.NumericUpDown nudAncho;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Button btnMostrarObjetosDelCamion;
    }
}

