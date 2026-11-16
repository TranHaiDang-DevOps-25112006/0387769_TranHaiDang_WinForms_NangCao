namespace Bai4
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            mnuSinhVien = new ToolStripMenuItem();
            mnuEditor = new ToolStripMenuItem();
            mnuDuyet = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuNgang = new ToolStripMenuItem();
            mnuDoc = new ToolStripMenuItem();
            mnuDongTatCa = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblGio = new ToolStripStatusLabel();
            lblSoCuaSo = new ToolStripStatusLabel();
            tmrDongHo = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quanLyToolStripMenuItem, mnuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = mnuCuaSo;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuSinhVien, mnuEditor, mnuDuyet, toolStripMenuItem1, mnuThoat });
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(89, 29);
            quanLyToolStripMenuItem.Text = "Quan ly";
            // 
            // mnuSinhVien
            // 
            mnuSinhVien.Name = "mnuSinhVien";
            mnuSinhVien.Size = new Size(270, 34);
            mnuSinhVien.Text = "Sinh vien";
            // 
            // mnuEditor
            // 
            mnuEditor.Name = "mnuEditor";
            mnuEditor.Size = new Size(270, 34);
            mnuEditor.Text = "Mini Editor";
            // 
            // mnuDuyet
            // 
            mnuDuyet.Name = "mnuDuyet";
            mnuDuyet.Size = new Size(270, 34);
            mnuDuyet.Text = "Duyet thu muc";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(267, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(270, 34);
            mnuThoat.Text = "Thoat";
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuNgang, mnuDoc, mnuDongTatCa });
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(82, 29);
            mnuCuaSo.Text = "Cua so";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(270, 34);
            mnuCascade.Text = "Cascade";
            // 
            // mnuNgang
            // 
            mnuNgang.Name = "mnuNgang";
            mnuNgang.Size = new Size(270, 34);
            mnuNgang.Text = "Ngang";
            // 
            // mnuDoc
            // 
            mnuDoc.Name = "mnuDoc";
            mnuDoc.Size = new Size(270, 34);
            mnuDoc.Text = "Doc";
            // 
            // mnuDongTatCa
            // 
            mnuDongTatCa.Name = "mnuDongTatCa";
            mnuDongTatCa.Size = new Size(270, 34);
            mnuDongTatCa.Text = "Dong tat ca";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblGio, lblSoCuaSo });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblGio
            // 
            lblGio.Name = "lblGio";
            lblGio.Size = new Size(116, 25);
            lblGio.Text = "Gio: 00:00:00";
            // 
            // lblSoCuaSo
            // 
            lblSoCuaSo.Name = "lblSoCuaSo";
            lblSoCuaSo.Size = new Size(162, 25);
            lblSoCuaSo.Text = "Dang mo: 0 cua so";
            // 
            // tmrDongHo
            // 
            tmrDongHo.Enabled = true;
            tmrDongHo.Interval = 1000;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quan ly - MDI";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quanLyToolStripMenuItem;
        private ToolStripMenuItem mnuSinhVien;
        private ToolStripMenuItem mnuEditor;
        private ToolStripMenuItem mnuDuyet;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuCuaSo;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuNgang;
        private ToolStripMenuItem mnuDoc;
        private ToolStripMenuItem mnuDongTatCa;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblGio;
        private ToolStripStatusLabel lblSoCuaSo;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}
