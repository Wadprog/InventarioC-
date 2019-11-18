namespace Inventario
{
    partial class Reportes
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
            this.but_imprimir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_imprimir);
            this.panel1.Size = new System.Drawing.Size(681, 66);
            this.panel1.Controls.SetChildIndex(this.btn_salir1, 0);
            this.panel1.Controls.SetChildIndex(this.but_imprimir, 0);
            // 
            // btn_salir1
            // 
            this.btn_salir1.Location = new System.Drawing.Point(353, 13);
            this.btn_salir1.Size = new System.Drawing.Size(114, 31);
            this.btn_salir1.Click += new System.EventHandler(this.btn_salir1_Click);
            // 
            // but_imprimir
            // 
            this.but_imprimir.Location = new System.Drawing.Point(100, 12);
            this.but_imprimir.Name = "but_imprimir";
            this.but_imprimir.Size = new System.Drawing.Size(99, 33);
            this.but_imprimir.TabIndex = 1;
            this.but_imprimir.Text = "Imprimir";
            this.but_imprimir.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 444);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_imprimir;
    }
}