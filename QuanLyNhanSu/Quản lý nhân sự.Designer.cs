namespace QuanLyNhanSu
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.dgvNhanSu = new System.Windows.Forms.DataGridView();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân sự";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.dtpNS);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNS.Location = new System.Drawing.Point(118, 156);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(217, 27);
            this.dtpNS.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(460, 121);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 27);
            this.txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(338, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(118, 78);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(217, 27);
            this.txtTen.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(109, 27);
            this.txtID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(447, 77);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(235, 27);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btUp);
            this.groupBox2.Controls.Add(this.btDel);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(766, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 203);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(29, 154);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(106, 29);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(29, 114);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(106, 31);
            this.btUp.TabIndex = 2;
            this.btUp.Text = "Sửa";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(29, 72);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(106, 32);
            this.btDel.TabIndex = 1;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(29, 26);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(106, 33);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Sắp xếp";
            // 
            // cbSapXep
            // 
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Items.AddRange(new object[] {
            "ID",
            "Họ tên",
            ""});
            this.cbSapXep.Location = new System.Drawing.Point(223, 310);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(169, 24);
            this.cbSapXep.TabIndex = 4;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // dgvNhanSu
            // 
            this.dgvNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanSu.Location = new System.Drawing.Point(35, 360);
            this.dgvNhanSu.Name = "dgvNhanSu";
            this.dgvNhanSu.RowHeadersWidth = 51;
            this.dgvNhanSu.RowTemplate.Height = 24;
            this.dgvNhanSu.Size = new System.Drawing.Size(899, 207);
            this.dgvNhanSu.TabIndex = 5;
            this.dgvNhanSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanSu_CellContentClick_1);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGioiTinh.Location = new System.Drawing.Point(118, 116);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(109, 28);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(592, 312);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 22);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(961, 579);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvNhanSu);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.DataGridView dgvNhanSu;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

