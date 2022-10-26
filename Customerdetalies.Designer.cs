namespace My_Bank_accounting_system
{
    partial class Customerdetalies
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
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(240, 76);
            this.textBoxc.Multiline = true;
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(390, 321);
            this.textBoxc.TabIndex = 0;
            this.textBoxc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxa
            // 
            this.textBoxa.Location = new System.Drawing.Point(690, 76);
            this.textBoxa.Multiline = true;
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(390, 321);
            this.textBoxa.TabIndex = 1;
            // 
            // Customerdetalies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.textBoxa);
            this.Controls.Add(this.textBoxc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customerdetalies";
            this.Text = "Customerdetalies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.TextBox textBoxa;
    }
}