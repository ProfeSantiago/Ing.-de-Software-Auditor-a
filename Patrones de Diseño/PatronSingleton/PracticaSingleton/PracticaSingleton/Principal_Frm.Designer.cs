namespace PracticaSingleton
{
    partial class Principal_Frm
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
            this.Reporte_txt = new System.Windows.Forms.TextBox();
            this.Reporte_Btn = new System.Windows.Forms.Button();
            this.Factu_Btn = new System.Windows.Forms.Button();
            this.Artic_Btn = new System.Windows.Forms.Button();
            this.CxC_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reporte_txt
            // 
            this.Reporte_txt.Location = new System.Drawing.Point(13, 13);
            this.Reporte_txt.Multiline = true;
            this.Reporte_txt.Name = "Reporte_txt";
            this.Reporte_txt.Size = new System.Drawing.Size(240, 144);
            this.Reporte_txt.TabIndex = 0;
            // 
            // Reporte_Btn
            // 
            this.Reporte_Btn.Location = new System.Drawing.Point(178, 173);
            this.Reporte_Btn.Name = "Reporte_Btn";
            this.Reporte_Btn.Size = new System.Drawing.Size(75, 23);
            this.Reporte_Btn.TabIndex = 1;
            this.Reporte_Btn.Text = "Reporte";
            this.Reporte_Btn.UseVisualStyleBackColor = true;
            this.Reporte_Btn.Click += new System.EventHandler(this.Reporte_Btn_Click);
            // 
            // Factu_Btn
            // 
            this.Factu_Btn.Location = new System.Drawing.Point(13, 240);
            this.Factu_Btn.Name = "Factu_Btn";
            this.Factu_Btn.Size = new System.Drawing.Size(75, 23);
            this.Factu_Btn.TabIndex = 2;
            this.Factu_Btn.Text = "Facturacion";
            this.Factu_Btn.UseVisualStyleBackColor = true;
            this.Factu_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Artic_Btn
            // 
            this.Artic_Btn.Location = new System.Drawing.Point(95, 240);
            this.Artic_Btn.Name = "Artic_Btn";
            this.Artic_Btn.Size = new System.Drawing.Size(75, 23);
            this.Artic_Btn.TabIndex = 3;
            this.Artic_Btn.Text = "Articulos";
            this.Artic_Btn.UseVisualStyleBackColor = true;
            this.Artic_Btn.Click += new System.EventHandler(this.Artic_Btn_Click);
            // 
            // CxC_Btn
            // 
            this.CxC_Btn.Location = new System.Drawing.Point(178, 239);
            this.CxC_Btn.Name = "CxC_Btn";
            this.CxC_Btn.Size = new System.Drawing.Size(75, 23);
            this.CxC_Btn.TabIndex = 4;
            this.CxC_Btn.Text = "CxC";
            this.CxC_Btn.UseVisualStyleBackColor = true;
            this.CxC_Btn.Click += new System.EventHandler(this.CxC_Btn_Click);
            // 
            // Principal_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 296);
            this.Controls.Add(this.CxC_Btn);
            this.Controls.Add(this.Artic_Btn);
            this.Controls.Add(this.Factu_Btn);
            this.Controls.Add(this.Reporte_Btn);
            this.Controls.Add(this.Reporte_txt);
            this.Name = "Principal_Frm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Reporte_txt;
        private System.Windows.Forms.Button Reporte_Btn;
        private System.Windows.Forms.Button Factu_Btn;
        private System.Windows.Forms.Button Artic_Btn;
        private System.Windows.Forms.Button CxC_Btn;
    }
}

