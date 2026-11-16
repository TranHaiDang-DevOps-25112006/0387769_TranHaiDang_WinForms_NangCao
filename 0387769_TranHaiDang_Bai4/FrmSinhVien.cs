using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Bai1
{
    public partial class FrmSinhVien : Form
    {
        
        private readonly List<SinhVien> goc = new();
        
        private readonly BindingSource bs = new();

        public FrmSinhVien()
        {
            InitializeComponent();

            
            this.Load += FrmSinhVien_Load;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            dgv.CellFormatting += dgv_CellFormatting;
            bs.CurrentChanged += bs_CurrentChanged;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void FrmSinhVien_Load(object? sender, EventArgs e)
        {
            
            goc.AddRange(new[]
            {
                new SinhVien("SV01", "Nguyen Van An",  "64CNTT1", 8.5),
                new SinhVien("SV02", "Tran Thi Binh",  "64CNTT1", 7.0),
                new SinhVien("SV03", "Le Van Cuong",   "64CNTT2", 5.5),
                new SinhVien("SV04", "Pham Thu Dung",  "64CNTT2", 9.0),
                new SinhVien("SV05", "Hoang Minh Duc", "64PM1",   4.5),
                new SinhVien("SV06", "Vu Thanh Ha",    "64PM1",   6.5),
                new SinhVien("SV07", "Do Quang Huy",   "64PM1",   8.0),
                new SinhVien("SV08", "Bui Lan Huong",  "64CNTT1", 7.5),
            });

            cboLop.SelectedIndex = 0;
            dgv.DataSource = bs;

            LamMoi();

           
            if (dgv.Columns["MaSV"] != null) dgv.Columns["MaSV"]!.HeaderText = "Ma SV";
            if (dgv.Columns["HoTen"] != null) dgv.Columns["HoTen"]!.HeaderText = "Ho ten";
            if (dgv.Columns["Lop"] != null) dgv.Columns["Lop"]!.HeaderText = "Lop";
            if (dgv.Columns["Diem"] != null)
            {
                dgv.Columns["Diem"]!.HeaderText = "Diem";
                dgv.Columns["Diem"]!.DefaultCellStyle.Format = "F1";
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       
        private void LamMoi(string? maChon = null)
        {
            string kw = txtTimKiem.Text.Trim().ToLower();

            var kq = goc.Where(s => s.MaSV.ToLower().Contains(kw) ||
                                    s.HoTen.ToLower().Contains(kw)).ToList();

            bs.DataSource = kq;

            string tk = $"Hien thi {kq.Count}/{goc.Count} sinh vien";
            if (kq.Count > 0)
            {
                double dtb = kq.Average(s => s.Diem);
                tk += $" | Diem TB: {dtb.ToString("F2", CultureInfo.InvariantCulture)}";
            }
            lblThongKe.Text = tk;

            if (maChon != null)
            {
                int vt = kq.FindIndex(s => s.MaSV == maChon);
                if (vt >= 0) bs.Position = vt;
            }
        }

        
        private void txtTimKiem_TextChanged(object? sender, EventArgs e) => LamMoi();

        
        private void bs_CurrentChanged(object? sender, EventArgs e)
        {
            if (bs.Current is SinhVien sv)
            {
                txtMa.Text = sv.MaSV;
                txtHoTen.Text = sv.HoTen;
                cboLop.SelectedItem = sv.Lop;
                nudDiem.Value = (decimal)sv.Diem;
                txtMa.ReadOnly = true; 
            }
            else
            {
                txtMa.ReadOnly = false;
            }
        }

        
        private void dgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgv.Rows[e.RowIndex].DataBoundItem is SinhVien sv && sv.Diem < 5)
            {
                e.CellStyle.BackColor = Color.MistyRose;
                e.CellStyle.ForeColor = Color.DarkRed;
            }
        }

        
        private void btnThem_Click(object? sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            string ten = txtHoTen.Text.Trim();

            if (ma == "" || ten == "" || cboLop.SelectedIndex < 0)
            {
                MessageBox.Show("Nhap day du ma, ho ten va chon lop", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (goc.Any(s => s.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ma sinh vien da ton tai", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            goc.Add(new SinhVien(ma, ten, cboLop.Text, (double)nudDiem.Value));
            txtTimKiem.Clear(); 
            LamMoi(ma);
        }

        
        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (bs.Current is not SinhVien sv) return;

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Ho ten khong duoc de trong", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sv.HoTen = txtHoTen.Text.Trim();
            sv.Lop = cboLop.Text;
            sv.Diem = (double)nudDiem.Value;

            LamMoi(sv.MaSV);
        }

        
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (bs.Current is not SinhVien sv) return;

            var kq = MessageBox.Show($"Xoa sinh vien {sv.HoTen}?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq != DialogResult.Yes) return;

            goc.Remove(sv);
            LamMoi();
        }

        
        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            dgv.ClearSelection();
            txtMa.Clear();
            txtHoTen.Clear();
            cboLop.SelectedIndex = 0;
            nudDiem.Value = 0;
            txtMa.ReadOnly = false;
            txtMa.Focus();
        }
    }
}