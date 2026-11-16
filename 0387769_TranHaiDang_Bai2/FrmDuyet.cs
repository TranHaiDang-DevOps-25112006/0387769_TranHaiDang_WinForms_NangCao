using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FrmDuyet : Form
    {
        public FrmDuyet()
        {
            InitializeComponent();

            
            this.Load += FrmDuyet_Load;
            tvThuMuc.BeforeExpand += tvThuMuc_BeforeExpand;
            tvThuMuc.AfterSelect += tvThuMuc_AfterSelect;
        }

        private void FrmDuyet_Load(object? sender, EventArgs e)
        {
            
            splitContainer1.SplitterDistance = 240;

            
            lvTapTin.Columns.Add("Ten", 260);
            lvTapTin.Columns.Add("Loai", 100);
            lvTapTin.Columns.Add("Kich thuoc", 100, HorizontalAlignment.Right);
            lvTapTin.Columns.Add("Ngay sua", 140);

            
            foreach (DriveInfo d in DriveInfo.GetDrives().Where(d => d.IsReady))
            {
                ThemNut(tvThuMuc.Nodes, d.Name, d.RootDirectory.FullName);
            }
        }

        
        private static void ThemNut(TreeNodeCollection cha, string ten, string duongDan)
        {
            var nut = new TreeNode(ten) { Tag = duongDan };
            nut.Nodes.Add("...");
            cha.Add(nut);
        }

        
        private void tvThuMuc_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            TreeNode nut = e.Node!;
            if (nut.Nodes.Count == 1 && nut.Nodes[0].Text == "...")
            {
                nut.Nodes.Clear();
                try
                {
                    foreach (string d in Directory.GetDirectories((string)nut.Tag!))
                    {
                        ThemNut(nut.Nodes, Path.GetFileName(d), d);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    
                }
                catch (IOException)
                {
                    
                }
            }
        }

        
        private void tvThuMuc_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is string duongDan)
            {
                NapDanhSach(duongDan);
            }
        }

        private void NapDanhSach(string duongDan)
        {
            lvTapTin.BeginUpdate();
            lvTapTin.Items.Clear();

            try
            {
                var thuMuc = new DirectoryInfo(duongDan);

               
                foreach (DirectoryInfo d in thuMuc.GetDirectories())
                {
                    lvTapTin.Items.Add(new ListViewItem(new[]
                    {
                        d.Name,
                        "Thu muc",
                        "",
                        d.LastWriteTime.ToString("dd/MM/yyyy HH:mm")
                    }));
                }

                
                foreach (FileInfo f in thuMuc.GetFiles())
                {
                    string loaiFile = string.IsNullOrEmpty(f.Extension)
                        ? "File"
                        : f.Extension.TrimStart('.').ToUpper() + " file";

                    lvTapTin.Items.Add(new ListViewItem(new[]
                    {
                        f.Name,
                        loaiFile,
                        (f.Length / 1024.0).ToString("N1") + " KB",
                        f.LastWriteTime.ToString("dd/MM/yyyy HH:mm")
                    }));
                }

                lblTrangThai.Text = $"{duongDan} | {lvTapTin.Items.Count} muc";
            }
            catch (UnauthorizedAccessException)
            {
                lblTrangThai.Text = $"{duongDan} | Khong co quyen truy cap";
            }
            catch (IOException ex)
            {
                lblTrangThai.Text = "Loi: " + ex.Message;
            }
            finally
            {
                lvTapTin.EndUpdate();
            }
        }
    }
}