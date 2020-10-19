namespace ComboBox
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbIzbor = new System.Windows.Forms.ComboBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnPoruka = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbIzbor
            // 
            this.cmbIzbor.FormattingEnabled = true;
            this.cmbIzbor.Items.AddRange(new object[] {
            "Peugeot",
            "Yugo",
            "Golf2",
            "Ford Taunus",
            "Renault 6"});
            this.cmbIzbor.Location = new System.Drawing.Point(204, 83);
            this.cmbIzbor.Name = "cmbIzbor";
            this.cmbIzbor.Size = new System.Drawing.Size(345, 21);
            this.cmbIzbor.TabIndex = 0;
            this.cmbIzbor.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(204, 201);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(345, 20);
            this.txtIspis.TabIndex = 1;
            // 
            // btnPoruka
            // 
            this.btnPoruka.Location = new System.Drawing.Point(204, 327);
            this.btnPoruka.Name = "btnPoruka";
            this.btnPoruka.Size = new System.Drawing.Size(124, 23);
            this.btnPoruka.TabIndex = 2;
            this.btnPoruka.Text = "Prikazi Poruku";
            this.btnPoruka.UseVisualStyleBackColor = true;
            this.btnPoruka.Click += new System.EventHandler(this.BtnPoruka_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(444, 327);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(105, 23);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPoruka);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.cmbIzbor);
            this.Name = "Form1";
            this.Text = "ComboBox vjezba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbIzbor;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnPoruka;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}

