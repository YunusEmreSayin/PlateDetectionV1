namespace PlateDetectionV1
{
    partial class FrmOperasyonDuzenle
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
            this.gridoperation = new System.Windows.Forms.DataGridView();
            this.operationCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOperation = new System.Windows.Forms.BindingSource(this.components);
            this.CarPic1 = new System.Windows.Forms.PictureBox();
            this.txtkayittarih = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOpCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnoperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridoperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridoperation
            // 
            this.gridoperation.AutoGenerateColumns = false;
            this.gridoperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridoperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridoperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operationCategoryDataGridViewTextBoxColumn,
            this.operationDateDataGridViewTextBoxColumn});
            this.gridoperation.DataSource = this.bsOperation;
            this.gridoperation.Location = new System.Drawing.Point(339, 18);
            this.gridoperation.Name = "gridoperation";
            this.gridoperation.ReadOnly = true;
            this.gridoperation.RowHeadersWidth = 62;
            this.gridoperation.RowTemplate.Height = 28;
            this.gridoperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridoperation.Size = new System.Drawing.Size(846, 384);
            this.gridoperation.TabIndex = 24;
            // 
            // operationCategoryDataGridViewTextBoxColumn
            // 
            this.operationCategoryDataGridViewTextBoxColumn.DataPropertyName = "OperationCategory";
            this.operationCategoryDataGridViewTextBoxColumn.HeaderText = "Operasyon Kategori";
            this.operationCategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.operationCategoryDataGridViewTextBoxColumn.Name = "operationCategoryDataGridViewTextBoxColumn";
            this.operationCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationDateDataGridViewTextBoxColumn
            // 
            this.operationDateDataGridViewTextBoxColumn.DataPropertyName = "OperationDate";
            this.operationDateDataGridViewTextBoxColumn.HeaderText = "Operasyon Tarihi";
            this.operationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.operationDateDataGridViewTextBoxColumn.Name = "operationDateDataGridViewTextBoxColumn";
            this.operationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsOperation
            // 
            this.bsOperation.DataSource = typeof(PlateDetectionV1.model.Operation);
            // 
            // CarPic1
            // 
            this.CarPic1.Location = new System.Drawing.Point(7, 459);
            this.CarPic1.Name = "CarPic1";
            this.CarPic1.Size = new System.Drawing.Size(269, 193);
            this.CarPic1.TabIndex = 23;
            this.CarPic1.TabStop = false;
            // 
            // txtkayittarih
            // 
            this.txtkayittarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtkayittarih.Location = new System.Drawing.Point(205, 138);
            this.txtkayittarih.Name = "txtkayittarih";
            this.txtkayittarih.ReadOnly = true;
            this.txtkayittarih.Size = new System.Drawing.Size(121, 35);
            this.txtkayittarih.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kayıt Tarih:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsoyad.Location = new System.Drawing.Point(205, 97);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.ReadOnly = true;
            this.txtsoyad.Size = new System.Drawing.Size(121, 35);
            this.txtsoyad.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Şahıs Soyad:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtad.Location = new System.Drawing.Point(205, 56);
            this.txtad.Name = "txtad";
            this.txtad.ReadOnly = true;
            this.txtad.Size = new System.Drawing.Size(121, 35);
            this.txtad.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Şahıs Ad:";
            // 
            // txtplaka
            // 
            this.txtplaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtplaka.Location = new System.Drawing.Point(205, 15);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.ReadOnly = true;
            this.txtplaka.Size = new System.Drawing.Size(121, 35);
            this.txtplaka.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Plaka:";
            // 
            // cmbOpCategory
            // 
            this.cmbOpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbOpCategory.Items.AddRange(new object[] {
            "Giriş",
            "Çıkış"});
            this.cmbOpCategory.Location = new System.Drawing.Point(205, 188);
            this.cmbOpCategory.Name = "cmbOpCategory";
            this.cmbOpCategory.Size = new System.Drawing.Size(121, 37);
            this.cmbOpCategory.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Operasyon Türü:";
            // 
            // btnoperation
            // 
            this.btnoperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnoperation.Location = new System.Drawing.Point(7, 290);
            this.btnoperation.Name = "btnoperation";
            this.btnoperation.Size = new System.Drawing.Size(143, 112);
            this.btnoperation.TabIndex = 27;
            this.btnoperation.Text = "Operasyon Düzenle";
            this.btnoperation.UseVisualStyleBackColor = true;
            this.btnoperation.Click += new System.EventHandler(this.btnoperation_Click);
            // 
            // FrmOperasyonDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 776);
            this.Controls.Add(this.btnoperation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOpCategory);
            this.Controls.Add(this.gridoperation);
            this.Controls.Add(this.CarPic1);
            this.Controls.Add(this.txtkayittarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.label5);
            this.Name = "FrmOperasyonDuzenle";
            this.Text = "Operasyon Düzenle";
            this.Load += new System.EventHandler(this.FrmOperasyonDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridoperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridoperation;
        private System.Windows.Forms.PictureBox CarPic1;
        private System.Windows.Forms.TextBox txtkayittarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsOperation;
        private System.Windows.Forms.ComboBox cmbOpCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnoperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDateDataGridViewTextBoxColumn;
    }
}