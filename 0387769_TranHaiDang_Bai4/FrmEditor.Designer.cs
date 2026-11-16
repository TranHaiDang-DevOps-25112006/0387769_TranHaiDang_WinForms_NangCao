namespace Bai3
{
    partial class FrmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditor));
            menuStrip1 = new MenuStrip();
            tepToolStripMenuItem = new ToolStripMenuItem();
            mnuMoi = new ToolStripMenuItem();
            mnuMo = new ToolStripMenuItem();
            mnuLuu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            chinhSuaToolStripMenuItem = new ToolStripMenuItem();
            mnuCat = new ToolStripMenuItem();
            mnuSaoChep = new ToolStripMenuItem();
            mnuDan = new ToolStripMenuItem();
            dinhDangToolStripMenuItem = new ToolStripMenuItem();
            mnuFont = new ToolStripMenuItem();
            mnuMau = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbMoi = new ToolStripButton();
            tsbMo = new ToolStripButton();
            tsbLuu = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblViTri = new ToolStripStatusLabel();
            lblKyTu = new ToolStripStatusLabel();
            rtbNoiDung = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tepToolStripMenuItem, chinhSuaToolStripMenuItem, dinhDangToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(738, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tepToolStripMenuItem
            // 
            tepToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuMoi, mnuMo, mnuLuu, toolStripMenuItem1, mnuThoat });
            tepToolStripMenuItem.Name = "tepToolStripMenuItem";
            tepToolStripMenuItem.Size = new Size(55, 29);
            tepToolStripMenuItem.Text = "Tep";
            // 
            // mnuMoi
            // 
            mnuMoi.Name = "mnuMoi";
            mnuMoi.ShortcutKeys = Keys.Control | Keys.N;
            mnuMoi.Size = new Size(209, 34);
            mnuMoi.Text = "Moi";
            // 
            // mnuMo
            // 
            mnuMo.Name = "mnuMo";
            mnuMo.ShortcutKeys = Keys.Control | Keys.O;
            mnuMo.Size = new Size(209, 34);
            mnuMo.Text = "Mo";
            // 
            // mnuLuu
            // 
            mnuLuu.Name = "mnuLuu";
            mnuLuu.ShortcutKeys = Keys.Control | Keys.S;
            mnuLuu.Size = new Size(209, 34);
            mnuLuu.Text = "Luu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(206, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(209, 34);
            mnuThoat.Text = "Thoat";
            // 
            // chinhSuaToolStripMenuItem
            // 
            chinhSuaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCat, mnuSaoChep, mnuDan });
            chinhSuaToolStripMenuItem.Name = "chinhSuaToolStripMenuItem";
            chinhSuaToolStripMenuItem.Size = new Size(105, 29);
            chinhSuaToolStripMenuItem.Text = "Chinh sua";
            // 
            // mnuCat
            // 
            mnuCat.Name = "mnuCat";
            mnuCat.ShortcutKeys = Keys.Control | Keys.X;
            mnuCat.Size = new Size(249, 34);
            mnuCat.Text = "Cat";
            // 
            // mnuSaoChep
            // 
            mnuSaoChep.Name = "mnuSaoChep";
            mnuSaoChep.ShortcutKeys = Keys.Control | Keys.C;
            mnuSaoChep.Size = new Size(249, 34);
            mnuSaoChep.Text = "Sao chep";
            // 
            // mnuDan
            // 
            mnuDan.Name = "mnuDan";
            mnuDan.ShortcutKeys = Keys.Control | Keys.V;
            mnuDan.Size = new Size(249, 34);
            mnuDan.Text = "Dan";
            // 
            // dinhDangToolStripMenuItem
            // 
            dinhDangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuFont, mnuMau });
            dinhDangToolStripMenuItem.Name = "dinhDangToolStripMenuItem";
            dinhDangToolStripMenuItem.Size = new Size(111, 29);
            dinhDangToolStripMenuItem.Text = "Dinh dang";
            // 
            // mnuFont
            // 
            mnuFont.Name = "mnuFont";
            mnuFont.Size = new Size(162, 34);
            mnuFont.Text = "Font...";
            // 
            // mnuMau
            // 
            mnuMau.Name = "mnuMau";
            mnuMau.Size = new Size(162, 34);
            mnuMau.Text = "Mau...";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbMoi, tsbMo, tsbLuu });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(738, 34);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbMoi
            // 
            tsbMoi.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbMoi.Image = (Image)resources.GetObject("tsbMoi.Image");
            tsbMoi.ImageTransparentColor = Color.Magenta;
            tsbMoi.Name = "tsbMoi";
            tsbMoi.Size = new Size(47, 29);
            tsbMoi.Text = "Moi";
            // 
            // tsbMo
            // 
            tsbMo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbMo.Image = (Image)resources.GetObject("tsbMo.Image");
            tsbMo.ImageTransparentColor = Color.Magenta;
            tsbMo.Name = "tsbMo";
            tsbMo.Size = new Size(43, 29);
            tsbMo.Text = "Mo";
            // 
            // tsbLuu
            // 
            tsbLuu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbLuu.Image = (Image)resources.GetObject("tsbLuu.Image");
            tsbLuu.ImageTransparentColor = Color.Magenta;
            tsbLuu.Name = "tsbLuu";
            tsbLuu.Size = new Size(44, 29);
            tsbLuu.Text = "Luu";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblViTri, lblKyTu });
            statusStrip1.Location = new Point(0, 412);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(738, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblViTri
            // 
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(611, 25);
            lblViTri.Spring = true;
            lblViTri.Text = "Dong 1, Cot 1";
            lblViTri.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKyTu
            // 
            lblKyTu.Name = "lblKyTu";
            lblKyTu.Size = new Size(66, 25);
            lblKyTu.Text = "0 ky tu";
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.AcceptsTab = true;
            rtbNoiDung.Dock = DockStyle.Fill;
            rtbNoiDung.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbNoiDung.Location = new Point(0, 67);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.Size = new Size(738, 345);
            rtbNoiDung.TabIndex = 3;
            rtbNoiDung.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Van ban (*.txt)|*.txt|Tat ca (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Van ban (*.txt)|*.txt|Tat ca (*.*)|*.*";
            // 
            // FrmEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 444);
            Controls.Add(rtbNoiDung);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tepToolStripMenuItem;
        private ToolStripMenuItem mnuMoi;
        private ToolStripMenuItem mnuMo;
        private ToolStripMenuItem mnuLuu;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem chinhSuaToolStripMenuItem;
        private ToolStripMenuItem mnuCat;
        private ToolStripMenuItem mnuSaoChep;
        private ToolStripMenuItem mnuDan;
        private ToolStripMenuItem dinhDangToolStripMenuItem;
        private ToolStripMenuItem mnuFont;
        private ToolStripMenuItem mnuMau;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbMoi;
        private ToolStripButton tsbMo;
        private ToolStripButton tsbLuu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblViTri;
        private ToolStripStatusLabel lblKyTu;
        private RichTextBox rtbNoiDung;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}
