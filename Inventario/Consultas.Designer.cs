namespace Inventario
{
    partial class Consultas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new Utilidades.label(this.components);
            this.textbox1 = new Utilidades.textbox(this.components);
            this.but_select = new System.Windows.Forms.Button();
            this.but_buscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_buscar);
            this.panel1.Controls.Add(this.but_select);
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.Controls.SetChildIndex(this.btn_salir1, 0);
            this.panel1.Controls.SetChildIndex(this.but_select, 0);
            this.panel1.Controls.SetChildIndex(this.but_buscar, 0);
            // 
            // btn_salir1
            // 
            this.btn_salir1.Location = new System.Drawing.Point(623, 12);
            this.btn_salir1.Size = new System.Drawing.Size(148, 38);
            this.btn_salir1.Click += new System.EventHandler(this.btn_salir1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 254);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(155, 86);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(280, 86);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(297, 20);
            this.textbox1.TabIndex = 3;
            this.textbox1.Validar = false;
            // 
            // but_select
            // 
            this.but_select.Location = new System.Drawing.Point(30, 16);
            this.but_select.Name = "but_select";
            this.but_select.Size = new System.Drawing.Size(146, 33);
            this.but_select.TabIndex = 1;
            this.but_select.Text = "Seleccionar";
            this.but_select.UseVisualStyleBackColor = true;
            // 
            // but_buscar
            // 
            this.but_buscar.Location = new System.Drawing.Point(302, 12);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(150, 38);
            this.but_buscar.TabIndex = 2;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textbox1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Utilidades.label label1;
        private Utilidades.textbox textbox1;
        private System.Windows.Forms.Button but_buscar;
        private System.Windows.Forms.Button but_select;
    }
}