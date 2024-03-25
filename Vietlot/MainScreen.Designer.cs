namespace Vietlot
{
    partial class MainScreen
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.muaVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mega645ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mega3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muaVéToolStripMenuItem,
            this.kếtQuảToolStripMenuItem,
            this.traCứuToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 31);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // muaVéToolStripMenuItem
            // 
            this.muaVéToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muaVéToolStripMenuItem.Name = "muaVéToolStripMenuItem";
            this.muaVéToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.muaVéToolStripMenuItem.Text = "Mua vé";
            this.muaVéToolStripMenuItem.Click += new System.EventHandler(this.muaVéToolStripMenuItem_Click);
            // 
            // kếtQuảToolStripMenuItem
            // 
            this.kếtQuảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mega645ToolStripMenuItem,
            this.mega3DToolStripMenuItem});
            this.kếtQuảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kếtQuảToolStripMenuItem.Name = "kếtQuảToolStripMenuItem";
            this.kếtQuảToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.kếtQuảToolStripMenuItem.Text = "Kết quả";
            // 
            // mega645ToolStripMenuItem
            // 
            this.mega645ToolStripMenuItem.Name = "mega645ToolStripMenuItem";
            this.mega645ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.mega645ToolStripMenuItem.Text = "Mega 6/45";
            this.mega645ToolStripMenuItem.Click += new System.EventHandler(this.mega645ToolStripMenuItem_Click);
            // 
            // mega3DToolStripMenuItem
            // 
            this.mega3DToolStripMenuItem.Name = "mega3DToolStripMenuItem";
            this.mega3DToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.mega3DToolStripMenuItem.Text = "Mega 3D";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.traCứuToolStripMenuItem.Text = "Tra cứu";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainScreen";
            this.Text = "Màn hình chính";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem muaVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mega645ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mega3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
    }
}