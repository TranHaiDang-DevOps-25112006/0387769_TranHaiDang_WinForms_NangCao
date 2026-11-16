namespace Bai1
{
    partial class FrmSinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTimKiem = new TextBox();
            dgv = new DataGridView();
            label1 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            cboLop = new ComboBox();
            label4 = new Label();
            nudDiem = new NumericUpDown();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblThongKe = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Location = new Point(12, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tim theo ma hoac ten";
            txtTimKiem.Size = new Size(763, 31);
            txtTimKiem.TabIndex = 0;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 49);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 62;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(763, 245);
            dgv.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 309);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "Ma SV";
            // 
            // txtMa
            // 
            txtMa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtMa.Location = new Point(81, 309);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(110, 31);
            txtMa.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(212, 315);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 4;
            label2.Text = "Ho ten";
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtHoTen.Location = new Point(284, 315);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(210, 31);
            txtHoTen.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(527, 318);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 6;
            label3.Text = "Lop";
            // 
            // cboLop
            // 
            cboLop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "64CNTT1", "64CNTT2", "64PM1" });
            cboLop.Location = new Point(575, 318);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(182, 33);
            cboLop.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(12, 364);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 8;
            label4.Text = "Diem";
            // 
            // nudDiem
            // 
            nudDiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudDiem.DecimalPlaces = 1;
            nudDiem.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudDiem.Location = new Point(81, 362);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(80, 31);
            nudDiem.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThem.Location = new Point(212, 362);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 10;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSua.Location = new Point(330, 364);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoa.Location = new Point(448, 364);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLamMoi.Location = new Point(566, 364);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 34);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Lam moi";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // lblThongKe
            // 
            lblThongKe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblThongKe.AutoSize = true;
            lblThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKe.Location = new Point(12, 399);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(302, 25);
            lblThongKe.TabIndex = 14;
            lblThongKe.Text = "So dong: 0 | Diem trung binh: 0.00";
            // 
            // FrmSinhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 429);
            Controls.Add(lblThongKe);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(nudDiem);
            Controls.Add(label4);
            Controls.Add(cboLop);
            Controls.Add(label3);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtMa);
            Controls.Add(label1);
            Controls.Add(dgv);
            Controls.Add(txtTimKiem);
            Name = "FrmSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sach sinh vien";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private DataGridView dgv;
        private Label label1;
        private TextBox txtMa;
        private Label label2;
        private TextBox txtHoTen;
        private Label label3;
        private ComboBox cboLop;
        private Label label4;
        private NumericUpDown nudDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblThongKe;
    }
}
