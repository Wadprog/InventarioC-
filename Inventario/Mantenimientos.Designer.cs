namespace Inventario
{
    partial class Mantenimientos
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
            this.but_save = new System.Windows.Forms.Button();
            this.but_eliminar = new System.Windows.Forms.Button();
            this.but_Consult = new System.Windows.Forms.Button();
            this.but_limpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_limpiar);
            this.panel1.Controls.Add(this.but_Consult);
            this.panel1.Controls.Add(this.but_eliminar);
            this.panel1.Controls.Add(this.but_save);
            this.panel1.Size = new System.Drawing.Size(845, 77);
            this.panel1.Controls.SetChildIndex(this.btn_salir1, 0);
            this.panel1.Controls.SetChildIndex(this.but_save, 0);
            this.panel1.Controls.SetChildIndex(this.but_eliminar, 0);
            this.panel1.Controls.SetChildIndex(this.but_Consult, 0);
            this.panel1.Controls.SetChildIndex(this.but_limpiar, 0);
            // 
            // btn_salir1
            // 
            this.btn_salir1.Location = new System.Drawing.Point(728, 12);
            this.btn_salir1.Size = new System.Drawing.Size(94, 49);
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(37, 23);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(127, 37);
            this.but_save.TabIndex = 1;
            this.but_save.Text = "Salvar";
            this.but_save.UseVisualStyleBackColor = true;
            // 
            // but_eliminar
            // 
            this.but_eliminar.Location = new System.Drawing.Point(227, 26);
            this.but_eliminar.Name = "but_eliminar";
            this.but_eliminar.Size = new System.Drawing.Size(118, 34);
            this.but_eliminar.TabIndex = 2;
            this.but_eliminar.Text = "Eliminar";
            this.but_eliminar.UseVisualStyleBackColor = true;
            // 
            // but_Consult
            // 
            this.but_Consult.Location = new System.Drawing.Point(399, 26);
            this.but_Consult.Name = "but_Consult";
            this.but_Consult.Size = new System.Drawing.Size(117, 34);
            this.but_Consult.TabIndex = 3;
            this.but_Consult.Text = "Consultar";
            this.but_Consult.UseVisualStyleBackColor = true;
            // 
            // but_limpiar
            // 
            this.but_limpiar.Location = new System.Drawing.Point(563, 22);
            this.but_limpiar.Name = "but_limpiar";
            this.but_limpiar.Size = new System.Drawing.Size(112, 29);
            this.but_limpiar.TabIndex = 4;
            this.but_limpiar.Text = "Limpiar";
            this.but_limpiar.UseVisualStyleBackColor = true;
            // 
            // Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 498);
            this.Name = "Mantenimientos";
            this.Text = "Mantenimientos";
            this.Load += new System.EventHandler(this.Mantenimientos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_limpiar;
        private System.Windows.Forms.Button but_Consult;
        private System.Windows.Forms.Button but_eliminar;
        private System.Windows.Forms.Button but_save;
    }
}