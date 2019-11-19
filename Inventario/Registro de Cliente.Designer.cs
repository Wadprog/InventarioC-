namespace Inventario
{
    partial class Registro_de_Cliente
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textbox1 = new Utilidades.textbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textbox2 = new Utilidades.textbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textbox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(26, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 27);
            this.panel4.TabIndex = 4;
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(97, 2);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 20);
            this.textbox1.TabIndex = 4;
            this.textbox1.Validar = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textbox2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(26, 237);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 27);
            this.panel6.TabIndex = 5;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(97, 2);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(100, 20);
            this.textbox2.TabIndex = 4;
            this.textbox2.Validar = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Correo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Registro_de_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Name = "Registro_de_Cliente";
            this.Text = "Registro_de_Cliente";
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Utilidades.textbox textbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private Utilidades.textbox textbox2;
        private System.Windows.Forms.Label label4;
    }
}