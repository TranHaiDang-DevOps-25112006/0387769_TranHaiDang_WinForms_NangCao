using System;
using System.Linq;
using System.Windows.Forms;
using Bai1;
using Bai2;
using Bai3;

namespace Bai4
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            lblGio.Spring = false;
            lblSoCuaSo.Alignment = ToolStripItemAlignment.Right;

            
            this.Load += FrmMain_Load;
            this.MdiChildActivate += FrmMain_MdiChildActivate;
            tmrDongHo.Tick += tmrDongHo_Tick;

            
            mnuSinhVien.Click += mnuSinhVien_Click;
            mnuEditor.Click += mnuEditor_Click;
            mnuDuyet.Click += mnuDuyet_Click;
            mnuThoat.Click += mnuThoat_Click;

            
            mnuCascade.Click += mnuCascade_Click;
            mnuNgang.Click += mnuNgang_Click;
            mnuDoc.Click += mnuDoc_Click;
            mnuDongTatCa.Click += mnuDongTatCa_Click;
        }

        private void FrmMain_Load(object? sender, EventArgs e)
        {
            
            tmrDongHo_Tick(sender, e);
            CapNhatSoCuaSo();
        }

        
        private void MoFormCon<T>() where T : Form, new()
        {
            T? daMo = MdiChildren.OfType<T>().FirstOrDefault();
            if (daMo != null)
            {
                if (daMo.WindowState == FormWindowState.Minimized)
                {
                    daMo.WindowState = FormWindowState.Normal;
                }
                daMo.Activate();
                return;
            }

            var f = new T { MdiParent = this };
            f.FormClosed += (s, ev) => CapNhatSoCuaSo();
            f.Show();
            CapNhatSoCuaSo();
        }

        private void CapNhatSoCuaSo()
        {
            lblSoCuaSo.Text = $"Dang mo: {MdiChildren.Length} cua so";
        }

        private void mnuSinhVien_Click(object? sender, EventArgs e) => MoFormCon<FrmSinhVien>();

        private void mnuEditor_Click(object? sender, EventArgs e) => MoFormCon<FrmEditor>();

        private void mnuDuyet_Click(object? sender, EventArgs e) => MoFormCon<FrmDuyet>();

        private void mnuThoat_Click(object? sender, EventArgs e) => Close();

        private void mnuCascade_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

        private void mnuNgang_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);

        private void mnuDoc_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

        private void mnuDongTatCa_Click(object? sender, EventArgs e)
        {
            
            foreach (Form f in MdiChildren.ToArray())
            {
                f.Close();
            }
            CapNhatSoCuaSo();
        }

        private void tmrDongHo_Tick(object? sender, EventArgs e)
        {
            lblGio.Text = "Gio: " + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void FrmMain_MdiChildActivate(object? sender, EventArgs e) => CapNhatSoCuaSo();
    }
}