namespace ECZANE
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eCZANEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastahaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaccesitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eCZANEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastanelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçÇeşitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eCZANEToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.hastahaneToolStripMenuItem,
            this.ilaccesitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 100);
            // 
            // eCZANEToolStripMenuItem
            // 
            this.eCZANEToolStripMenuItem.Name = "eCZANEToolStripMenuItem";
            this.eCZANEToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.eCZANEToolStripMenuItem.Text = "ECZANE";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.hastaToolStripMenuItem.Text = "Hastalar";
            // 
            // hastahaneToolStripMenuItem
            // 
            this.hastahaneToolStripMenuItem.Name = "hastahaneToolStripMenuItem";
            this.hastahaneToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.hastahaneToolStripMenuItem.Text = "Hastaneler";
            // 
            // ilaccesitToolStripMenuItem
            // 
            this.ilaccesitToolStripMenuItem.Name = "ilaccesitToolStripMenuItem";
            this.ilaccesitToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.ilaccesitToolStripMenuItem.Text = "İlac_cesit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eCZANEToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eCZANEToolStripMenuItem1
            // 
            this.eCZANEToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.hastanelerToolStripMenuItem,
            this.ilaçÇeşitToolStripMenuItem});
            this.eCZANEToolStripMenuItem1.Name = "eCZANEToolStripMenuItem1";
            this.eCZANEToolStripMenuItem1.Size = new System.Drawing.Size(78, 24);
            this.eCZANEToolStripMenuItem1.Text = "ECZANE";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            this.hastalarToolStripMenuItem.Click += new System.EventHandler(this.hastalarToolStripMenuItem_Click);
            // 
            // hastanelerToolStripMenuItem
            // 
            this.hastanelerToolStripMenuItem.Name = "hastanelerToolStripMenuItem";
            this.hastanelerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hastanelerToolStripMenuItem.Text = "Hastaneler";
            this.hastanelerToolStripMenuItem.Click += new System.EventHandler(this.hastanelerToolStripMenuItem_Click);
            // 
            // ilaçÇeşitToolStripMenuItem
            // 
            this.ilaçÇeşitToolStripMenuItem.Name = "ilaçÇeşitToolStripMenuItem";
            this.ilaçÇeşitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilaçÇeşitToolStripMenuItem.Text = "İlaç Çeşit";
            this.ilaçÇeşitToolStripMenuItem.Click += new System.EventHandler(this.ilaçÇeşitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eCZANEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastahaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaccesitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eCZANEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastanelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçÇeşitToolStripMenuItem;
    }
}

