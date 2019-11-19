namespace Inventario
{
    partial class EjpValidacion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_validar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.but_validar2 = new System.Windows.Forms.Button();
            this.textbox8 = new Utilidades.textbox(this.components);
            this.textbox4 = new Utilidades.textbox(this.components);
            this.textbox3 = new Utilidades.textbox(this.components);
            this.textbox2 = new Utilidades.textbox(this.components);
            this.textbox1 = new Utilidades.textbox(this.components);
            this.textbox7 = new Utilidades.textbox(this.components);
            this.textbox6 = new Utilidades.textbox(this.components);
            this.textbox5 = new Utilidades.textbox(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.textbox7);
            this.panel2.Controls.Add(this.textbox6);
            this.panel2.Controls.Add(this.textbox5);
            this.panel2.Location = new System.Drawing.Point(244, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 213);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // but_validar
            // 
            this.but_validar.Location = new System.Drawing.Point(190, 333);
            this.but_validar.Name = "but_validar";
            this.but_validar.Size = new System.Drawing.Size(154, 41);
            this.but_validar.TabIndex = 0;
            this.but_validar.Text = "Validar";
            this.but_validar.UseVisualStyleBackColor = true;
            this.but_validar.Click += new System.EventHandler(this.but_validar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // but_validar2
            // 
            this.but_validar2.Location = new System.Drawing.Point(37, 333);
            this.but_validar2.Name = "but_validar2";
            this.but_validar2.Size = new System.Drawing.Size(147, 41);
            this.but_validar2.TabIndex = 6;
            this.but_validar2.Text = "Validar 2";
            this.but_validar2.UseVisualStyleBackColor = true;
            this.but_validar2.Click += new System.EventHandler(this.but_validar2_Click);
            // 
            // textbox8
            // 
            this.textbox8.Location = new System.Drawing.Point(245, 291);
            this.textbox8.Name = "textbox8";
            this.textbox8.Size = new System.Drawing.Size(163, 20);
            this.textbox8.TabIndex = 7;
            this.textbox8.Validar = false;
            // 
            // textbox4
            // 
            this.textbox4.Location = new System.Drawing.Point(37, 274);
            this.textbox4.Multiline = true;
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(187, 37);
            this.textbox4.TabIndex = 5;
            this.textbox4.Validar = false;
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(37, 196);
            this.textbox3.Multiline = true;
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(187, 37);
            this.textbox3.TabIndex = 4;
            this.textbox3.Validar = true;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(37, 126);
            this.textbox2.Multiline = true;
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(187, 37);
            this.textbox2.TabIndex = 3;
            this.textbox2.Validar = true;
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(37, 52);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(187, 37);
            this.textbox1.TabIndex = 2;
            this.textbox1.Validar = true;
            // 
            // textbox7
            // 
            this.textbox7.Location = new System.Drawing.Point(0, 165);
            this.textbox7.Multiline = true;
            this.textbox7.Name = "textbox7";
            this.textbox7.Size = new System.Drawing.Size(187, 37);
            this.textbox7.TabIndex = 8;
            this.textbox7.Validar = false;
            // 
            // textbox6
            // 
            this.textbox6.Location = new System.Drawing.Point(1, 95);
            this.textbox6.Multiline = true;
            this.textbox6.Name = "textbox6";
            this.textbox6.Size = new System.Drawing.Size(187, 37);
            this.textbox6.TabIndex = 7;
            this.textbox6.Validar = true;
            // 
            // textbox5
            // 
            this.textbox5.Location = new System.Drawing.Point(0, 21);
            this.textbox5.Multiline = true;
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(187, 37);
            this.textbox5.TabIndex = 6;
            this.textbox5.Validar = false;
            // 
            // EjpValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.textbox8);
            this.Controls.Add(this.but_validar2);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.but_validar);
            this.Controls.Add(this.panel2);
            this.Name = "EjpValidacion";
            this.Text = "EjpValidacion";
            this.Load += new System.EventHandler(this.EjpValidacion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button but_validar;
        private Utilidades.textbox textbox7;
        private Utilidades.textbox textbox6;
        private Utilidades.textbox textbox5;
        private Utilidades.textbox textbox1;
        private Utilidades.textbox textbox2;
        private Utilidades.textbox textbox3;
        private Utilidades.textbox textbox4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button but_validar2;
        private Utilidades.textbox textbox8;
    }
}