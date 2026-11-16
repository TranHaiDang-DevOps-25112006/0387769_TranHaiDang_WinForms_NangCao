using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bai3
{
    public partial class FrmEditor : Form
    {
        private string duongDanFile = "";
        private bool daSua = false;

        public FrmEditor()
        {
            InitializeComponent();
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            lblViTri.Spring = false;
            lblKyTu.Alignment = ToolStripItemAlignment.Right;


            rtbNoiDung.BringToFront();

            
            rtbNoiDung.TextChanged += rtbNoiDung_TextChanged;
            rtbNoiDung.SelectionChanged += rtbNoiDung_SelectionChanged;
            this.FormClosing += FrmEditor_FormClosing;

            
            mnuMoi.Click += Moi_Click;
            tsbMoi.Click += Moi_Click;

            mnuMo.Click += Mo_Click;
            tsbMo.Click += Mo_Click;

            mnuLuu.Click += Luu_Click;
            tsbLuu.Click += Luu_Click;

            mnuThoat.Click += mnuThoat_Click;

            
            mnuCat.Click += mnuCat_Click;
            mnuSaoChep.Click += mnuSaoChep_Click;
            mnuDan.Click += mnuDan_Click;

            
            mnuFont.Click += mnuFont_Click;
            mnuMau.Click += mnuMau_Click;

            CapNhatTrangThai();
        }

        
        private void CapNhatTrangThai()
        {
            int vt = rtbNoiDung.SelectionStart;
            int dong = rtbNoiDung.GetLineFromCharIndex(vt);
            int cot = vt - rtbNoiDung.GetFirstCharIndexFromLine(dong);

            lblViTri.Text = $"Dong {dong + 1}, Cot {cot + 1}";
            lblKyTu.Text = $"{rtbNoiDung.TextLength} ky tu";

            string ten = duongDanFile == "" ? "Chua dat ten" : Path.GetFileName(duongDanFile);
            this.Text = $"{ten}{(daSua ? " *" : "")} - Mini Editor";
        }

        private void rtbNoiDung_TextChanged(object? sender, EventArgs e)
        {
            daSua = true;
            CapNhatTrangThai();
        }

        private void rtbNoiDung_SelectionChanged(object? sender, EventArgs e) => CapNhatTrangThai();

        
        private bool HoiLuu()
        {
            if (!daSua) return true;

            var kq = MessageBox.Show("Noi dung da thay doi. Luu truoc khi tiep tuc?",
                "Mini Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (kq == DialogResult.Cancel) return false;
            if (kq == DialogResult.Yes) return Luu();
            return true;
        }

        
        private bool Luu()
        {
            if (duongDanFile == "")
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return false;
                duongDanFile = saveFileDialog1.FileName;
            }

            try
            {
                File.WriteAllText(duongDanFile, rtbNoiDung.Text, Encoding.UTF8);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Khong luu duoc: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            daSua = false;
            CapNhatTrangThai();
            return true;
        }

        private void Moi_Click(object? sender, EventArgs e)
        {
            if (!HoiLuu()) return;

            rtbNoiDung.Clear();
            duongDanFile = "";
            daSua = false;
            CapNhatTrangThai();
        }

        private void Mo_Click(object? sender, EventArgs e)
        {
            if (!HoiLuu()) return;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            try
            {
                rtbNoiDung.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);
                duongDanFile = openFileDialog1.FileName;
                daSua = false; 
                CapNhatTrangThai();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Khong mo duoc: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Luu_Click(object? sender, EventArgs e) => Luu();

        private void mnuThoat_Click(object? sender, EventArgs e) => Close();

        private void mnuCat_Click(object? sender, EventArgs e) => rtbNoiDung.Cut();

        private void mnuSaoChep_Click(object? sender, EventArgs e) => rtbNoiDung.Copy();

        private void mnuDan_Click(object? sender, EventArgs e) => rtbNoiDung.Paste();

        private void mnuFont_Click(object? sender, EventArgs e)
        {
            fontDialog1.Font = rtbNoiDung.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbNoiDung.Font = fontDialog1.Font;
            }
        }

        private void mnuMau_Click(object? sender, EventArgs e)
        {
            colorDialog1.Color = rtbNoiDung.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbNoiDung.ForeColor = colorDialog1.Color;
            }
        }

        private void FrmEditor_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!HoiLuu())
            {
                e.Cancel = true; 
            }
        }
    }
}