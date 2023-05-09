namespace GUIEmpresaDeMudanza
{
    partial class FormularioMostrarObjetosDelCamion
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
            this.grillaDeObjetosDelCamion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeObjetosDelCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDeObjetosDelCamion
            // 
            this.grillaDeObjetosDelCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDeObjetosDelCamion.Location = new System.Drawing.Point(13, 12);
            this.grillaDeObjetosDelCamion.Name = "grillaDeObjetosDelCamion";
            this.grillaDeObjetosDelCamion.Size = new System.Drawing.Size(775, 390);
            this.grillaDeObjetosDelCamion.TabIndex = 0;
            // 
            // MostrarObjetosDelCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grillaDeObjetosDelCamion);
            this.Name = "MostrarObjetosDelCamion";
            this.Text = "MostrarObjetosDelCamion";
            this.Load += new System.EventHandler(this.MostrarObjetosDelCamion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeObjetosDelCamion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaDeObjetosDelCamion;
    }
}