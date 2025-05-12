
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI...1......:
**				ÖĞRENCİ ADI...MUSTAFA ARKAN.......:
**				ÖĞRENCİ NUMARASI..B231210089.....:
**                         DERSİN ALINDIĞI GRUP..A.:
****************************************************************************/



using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_ÖDEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                string dosyaYolu = openFileDialog.FileName;
                string dosyaMetni = System.IO.File.ReadAllText(dosyaYolu);
                MessageBox.Show(dosyaMetni);
            }
        }

        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                string dosyaYolu = saveFileDialog.FileName;
                string dosyaMetni = "Bu metni kaydetmek istiyorum.";
                System.IO.File.WriteAllText(dosyaYolu, dosyaMetni);
                MessageBox.Show("Dosya başarıyla kaydedildi!");
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçilen metni panoya kopyala ve seçilen metni temizle
            richTextBox1.Copy();
            richTextBox1.SelectedText = "";
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçilen metni panoya kopyala
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pano içeriğini yapıştır
            richTextBox1.Paste();
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Yazı rengi seçmek için bir renk iletişim kutusu göster
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Seçilen rengi RichTextBox'ın seçili metninin rengine uygula
                this.richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Zemin rengi seçmek için bir renk iletişim kutusu göster
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen rengi form ve RichTextBox arkaplan rengine uygula
                this.BackColor = colorDialog.Color;
                this.richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void yazıStiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Yazı stili seçmek için bir font iletişim kutusu göster
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen fontu seçili metne uygula
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // C++ kodunu düzenlemek için yeni bir form aç
            Form yeniForm = new Form();

            RichTextBox txtEditor = new RichTextBox();
            txtEditor.Dock = DockStyle.Fill;
            txtEditor.Text =
                @"#include <iostream>

                int main() 
                {
                   std::cout << ""Merhaba, Dünya!"" << std::endl;
                   return 0;
                }";
            txtEditor.Font = new Font("Consolas", 10);

            yeniForm.Controls.Add(txtEditor);
            yeniForm.Show();
        }

        private void çizimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Çizim formunu göster
            Form2 cizimForm = new Form2();
            cizimForm.Show();
        }

        private void kesContext_Click(object sender, EventArgs e)
        {
            // Sağ tıklama menüsünden "Kes" seçeneği
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText = "";
            }
        }

        private void kopyalaContext_Click(object sender, EventArgs e)
        {
            // Sağ tıklama menüsünden "Kopyala" seçeneği
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void yapıştırContext_Click(object sender, EventArgs e)
        {
            // Sağ tıklama menüsünden "Yapıştır" seçeneği
            if (Clipboard.ContainsText())
            {
                richTextBox1.SelectedText = Clipboard.GetText();
            }
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Fare sağ tıklama ile "Kes", "Kopyala" ve "Yapıştır" menülerini göster
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Kes", null, kesContext_Click);
                contextMenu.Items.Add("Kopyala", null, kopyalaContext_Click);
                contextMenu.Items.Add("Yapıştır", null, yapıştırContext_Click);
                contextMenu.Items.Add("Yazı Rengi", null, yazıRengiContext_Click);
                contextMenu.Items.Add("Zemin Rengi", null, zeminRengiContext_Click);

                // Menüyü fare konumunda göster
                contextMenu.Show(this, e.Location);
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // C kodunu düzenlemek için yeni bir form aç
            Form yeniForm = new Form();

            RichTextBox txtEditor = new RichTextBox();
            txtEditor.Dock = DockStyle.Fill;
            txtEditor.Text =
                @"#include <stdio.h>

                int main() 
                {
                  printf(""[mesaj]\n"");
                  getchar();
                  return 0;
                 }";
            txtEditor.Font = new Font("Consolas", 10);

            yeniForm.Controls.Add(txtEditor);
            yeniForm.Show();
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // C# kodunu düzenlemek için yeni bir form aç
            Form yeniForm = new Form();

            RichTextBox txtEditor = new RichTextBox();
            txtEditor.Dock = DockStyle.Fill;
            txtEditor.Text =
                @"using System;

namespace [namespace_adi]
{
   class Program // sınıf tanımlaması
   {
       static void Main(string[] args)
       {
            Console.WriteLine(""[mesaj]";
            txtEditor.Font = new Font("Consolas", 10);

    yeniForm.Controls.Add(txtEditor);
            yeniForm.Show();
        }

private void yazıRengiContext_Click(object sender, EventArgs e)
{
    // Sağ tıklama menüsünden "Yazı Rengi" seçeneği
    ColorDialog colorDialog = new ColorDialog();
    if (colorDialog.ShowDialog() == DialogResult.OK)
    {
        // Seçilen rengi yazı rengine uygula
        richTextBox1.ForeColor = colorDialog.Color;
    }
}

private void zeminRengiContext_Click(object sender, EventArgs e)
{
    // Sağ tıklama menüsünden "Zemin Rengi" seçeneği
    ColorDialog colorDialog = new ColorDialog();
    if (colorDialog.ShowDialog() == DialogResult.OK)
    {
        // Seçilen rengi zemin rengine uygula
        richTextBox1.BackColor = colorDialog.Color;
    }
}

private void fosforluKalemToolStripMenuItem_Click(object sender, EventArgs e)
{
    // Fosforlu kalem seçeneğine tıklandığında
    using (ColorDialog colorDialog = new ColorDialog())
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            // Seçilen rengi fosforlu kalem olarak uygula
            fosforluKalemText(colorDialog.Color);
        }
    }
}

private void fosforluKalemText(Color SelectColor)
{
    // Fosforlu kalemle seçilen metnin arka plan rengini değiştirme
    string selectedText = richTextBox1.SelectedText;
    if (string.IsNullOrEmpty(selectedText))
    {
        return;
    }

    richTextBox1.SelectionBackColor = SelectColor;
}
    }
}
