namespace PlateDetectionV1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.picCar1 = new System.Windows.Forms.PictureBox();
            this.btngozat = new System.Windows.Forms.Button();
            this.btnsorgula = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKayitTarih = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnoperasyon = new System.Windows.Forms.Button();
            this.btnHareketGoruntule = new System.Windows.Forms.Button();
            this.txtKontrolTarih = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKontrolSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKontrolAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKontrolPlaka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridKontrolPlate = new System.Windows.Forms.DataGridView();
            this.plateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPlate = new System.Windows.Forms.BindingSource(this.components);
            this.bsOperation = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontrolPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1898, 1024);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtfilepath);
            this.tabPage1.Controls.Add(this.picCar1);
            this.tabPage1.Controls.Add(this.btngozat);
            this.tabPage1.Controls.Add(this.btnsorgula);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtKayitTarih);
            this.tabPage1.Controls.Add(this.txtSoyad);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.txtplaka);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1890, 991);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plaka Sorgula";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtfilepath
            // 
            this.txtfilepath.Location = new System.Drawing.Point(22, 397);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(301, 26);
            this.txtfilepath.TabIndex = 4;
            this.txtfilepath.Text = "resim yükleyiniz";
            // 
            // picCar1
            // 
            this.picCar1.Location = new System.Drawing.Point(22, 28);
            this.picCar1.Name = "picCar1";
            this.picCar1.Size = new System.Drawing.Size(446, 341);
            this.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar1.TabIndex = 3;
            this.picCar1.TabStop = false;
            // 
            // btngozat
            // 
            this.btngozat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btngozat.Location = new System.Drawing.Point(329, 388);
            this.btngozat.Name = "btngozat";
            this.btngozat.Size = new System.Drawing.Size(92, 39);
            this.btngozat.TabIndex = 2;
            this.btngozat.Text = "Gözat";
            this.btngozat.UseVisualStyleBackColor = true;
            this.btngozat.Click += new System.EventHandler(this.btngozat_Click);
            // 
            // btnsorgula
            // 
            this.btnsorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsorgula.Location = new System.Drawing.Point(521, 209);
            this.btnsorgula.Name = "btnsorgula";
            this.btnsorgula.Size = new System.Drawing.Size(109, 50);
            this.btnsorgula.TabIndex = 2;
            this.btnsorgula.Text = "Sorgula";
            this.btnsorgula.UseVisualStyleBackColor = true;
            this.btnsorgula.Click += new System.EventHandler(this.btnsorgula_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(516, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kayıt Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(516, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şahıs Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(516, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şahıs Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(516, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka:";
            // 
            // txtKayitTarih
            // 
            this.txtKayitTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKayitTarih.Location = new System.Drawing.Point(675, 145);
            this.txtKayitTarih.Name = "txtKayitTarih";
            this.txtKayitTarih.ReadOnly = true;
            this.txtKayitTarih.Size = new System.Drawing.Size(146, 35);
            this.txtKayitTarih.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoyad.Location = new System.Drawing.Point(675, 104);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(146, 35);
            this.txtSoyad.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAd.Location = new System.Drawing.Point(675, 69);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(146, 35);
            this.txtAd.TabIndex = 0;
            // 
            // txtplaka
            // 
            this.txtplaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtplaka.Location = new System.Drawing.Point(675, 25);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.ReadOnly = true;
            this.txtplaka.Size = new System.Drawing.Size(146, 35);
            this.txtplaka.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnoperasyon);
            this.tabPage2.Controls.Add(this.btnHareketGoruntule);
            this.tabPage2.Controls.Add(this.txtKontrolTarih);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtKontrolSoyad);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtKontrolAd);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtKontrolPlaka);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.GridKontrolPlate);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1890, 991);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plaka Kontrol Paneli";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnoperasyon
            // 
            this.btnoperasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnoperasyon.Location = new System.Drawing.Point(766, 324);
            this.btnoperasyon.Name = "btnoperasyon";
            this.btnoperasyon.Size = new System.Drawing.Size(148, 87);
            this.btnoperasyon.TabIndex = 6;
            this.btnoperasyon.Text = "Operasyon Düzenle";
            this.btnoperasyon.UseVisualStyleBackColor = true;
            this.btnoperasyon.Click += new System.EventHandler(this.btnoperasyon_Click);
            // 
            // btnHareketGoruntule
            // 
            this.btnHareketGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHareketGoruntule.Location = new System.Drawing.Point(939, 324);
            this.btnHareketGoruntule.Name = "btnHareketGoruntule";
            this.btnHareketGoruntule.Size = new System.Drawing.Size(150, 87);
            this.btnHareketGoruntule.TabIndex = 5;
            this.btnHareketGoruntule.Text = "Hareket Görüntüle";
            this.btnHareketGoruntule.UseVisualStyleBackColor = true;
            this.btnHareketGoruntule.Click += new System.EventHandler(this.btnHareketGoruntule_Click);
            // 
            // txtKontrolTarih
            // 
            this.txtKontrolTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKontrolTarih.Location = new System.Drawing.Point(914, 155);
            this.txtKontrolTarih.Name = "txtKontrolTarih";
            this.txtKontrolTarih.ReadOnly = true;
            this.txtKontrolTarih.Size = new System.Drawing.Size(175, 35);
            this.txtKontrolTarih.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(761, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kayıt Tarih:";
            // 
            // txtKontrolSoyad
            // 
            this.txtKontrolSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKontrolSoyad.Location = new System.Drawing.Point(914, 114);
            this.txtKontrolSoyad.Name = "txtKontrolSoyad";
            this.txtKontrolSoyad.ReadOnly = true;
            this.txtKontrolSoyad.Size = new System.Drawing.Size(175, 35);
            this.txtKontrolSoyad.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(761, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Şahıs Soyad:";
            // 
            // txtKontrolAd
            // 
            this.txtKontrolAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKontrolAd.Location = new System.Drawing.Point(914, 73);
            this.txtKontrolAd.Name = "txtKontrolAd";
            this.txtKontrolAd.ReadOnly = true;
            this.txtKontrolAd.Size = new System.Drawing.Size(175, 35);
            this.txtKontrolAd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(761, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Şahıs Ad:";
            // 
            // txtKontrolPlaka
            // 
            this.txtKontrolPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKontrolPlaka.Location = new System.Drawing.Point(914, 32);
            this.txtKontrolPlaka.Name = "txtKontrolPlaka";
            this.txtKontrolPlaka.ReadOnly = true;
            this.txtKontrolPlaka.Size = new System.Drawing.Size(175, 35);
            this.txtKontrolPlaka.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(761, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Plaka";
            // 
            // GridKontrolPlate
            // 
            this.GridKontrolPlate.AutoGenerateColumns = false;
            this.GridKontrolPlate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridKontrolPlate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridKontrolPlate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.ownerSurnameDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn});
            this.GridKontrolPlate.DataSource = this.bsPlate;
            this.GridKontrolPlate.Location = new System.Drawing.Point(8, 23);
            this.GridKontrolPlate.Name = "GridKontrolPlate";
            this.GridKontrolPlate.ReadOnly = true;
            this.GridKontrolPlate.RowHeadersWidth = 62;
            this.GridKontrolPlate.RowTemplate.Height = 28;
            this.GridKontrolPlate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridKontrolPlate.Size = new System.Drawing.Size(731, 388);
            this.GridKontrolPlate.TabIndex = 1;
            // 
            // plateDataGridViewTextBoxColumn
            // 
            this.plateDataGridViewTextBoxColumn.DataPropertyName = "Plate";
            this.plateDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plateDataGridViewTextBoxColumn.Name = "plateDataGridViewTextBoxColumn";
            this.plateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.ownerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            this.ownerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerSurnameDataGridViewTextBoxColumn
            // 
            this.ownerSurnameDataGridViewTextBoxColumn.DataPropertyName = "OwnerSurname";
            this.ownerSurnameDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.ownerSurnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ownerSurnameDataGridViewTextBoxColumn.Name = "ownerSurnameDataGridViewTextBoxColumn";
            this.ownerSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarih";
            this.registerDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPlate
            // 
            this.bsPlate.DataSource = typeof(PlateDetectionV1.model.PlateInfo);
            this.bsPlate.CurrentChanged += new System.EventHandler(this.bsPlate_CurrentChanged);
            // 
            // bsOperation
            // 
            this.bsOperation.DataSource = typeof(PlateDetectionV1.model.Operation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Plate Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontrolPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picCar1;
        private System.Windows.Forms.Button btnsorgula;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Button btngozat;
        private System.Windows.Forms.BindingSource bsOperation;
        private System.Windows.Forms.DataGridView GridKontrolPlate;
        private System.Windows.Forms.BindingSource bsPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKayitTarih;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Button btnHareketGoruntule;
        private System.Windows.Forms.TextBox txtKontrolTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKontrolSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKontrolAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKontrolPlaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnoperasyon;
    }
}

