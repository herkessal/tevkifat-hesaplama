namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hesapla = new System.Windows.Forms.Button();
            this.sayitextBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sonuc_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temizle_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hERZAMANENÜSTTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hERZAMANÜSTTETUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÖRÜNÜMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dETAYLIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // hesapla
            // 
            this.hesapla.AutoSize = true;
            this.hesapla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hesapla.BackColor = System.Drawing.Color.Gainsboro;
            this.hesapla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hesapla.FlatAppearance.BorderSize = 5;
            this.hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.Location = new System.Drawing.Point(122, 206);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(143, 27);
            this.hesapla.TabIndex = 0;
            this.hesapla.Text = "HESAPLA (enter)";
            this.hesapla.UseVisualStyleBackColor = false;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // sayitextBox1
            // 
            this.sayitextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.sayitextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayitextBox1.Location = new System.Drawing.Point(54, 170);
            this.sayitextBox1.MinimumSize = new System.Drawing.Size(50, 20);
            this.sayitextBox1.Name = "sayitextBox1";
            this.sayitextBox1.Size = new System.Drawing.Size(292, 30);
            this.sayitextBox1.TabIndex = 1;
            this.sayitextBox1.TextChanged += new System.EventHandler(this.sayitextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEVKİFAT HESAPLAMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "FİYAT :";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "SONUÇ:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(308, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sonuc_textBox1
            // 
            this.sonuc_textBox1.BackColor = System.Drawing.Color.White;
            this.sonuc_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc_textBox1.ForeColor = System.Drawing.Color.Red;
            this.sonuc_textBox1.Location = new System.Drawing.Point(54, 284);
            this.sonuc_textBox1.Name = "sonuc_textBox1";
            this.sonuc_textBox1.ReadOnly = true;
            this.sonuc_textBox1.Size = new System.Drawing.Size(292, 38);
            this.sonuc_textBox1.TabIndex = 8;
            this.sonuc_textBox1.TextChanged += new System.EventHandler(this.sonuc_textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(103, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "FARK:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(170, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // temizle_button
            // 
            this.temizle_button.AutoSize = true;
            this.temizle_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.temizle_button.BackColor = System.Drawing.Color.Gainsboro;
            this.temizle_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.temizle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.temizle_button.Location = new System.Drawing.Point(223, 239);
            this.temizle_button.Name = "temizle_button";
            this.temizle_button.Size = new System.Drawing.Size(137, 27);
            this.temizle_button.TabIndex = 11;
            this.temizle_button.Text = "SATIRI SİL (esc)";
            this.temizle_button.UseVisualStyleBackColor = false;
            this.temizle_button.Click += new System.EventHandler(this.temizle_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hERZAMANENÜSTTEToolStripMenuItem,
            this.gÖRÜNÜMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hERZAMANENÜSTTEToolStripMenuItem
            // 
            this.hERZAMANENÜSTTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hERZAMANÜSTTETUTToolStripMenuItem});
            this.hERZAMANENÜSTTEToolStripMenuItem.Name = "hERZAMANENÜSTTEToolStripMenuItem";
            this.hERZAMANENÜSTTEToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.hERZAMANENÜSTTEToolStripMenuItem.Text = "AYARLAR";
            this.hERZAMANENÜSTTEToolStripMenuItem.Click += new System.EventHandler(this.hERZAMANENÜSTTEToolStripMenuItem_Click);
            // 
            // hERZAMANÜSTTETUTToolStripMenuItem
            // 
            this.hERZAMANÜSTTETUTToolStripMenuItem.Checked = true;
            this.hERZAMANÜSTTETUTToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hERZAMANÜSTTETUTToolStripMenuItem.Name = "hERZAMANÜSTTETUTToolStripMenuItem";
            this.hERZAMANÜSTTETUTToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.hERZAMANÜSTTETUTToolStripMenuItem.Text = "HER ZAMAN ÜSTTE TUT";
            this.hERZAMANÜSTTETUTToolStripMenuItem.Click += new System.EventHandler(this.hERZAMANÜSTTETUTToolStripMenuItem_Click);
            // 
            // gÖRÜNÜMToolStripMenuItem
            // 
            this.gÖRÜNÜMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dETAYLIToolStripMenuItem});
            this.gÖRÜNÜMToolStripMenuItem.Enabled = false;
            this.gÖRÜNÜMToolStripMenuItem.Name = "gÖRÜNÜMToolStripMenuItem";
            this.gÖRÜNÜMToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.gÖRÜNÜMToolStripMenuItem.Text = "GÖRÜNÜM";
            this.gÖRÜNÜMToolStripMenuItem.Click += new System.EventHandler(this.gÖRÜNÜMToolStripMenuItem_Click);
            // 
            // dETAYLIToolStripMenuItem
            // 
            this.dETAYLIToolStripMenuItem.Checked = true;
            this.dETAYLIToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dETAYLIToolStripMenuItem.Name = "dETAYLIToolStripMenuItem";
            this.dETAYLIToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.dETAYLIToolStripMenuItem.Text = "DETAYLI";
            this.dETAYLIToolStripMenuItem.Click += new System.EventHandler(this.dETAYLIToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 14;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(176, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "ORAN :";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "5/10";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1/10",
            "2/10",
            "3/10",
            "4/10",
            "5/10",
            "6/10",
            "7/10",
            "8/10",
            "9/10",
            "10/10"});
            this.comboBox1.Location = new System.Drawing.Point(82, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(278, 104);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(215, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "KDV:";
            // 
            // Form1
            // 
            this.AcceptButton = this.hesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.temizle_button;
            this.ClientSize = new System.Drawing.Size(388, 408);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.temizle_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sonuc_textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayitextBox1);
            this.Controls.Add(this.hesapla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TEVKİFAT HESAPLAMA";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TextBox sayitextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sonuc_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button temizle_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hERZAMANENÜSTTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hERZAMANÜSTTETUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÖRÜNÜMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dETAYLIToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

