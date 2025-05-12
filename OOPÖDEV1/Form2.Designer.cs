namespace OOP_ÖDEV
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            kareToolStripMenuItem = new ToolStripMenuItem();
            dikdörtgenToolStripMenuItem = new ToolStripMenuItem();
            çemberToolStripMenuItem = new ToolStripMenuItem();
            elipsToolStripMenuItem = new ToolStripMenuItem();
            üçgenToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(35, 450);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { kareToolStripMenuItem, dikdörtgenToolStripMenuItem, çemberToolStripMenuItem, elipsToolStripMenuItem, üçgenToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(32, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // kareToolStripMenuItem
            // 
            kareToolStripMenuItem.Name = "kareToolStripMenuItem";
            kareToolStripMenuItem.Size = new Size(224, 26);
            kareToolStripMenuItem.Text = "Kare";
            kareToolStripMenuItem.Click += kareToolStripMenuItem_Click;
            // 
            // dikdörtgenToolStripMenuItem
            // 
            dikdörtgenToolStripMenuItem.Name = "dikdörtgenToolStripMenuItem";
            dikdörtgenToolStripMenuItem.Size = new Size(224, 26);
            dikdörtgenToolStripMenuItem.Text = "Dikdörtgen";
            dikdörtgenToolStripMenuItem.Click += dikdörtgenToolStripMenuItem_Click;
            // 
            // çemberToolStripMenuItem
            // 
            çemberToolStripMenuItem.Name = "çemberToolStripMenuItem";
            çemberToolStripMenuItem.Size = new Size(224, 26);
            çemberToolStripMenuItem.Text = "Çember";
            çemberToolStripMenuItem.Click += çemberToolStripMenuItem_Click;
            // 
            // elipsToolStripMenuItem
            // 
            elipsToolStripMenuItem.Name = "elipsToolStripMenuItem";
            elipsToolStripMenuItem.Size = new Size(224, 26);
            elipsToolStripMenuItem.Text = "Elips ";
            elipsToolStripMenuItem.Click += elipsToolStripMenuItem_Click;
            // 
            // üçgenToolStripMenuItem
            // 
            üçgenToolStripMenuItem.Name = "üçgenToolStripMenuItem";
            üçgenToolStripMenuItem.Size = new Size(224, 26);
            üçgenToolStripMenuItem.Text = "Üçgen";
            üçgenToolStripMenuItem.Click += üçgenToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "Form2";
            Text = "Form2";
            MouseDown += Form2_MouseDown;
            MouseMove += Form2_MouseMove;
            MouseUp += Form2_MouseUp;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem kareToolStripMenuItem;
        private ToolStripMenuItem dikdörtgenToolStripMenuItem;
        private ToolStripMenuItem çemberToolStripMenuItem;
        private ToolStripMenuItem elipsToolStripMenuItem;
        private ToolStripMenuItem üçgenToolStripMenuItem;
    }
}