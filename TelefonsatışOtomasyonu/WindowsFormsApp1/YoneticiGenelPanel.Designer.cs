
namespace WindowsFormsApp1
{
    partial class YoneticiGenelPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satısListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satısYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.satışlarToolStripMenuItem,
            this.telefonlarToolStripMenuItem,
            this.yöneticiPaneliToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriEkleToolStripMenuItem,
            this.musteriListeleToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // musteriEkleToolStripMenuItem
            // 
            this.musteriEkleToolStripMenuItem.Name = "musteriEkleToolStripMenuItem";
            this.musteriEkleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.musteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.musteriEkleToolStripMenuItem.Click += new System.EventHandler(this.musteriEkleToolStripMenuItem_Click);
            // 
            // musteriListeleToolStripMenuItem
            // 
            this.musteriListeleToolStripMenuItem.Name = "musteriListeleToolStripMenuItem";
            this.musteriListeleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.musteriListeleToolStripMenuItem.Text = "Müşteri Listele";
            this.musteriListeleToolStripMenuItem.Click += new System.EventHandler(this.musteriListeleToolStripMenuItem_Click);
            // 
            // satışlarToolStripMenuItem
            // 
            this.satışlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satısListeleToolStripMenuItem,
            this.satısYapToolStripMenuItem});
            this.satışlarToolStripMenuItem.Name = "satışlarToolStripMenuItem";
            this.satışlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.satışlarToolStripMenuItem.Text = "Satışlar";
            // 
            // satısListeleToolStripMenuItem
            // 
            this.satısListeleToolStripMenuItem.Name = "satısListeleToolStripMenuItem";
            this.satısListeleToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.satısListeleToolStripMenuItem.Text = "Satış Listele";
            this.satısListeleToolStripMenuItem.Click += new System.EventHandler(this.satısListeleToolStripMenuItem_Click);
            // 
            // satısYapToolStripMenuItem
            // 
            this.satısYapToolStripMenuItem.Name = "satısYapToolStripMenuItem";
            this.satısYapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.satısYapToolStripMenuItem.Text = "Satış Yap";
            this.satısYapToolStripMenuItem.Click += new System.EventHandler(this.satısYapToolStripMenuItem_Click);
            // 
            // telefonlarToolStripMenuItem
            // 
            this.telefonlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonEkleToolStripMenuItem,
            this.telefonListeleToolStripMenuItem});
            this.telefonlarToolStripMenuItem.Name = "telefonlarToolStripMenuItem";
            this.telefonlarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.telefonlarToolStripMenuItem.Text = "Telefonlar";
            // 
            // telefonEkleToolStripMenuItem
            // 
            this.telefonEkleToolStripMenuItem.Name = "telefonEkleToolStripMenuItem";
            this.telefonEkleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.telefonEkleToolStripMenuItem.Text = "Telefon Ekle";
            this.telefonEkleToolStripMenuItem.Click += new System.EventHandler(this.telefonEkleToolStripMenuItem_Click);
            // 
            // telefonListeleToolStripMenuItem
            // 
            this.telefonListeleToolStripMenuItem.Name = "telefonListeleToolStripMenuItem";
            this.telefonListeleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.telefonListeleToolStripMenuItem.Text = "Telefon Listele";
            this.telefonListeleToolStripMenuItem.Click += new System.EventHandler(this.telefonListeleToolStripMenuItem_Click);
            // 
            // yöneticiPaneliToolStripMenuItem
            // 
            this.yöneticiPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiEkleToolStripMenuItem,
            this.yöneticiListeleToolStripMenuItem});
            this.yöneticiPaneliToolStripMenuItem.Name = "yöneticiPaneliToolStripMenuItem";
            this.yöneticiPaneliToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.yöneticiPaneliToolStripMenuItem.Text = "Yönetici Paneli";
            // 
            // yöneticiEkleToolStripMenuItem
            // 
            this.yöneticiEkleToolStripMenuItem.Name = "yöneticiEkleToolStripMenuItem";
            this.yöneticiEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yöneticiEkleToolStripMenuItem.Text = "Yönetici Ekle";
            this.yöneticiEkleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkleToolStripMenuItem_Click);
            // 
            // yöneticiListeleToolStripMenuItem
            // 
            this.yöneticiListeleToolStripMenuItem.Name = "yöneticiListeleToolStripMenuItem";
            this.yöneticiListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yöneticiListeleToolStripMenuItem.Text = "Yönetici Listele";
            this.yöneticiListeleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiListeleToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click_1);
            // 
            // YoneticiGenelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 451);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YoneticiGenelPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiGenelPanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satısListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satısYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}