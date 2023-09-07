namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.hERZAMANENÜSTTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hERZAMANÜSTTETUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dETAYLIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hERZAMANENÜSTTEToolStripMenuItem
            // 
            this.hERZAMANENÜSTTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hERZAMANÜSTTETUTToolStripMenuItem});
            this.hERZAMANENÜSTTEToolStripMenuItem.Name = "hERZAMANENÜSTTEToolStripMenuItem";
            this.hERZAMANENÜSTTEToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.hERZAMANENÜSTTEToolStripMenuItem.Text = "AYARLAR";
            // 
            // hERZAMANÜSTTETUTToolStripMenuItem
            // 
            this.hERZAMANÜSTTETUTToolStripMenuItem.Checked = true;
            this.hERZAMANÜSTTETUTToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hERZAMANÜSTTETUTToolStripMenuItem.Name = "hERZAMANÜSTTETUTToolStripMenuItem";
            this.hERZAMANÜSTTETUTToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.hERZAMANÜSTTETUTToolStripMenuItem.Text = "HER ZAMAN ÜSTTE TUT";
            this.hERZAMANÜSTTETUTToolStripMenuItem.Click += new System.EventHandler(this.hERZAMANÜSTTETUTToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hERZAMANENÜSTTEToolStripMenuItem,
            this.görünümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dETAYLIToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // dETAYLIToolStripMenuItem
            // 
            this.dETAYLIToolStripMenuItem.Name = "dETAYLIToolStripMenuItem";
            this.dETAYLIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dETAYLIToolStripMenuItem.Text = "DETAYLI";
            this.dETAYLIToolStripMenuItem.Click += new System.EventHandler(this.dETAYLIToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(789, 690);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem hERZAMANENÜSTTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hERZAMANÜSTTETUTToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dETAYLIToolStripMenuItem;
    }
}