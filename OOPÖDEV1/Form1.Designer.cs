namespace OOP_ÖDEV
{
    partial class Form1
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
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            dosyaAçToolStripMenuItem = new ToolStripMenuItem();
            dosyaKaydetToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            biçimToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            renkToolStripMenuItem = new ToolStripMenuItem();
            yazıRengiToolStripMenuItem = new ToolStripMenuItem();
            zeminRengiToolStripMenuItem = new ToolStripMenuItem();
            yazıStiliToolStripMenuItem = new ToolStripMenuItem();
            şablonToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            cToolStripMenuItem2 = new ToolStripMenuItem();
            çizimToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            fontDialog1 = new FontDialog();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            kesContext = new ToolStripMenuItem();
            kopyalaContext = new ToolStripMenuItem();
            yapıştırContext = new ToolStripMenuItem();
            yazıRengiContext = new ToolStripMenuItem();
            zeminRengiContext = new ToolStripMenuItem();
            fosforluKalemToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, biçimToolStripMenuItem, ayarlarToolStripMenuItem, şablonToolStripMenuItem, çizimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1308, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, dosyaAçToolStripMenuItem, dosyaKaydetToolStripMenuItem, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(224, 26);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // dosyaAçToolStripMenuItem
            // 
            dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            dosyaAçToolStripMenuItem.Size = new Size(224, 26);
            dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            dosyaAçToolStripMenuItem.Click += dosyaAçToolStripMenuItem_Click;
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            dosyaKaydetToolStripMenuItem.Size = new Size(224, 26);
            dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            dosyaKaydetToolStripMenuItem.Click += dosyaKaydetToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(224, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // biçimToolStripMenuItem
            // 
            biçimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem });
            biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            biçimToolStripMenuItem.Size = new Size(60, 24);
            biçimToolStripMenuItem.Text = "Biçim";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(224, 26);
            kesToolStripMenuItem.Text = "Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(224, 26);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            kopyalaToolStripMenuItem.Click += kopyalaToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(224, 26);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            yapıştırToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { renkToolStripMenuItem, yazıStiliToolStripMenuItem, fosforluKalemToolStripMenuItem });
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(70, 24);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkToolStripMenuItem
            // 
            renkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yazıRengiToolStripMenuItem, zeminRengiToolStripMenuItem });
            renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            renkToolStripMenuItem.Size = new Size(224, 26);
            renkToolStripMenuItem.Text = "Renk";
            // 
            // yazıRengiToolStripMenuItem
            // 
            yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            yazıRengiToolStripMenuItem.Size = new Size(176, 26);
            yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            yazıRengiToolStripMenuItem.Click += yazıRengiToolStripMenuItem_Click;
            // 
            // zeminRengiToolStripMenuItem
            // 
            zeminRengiToolStripMenuItem.Name = "zeminRengiToolStripMenuItem";
            zeminRengiToolStripMenuItem.Size = new Size(176, 26);
            zeminRengiToolStripMenuItem.Text = "Zemin Rengi";
            zeminRengiToolStripMenuItem.Click += zeminRengiToolStripMenuItem_Click;
            // 
            // yazıStiliToolStripMenuItem
            // 
            yazıStiliToolStripMenuItem.Name = "yazıStiliToolStripMenuItem";
            yazıStiliToolStripMenuItem.Size = new Size(224, 26);
            yazıStiliToolStripMenuItem.Text = "Yazı Stili";
            yazıStiliToolStripMenuItem.Click += yazıStiliToolStripMenuItem_Click;
            // 
            // şablonToolStripMenuItem
            // 
            şablonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem, cToolStripMenuItem1, cToolStripMenuItem2 });
            şablonToolStripMenuItem.Name = "şablonToolStripMenuItem";
            şablonToolStripMenuItem.Size = new Size(69, 24);
            şablonToolStripMenuItem.Text = "Şablon";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(224, 26);
            cToolStripMenuItem.Text = "C";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(224, 26);
            cToolStripMenuItem1.Text = "C++";
            cToolStripMenuItem1.Click += cToolStripMenuItem1_Click;
            // 
            // cToolStripMenuItem2
            // 
            cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            cToolStripMenuItem2.Size = new Size(224, 26);
            cToolStripMenuItem2.Text = "C#";
            cToolStripMenuItem2.Click += cToolStripMenuItem2_Click;
            // 
            // çizimToolStripMenuItem
            // 
            çizimToolStripMenuItem.Name = "çizimToolStripMenuItem";
            çizimToolStripMenuItem.Size = new Size(60, 24);
            çizimToolStripMenuItem.Text = "Çizim";
            çizimToolStripMenuItem.Click += çizimToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1296, 397);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.MouseDown += richTextBox1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { kesContext, kopyalaContext, yapıştırContext, yazıRengiContext, zeminRengiContext });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(163, 124);
            // 
            // kesContext
            // 
            kesContext.Name = "kesContext";
            kesContext.Size = new Size(162, 24);
            kesContext.Text = "Kes";
            kesContext.Click += kesContext_Click;
            // 
            // kopyalaContext
            // 
            kopyalaContext.Name = "kopyalaContext";
            kopyalaContext.Size = new Size(162, 24);
            kopyalaContext.Text = "Kopyala";
            kopyalaContext.Click += kopyalaContext_Click;
            // 
            // yapıştırContext
            // 
            yapıştırContext.Name = "yapıştırContext";
            yapıştırContext.Size = new Size(162, 24);
            yapıştırContext.Text = "Yapıştır";
            yapıştırContext.Click += yapıştırContext_Click;
            // 
            // yazıRengiContext
            // 
            yazıRengiContext.Name = "yazıRengiContext";
            yazıRengiContext.Size = new Size(162, 24);
            yazıRengiContext.Text = "Yazı Rengi";
            yazıRengiContext.Click += yazıRengiContext_Click;
            // 
            // zeminRengiContext
            // 
            zeminRengiContext.Name = "zeminRengiContext";
            zeminRengiContext.Size = new Size(162, 24);
            zeminRengiContext.Text = "Zemin Rengi";
            zeminRengiContext.Click += zeminRengiContext_Click;
            // 
            // fosforluKalemToolStripMenuItem
            // 
            fosforluKalemToolStripMenuItem.Name = "fosforluKalemToolStripMenuItem";
            fosforluKalemToolStripMenuItem.Size = new Size(224, 26);
            fosforluKalemToolStripMenuItem.Text = "Fosforlu Kalem";
            fosforluKalemToolStripMenuItem.Click += fosforluKalemToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem dosyaAçToolStripMenuItem;
        private ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem biçimToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem renkToolStripMenuItem;
        private ToolStripMenuItem yazıRengiToolStripMenuItem;
        private ToolStripMenuItem zeminRengiToolStripMenuItem;
        private ToolStripMenuItem yazıStiliToolStripMenuItem;
        private ToolStripMenuItem şablonToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem2;
        private ToolStripMenuItem çizimToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private FontDialog fontDialog1;
        private RichTextBox richTextBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem kesContext;
        private ToolStripMenuItem kopyalaContext;
        private ToolStripMenuItem yapıştırContext;
        private ToolStripMenuItem yazıRengiContext;
        private ToolStripMenuItem zeminRengiContext;
        private ToolStripMenuItem fosforluKalemToolStripMenuItem;
    }
}