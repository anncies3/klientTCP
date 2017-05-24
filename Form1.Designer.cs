namespace klientTCP
{
    partial class Form1
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
            this.przycisk = new System.Windows.Forms.Button();
            this.polaczenie = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.port_p = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(274, 281);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(221, 47);
            this.przycisk.TabIndex = 0;
            this.przycisk.Text = "zamknij";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.przycisk_Click);
            // 
            // polaczenie
            // 
            this.polaczenie.Location = new System.Drawing.Point(12, 281);
            this.polaczenie.Name = "polaczenie";
            this.polaczenie.Size = new System.Drawing.Size(220, 47);
            this.polaczenie.TabIndex = 1;
            this.polaczenie.Text = "Polącz";
            this.polaczenie.UseVisualStyleBackColor = true;
            this.polaczenie.Click += new System.EventHandler(this.polaczenie_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(12, 13);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(100, 20);
            this.adres.TabIndex = 3;
            this.adres.Text = "adres";
            // 
            // port_p
            // 
            this.port_p.Location = new System.Drawing.Point(355, 13);
            this.port_p.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_p.Name = "port_p";
            this.port_p.Size = new System.Drawing.Size(120, 20);
            this.port_p.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(482, 238);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 340);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port_p);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.polaczenie);
            this.Controls.Add(this.przycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk;
        private System.Windows.Forms.Button polaczenie;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown port_p;
        private System.Windows.Forms.ListBox listBox1;
    }
}

