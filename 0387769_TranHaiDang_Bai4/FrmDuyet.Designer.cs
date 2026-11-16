namespace Bai2
{
    partial class FrmDuyet
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
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            tvThuMuc = new TreeView();
            lvTapTin = new ListView();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip1.Location = new Point(0, 432);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(838, 32);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(91, 25);
            lblTrangThai.Text = "So muc: 0";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvThuMuc);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lvTapTin);
            splitContainer1.Size = new Size(838, 432);
            splitContainer1.SplitterDistance = 279;
            splitContainer1.TabIndex = 1;
            // 
            // tvThuMuc
            // 
            tvThuMuc.Dock = DockStyle.Fill;
            tvThuMuc.Location = new Point(0, 0);
            tvThuMuc.Name = "tvThuMuc";
            tvThuMuc.Size = new Size(279, 432);
            tvThuMuc.TabIndex = 0;
            // 
            // lvTapTin
            // 
            lvTapTin.Dock = DockStyle.Fill;
            lvTapTin.FullRowSelect = true;
            lvTapTin.GridLines = true;
            lvTapTin.Location = new Point(0, 0);
            lvTapTin.Name = "lvTapTin";
            lvTapTin.Size = new Size(555, 432);
            lvTapTin.TabIndex = 0;
            lvTapTin.UseCompatibleStateImageBehavior = false;
            lvTapTin.View = View.Details;
            // 
            // FrmDuyet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 464);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Name = "FrmDuyet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duyet thu muc";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private SplitContainer splitContainer1;
        private TreeView tvThuMuc;
        private ListView lvTapTin;
    }
}
