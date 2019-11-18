namespace Inventario
{
    partial class Matriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matriz));
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_limp = new System.Windows.Forms.Button();
            this.matriz_2 = new System.Windows.Forms.Button();
            this.matriz_1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new Utilidades.label(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.label4 = new Utilidades.label(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cantp_txt = new System.Windows.Forms.TextBox();
            this.reslet_txt = new System.Windows.Forms.TextBox();
            this.rsult_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rsult_txt);
            this.panel1.Controls.Add(this.reslet_txt);
            this.panel1.Controls.Add(this.cantp_txt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.but_limp);
            this.panel1.Controls.Add(this.matriz_2);
            this.panel1.Controls.Add(this.matriz_1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 373);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // but_limp
            // 
            this.but_limp.Location = new System.Drawing.Point(404, 25);
            this.but_limp.Name = "but_limp";
            this.but_limp.Size = new System.Drawing.Size(77, 22);
            this.but_limp.TabIndex = 4;
            this.but_limp.Text = "LIMPIAR";
            this.but_limp.UseVisualStyleBackColor = true;
            this.but_limp.Click += new System.EventHandler(this.but_limp_Click);
            // 
            // matriz_2
            // 
            this.matriz_2.Location = new System.Drawing.Point(122, 231);
            this.matriz_2.Name = "matriz_2";
            this.matriz_2.Size = new System.Drawing.Size(97, 29);
            this.matriz_2.TabIndex = 3;
            this.matriz_2.Text = "Matriz 2";
            this.matriz_2.UseVisualStyleBackColor = true;
            this.matriz_2.Click += new System.EventHandler(this.matriz_2_Click);
            // 
            // matriz_1
            // 
            this.matriz_1.Location = new System.Drawing.Point(18, 231);
            this.matriz_1.Name = "matriz_1";
            this.matriz_1.Size = new System.Drawing.Size(98, 29);
            this.matriz_1.TabIndex = 2;
            this.matriz_1.Text = "Matriz 1";
            this.matriz_1.UseVisualStyleBackColor = true;
            this.matriz_1.Click += new System.EventHandler(this.matriz_1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(44, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(249, 128);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriz Impresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cant. Primo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result. Letras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "HABLAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cantp_txt
            // 
            this.cantp_txt.Location = new System.Drawing.Point(426, 64);
            this.cantp_txt.Name = "cantp_txt";
            this.cantp_txt.ReadOnly = true;
            this.cantp_txt.Size = new System.Drawing.Size(103, 20);
            this.cantp_txt.TabIndex = 9;
            // 
            // reslet_txt
            // 
            this.reslet_txt.Location = new System.Drawing.Point(426, 109);
            this.reslet_txt.Name = "reslet_txt";
            this.reslet_txt.ReadOnly = true;
            this.reslet_txt.Size = new System.Drawing.Size(103, 20);
            this.reslet_txt.TabIndex = 10;
            // 
            // rsult_txt
            // 
            this.rsult_txt.Location = new System.Drawing.Point(426, 154);
            this.rsult_txt.Name = "rsult_txt";
            this.rsult_txt.ReadOnly = true;
            this.rsult_txt.Size = new System.Drawing.Size(103, 20);
            this.rsult_txt.TabIndex = 11;
            // 
            // Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 429);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Matriz";
            this.Text = "Matriz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Utilidades.label label1;
        private System.Windows.Forms.Button matriz_2;
        private System.Windows.Forms.Button matriz_1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button but_limp;
        private System.Windows.Forms.TextBox rsult_txt;
        private System.Windows.Forms.TextBox reslet_txt;
        private System.Windows.Forms.TextBox cantp_txt;
        private System.Windows.Forms.Button button1;
        private Utilidades.label label4;
        private Utilidades.label label3;
        private Utilidades.label label2;
    }
}