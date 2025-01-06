namespace PlateDetectionV1
{
    partial class FrmPlakaKayit
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnkayit = new System.Windows.Forms.Button();
            this.picCar1 = new System.Windows.Forms.PictureBox();
            this.datekayit = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kayıt Tarih:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsoyad.Location = new System.Drawing.Point(165, 97);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(156, 35);
            this.txtsoyad.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Şahıs Soyad:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtad.Location = new System.Drawing.Point(165, 56);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(156, 35);
            this.txtad.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Şahıs Ad:";
            // 
            // txtplaka
            // 
            this.txtplaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtplaka.Location = new System.Drawing.Point(165, 15);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.ReadOnly = true;
            this.txtplaka.Size = new System.Drawing.Size(156, 35);
            this.txtplaka.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Plaka";
            // 
            // btnkayit
            // 
            this.btnkayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnkayit.Location = new System.Drawing.Point(12, 203);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(114, 58);
            this.btnkayit.TabIndex = 22;
            this.btnkayit.Text = "Kayıt";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // picCar1
            // 
            this.picCar1.Location = new System.Drawing.Point(359, 15);
            this.picCar1.Name = "picCar1";
            this.picCar1.Size = new System.Drawing.Size(399, 246);
            this.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar1.TabIndex = 23;
            this.picCar1.TabStop = false;
            // 
            // datekayit
            // 
            this.datekayit.Enabled = false;
            this.datekayit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datekayit.Location = new System.Drawing.Point(165, 144);
            this.datekayit.Name = "datekayit";
            this.datekayit.Size = new System.Drawing.Size(156, 26);
            this.datekayit.TabIndex = 24;
            // 
            // FrmPlakaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datekayit);
            this.Controls.Add(this.picCar1);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.label5);
            this.Name = "FrmPlakaKayit";
            this.Text = "Plaka Kayıt et";
            this.Load += new System.EventHandler(this.FrmPlakaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.PictureBox picCar1;
        private System.Windows.Forms.DateTimePicker datekayit;
    }
}