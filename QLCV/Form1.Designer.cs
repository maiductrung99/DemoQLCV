namespace QLCV
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nguoitao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nguoith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congviecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.congViecDataSet = new QLCV.CongViecDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtNguoitao = new System.Windows.Forms.TextBox();
            this.txtNguoith = new System.Windows.Forms.TextBox();
            this.dateNgaytao = new System.Windows.Forms.DateTimePicker();
            this.dateNgayht = new System.Windows.Forms.DateTimePicker();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.congviecTableAdapter = new QLCV.CongViecDataSetTableAdapters.CongviecTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congviecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.Ngaytao,
            this.Nguoitao,
            this.Nguoith,
            this.Ngayht});
            this.dataGridView1.Location = new System.Drawing.Point(56, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(985, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã CV";
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            this.MaCV.Width = 140;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên CV";
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            this.TenCV.Width = 160;
            // 
            // Ngaytao
            // 
            this.Ngaytao.DataPropertyName = "Ngaytao";
            this.Ngaytao.HeaderText = "Ngày tạo";
            this.Ngaytao.Name = "Ngaytao";
            this.Ngaytao.ReadOnly = true;
            this.Ngaytao.Width = 160;
            // 
            // Nguoitao
            // 
            this.Nguoitao.DataPropertyName = "Nguoitao";
            this.Nguoitao.HeaderText = "Người tạo";
            this.Nguoitao.Name = "Nguoitao";
            this.Nguoitao.ReadOnly = true;
            this.Nguoitao.Width = 180;
            // 
            // Nguoith
            // 
            this.Nguoith.DataPropertyName = "Nguoithuchien";
            this.Nguoith.HeaderText = "Người thực hiên";
            this.Nguoith.Name = "Nguoith";
            this.Nguoith.ReadOnly = true;
            this.Nguoith.Width = 180;
            // 
            // Ngayht
            // 
            this.Ngayht.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngayht.DataPropertyName = "Ngayhoanthanh";
            this.Ngayht.HeaderText = "Ngày hoàn thành";
            this.Ngayht.Name = "Ngayht";
            this.Ngayht.ReadOnly = true;
            // 
            // congviecBindingSource
            // 
            this.congviecBindingSource.DataMember = "Congviec";
            this.congviecBindingSource.DataSource = this.congViecDataSet;
            // 
            // congViecDataSet
            // 
            this.congViecDataSet.DataSetName = "CongViecDataSet";
            this.congViecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã CV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên CV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(53, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Người tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(53, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(53, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Người thực hiện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(53, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày hoàn thành";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaCV.Location = new System.Drawing.Point(195, 30);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(144, 23);
            this.txtMaCV.TabIndex = 7;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTenCV.Location = new System.Drawing.Point(195, 69);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(144, 23);
            this.txtTenCV.TabIndex = 7;
            // 
            // txtNguoitao
            // 
            this.txtNguoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNguoitao.Location = new System.Drawing.Point(195, 109);
            this.txtNguoitao.Name = "txtNguoitao";
            this.txtNguoitao.Size = new System.Drawing.Size(144, 23);
            this.txtNguoitao.TabIndex = 7;
            // 
            // txtNguoith
            // 
            this.txtNguoith.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNguoith.Location = new System.Drawing.Point(195, 196);
            this.txtNguoith.Name = "txtNguoith";
            this.txtNguoith.Size = new System.Drawing.Size(144, 23);
            this.txtNguoith.TabIndex = 7;
            // 
            // dateNgaytao
            // 
            this.dateNgaytao.CustomFormat = "dd-MM-yyyy";
            this.dateNgaytao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateNgaytao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaytao.Location = new System.Drawing.Point(195, 154);
            this.dateNgaytao.Name = "dateNgaytao";
            this.dateNgaytao.Size = new System.Drawing.Size(144, 23);
            this.dateNgaytao.TabIndex = 8;
            // 
            // dateNgayht
            // 
            this.dateNgayht.CustomFormat = "dd-MM-yyyy";
            this.dateNgayht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateNgayht.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayht.Location = new System.Drawing.Point(195, 234);
            this.dateNgayht.Name = "dateNgayht";
            this.dateNgayht.Size = new System.Drawing.Size(144, 23);
            this.dateNgayht.TabIndex = 8;
            // 
            // bttnSave
            // 
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnSave.Location = new System.Drawing.Point(453, 63);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(87, 35);
            this.bttnSave.TabIndex = 9;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnDelete.Location = new System.Drawing.Point(453, 136);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(87, 35);
            this.bttnDelete.TabIndex = 9;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(453, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // congviecTableAdapter
            // 
            this.congviecTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(656, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nhập tên CV";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(761, 78);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 23);
            this.txtSearch.TabIndex = 11;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnSearch.Location = new System.Drawing.Point(906, 72);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 35);
            this.bttnSearch.TabIndex = 12;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.dateNgayht);
            this.Controls.Add(this.dateNgaytao);
            this.Controls.Add(this.txtNguoith);
            this.Controls.Add(this.txtNguoitao);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congviecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtNguoitao;
        private System.Windows.Forms.TextBox txtNguoith;
        private System.Windows.Forms.DateTimePicker dateNgaytao;
        private System.Windows.Forms.DateTimePicker dateNgayht;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button button3;
        private CongViecDataSet congViecDataSet;
        private System.Windows.Forms.BindingSource congviecBindingSource;
        private CongViecDataSetTableAdapters.CongviecTableAdapter congviecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nguoitao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nguoith;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayht;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bttnSearch;
    }
}

