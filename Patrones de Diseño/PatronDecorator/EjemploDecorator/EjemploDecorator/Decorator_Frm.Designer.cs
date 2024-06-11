namespace EjemploDecorator
{
    partial class Decorator_Frm
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
            this.Config_ListView = new System.Windows.Forms.ListBox();
            this.Total_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Agrega_Brn = new System.Windows.Forms.Button();
            this.Tarjeta_Check = new System.Windows.Forms.RadioButton();
            this.Unidad_Check = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Config_ListView
            // 
            this.Config_ListView.FormattingEnabled = true;
            this.Config_ListView.Location = new System.Drawing.Point(12, 80);
            this.Config_ListView.Name = "Config_ListView";
            this.Config_ListView.Size = new System.Drawing.Size(411, 147);
            this.Config_ListView.TabIndex = 0;
            // 
            // Total_Txt
            // 
            this.Total_Txt.Location = new System.Drawing.Point(297, 244);
            this.Total_Txt.Name = "Total_Txt";
            this.Total_Txt.Size = new System.Drawing.Size(126, 20);
            this.Total_Txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Tag = "";
            this.label1.Text = "Total:";
            // 
            // Agrega_Brn
            // 
            this.Agrega_Brn.Location = new System.Drawing.Point(348, 12);
            this.Agrega_Brn.Name = "Agrega_Brn";
            this.Agrega_Brn.Size = new System.Drawing.Size(75, 23);
            this.Agrega_Brn.TabIndex = 5;
            this.Agrega_Brn.Text = "Agregar";
            this.Agrega_Brn.UseVisualStyleBackColor = true;
            this.Agrega_Brn.Click += new System.EventHandler(this.Agrega_Brn_Click);
            // 
            // Tarjeta_Check
            // 
            this.Tarjeta_Check.AutoSize = true;
            this.Tarjeta_Check.Location = new System.Drawing.Point(12, 12);
            this.Tarjeta_Check.Name = "Tarjeta_Check";
            this.Tarjeta_Check.Size = new System.Drawing.Size(129, 17);
            this.Tarjeta_Check.TabIndex = 6;
            this.Tarjeta_Check.TabStop = true;
            this.Tarjeta_Check.Text = "Tarjeta Gráfica NVidia";
            this.Tarjeta_Check.UseVisualStyleBackColor = true;
            this.Tarjeta_Check.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Unidad_Check
            // 
            this.Unidad_Check.AutoSize = true;
            this.Unidad_Check.Location = new System.Drawing.Point(12, 48);
            this.Unidad_Check.Name = "Unidad_Check";
            this.Unidad_Check.Size = new System.Drawing.Size(105, 17);
            this.Unidad_Check.TabIndex = 7;
            this.Unidad_Check.TabStop = true;
            this.Unidad_Check.Text = "Unidad Blue Ray";
            this.Unidad_Check.UseVisualStyleBackColor = true;
            // 
            // Decorator_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 294);
            this.Controls.Add(this.Unidad_Check);
            this.Controls.Add(this.Tarjeta_Check);
            this.Controls.Add(this.Agrega_Brn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total_Txt);
            this.Controls.Add(this.Config_ListView);
            this.Name = "Decorator_Frm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Config_ListView;
        private System.Windows.Forms.TextBox Total_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Agrega_Brn;
        private System.Windows.Forms.RadioButton Tarjeta_Check;
        private System.Windows.Forms.RadioButton Unidad_Check;
    }
}

