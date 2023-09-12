using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            double kdv = 0;
            kdv = Convert.ToDouble(numericUpDown1.Value) / 100 + 1;
            double sayi = 0;
            try
            {
                if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
                {
                    double carp1 = Convert.ToDouble(textBox1.Text);
                    double carp2 = Convert.ToDouble(textBox2.Text);
                    sayi = carp1 * carp2;
                    sayitextBox1.Text = sayi.ToString();
                    textBox1.Text=carp1.ToString();
                    textBox2.Text=carp2.ToString();
                    carp1 = -0;
                    carp2 = -0;

                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                sonuc_textBox1.Text = "HATA!";
            }
            
           
           
            try { sayi = double.Parse(sayitextBox1.Text); } catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            if (comboBox1.SelectedIndex==0)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.1)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.2)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.3)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.4)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 4)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.5)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 5)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.6)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 6)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.7)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 7)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.8)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 8)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 0.9)).ToString("n2");
            }
            if (comboBox1.SelectedIndex == 9)
            {
                sonuc_textBox1.Text = (sayi - ((sayi - (sayi / kdv)) * 1)).ToString("n2");
            }


            label5.Text = (sayi - Convert.ToDouble(sonuc_textBox1.Text)).ToString();
            label4.Visible = true;
            label5.Visible = true;
            this.ActiveControl = sayitextBox1;
            
            sonuc_textBox1.ReadOnly = true;



            if (kdvkayit!=numericUpDown1.Value)
            {
                WindowsFormsApp1.Properties.Settings.Default.kdvpc = Convert.ToDecimal(numericUpDown1.Value);
                Properties.Settings.Default.Save();
            }
            if (tevkifatkayit != comboBox1.SelectedIndex) 
            {
                Properties.Settings.Default.tevkifatpc = comboBox1.SelectedIndex;
                Properties.Settings.Default.Save();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void sonuclabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public decimal kdvkayit = 0;
        public int tevkifatkayit = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            numericUpDown1.Value = Properties.Settings.Default.kdvpc;
            this.ActiveControl = sayitextBox1;
            this.TopMost = Class1.usttetut;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = Properties.Settings.Default.tevkifatpc;
            numericUpDown1.Maximum = 100;
            numericUpDown1.Minimum = 1;
            
            kdvkayit = WindowsFormsApp1.Properties.Settings.Default.kdvpc;
            tevkifatkayit = Properties.Settings.Default.tevkifatpc;
        }

    

        private void temizle_button_Click(object sender, EventArgs e)
        {
            sayitextBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            
            
        }

        
        private void hERZAMANÜSTTETUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hERZAMANÜSTTETUTToolStripMenuItem.Checked == true)
            {
                
                hERZAMANÜSTTETUTToolStripMenuItem.Checked = false;
                this.TopMost = false;
                Class1.usttetut = false;
            }
            else if (hERZAMANÜSTTETUTToolStripMenuItem.Checked == false)
            {
                
                hERZAMANÜSTTETUTToolStripMenuItem.Checked = true;
                this.TopMost = true;
                Class1.usttetut = true;
            }
        }

        private void dETAYLIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dETAYLIToolStripMenuItem.Checked == true)
            {

                dETAYLIToolStripMenuItem.Checked = false;
                Form2 frm = new Form2();
                frm.TopMost = Class1.usttetut;
                frm.Show();
                this.Hide();
            }
            else if (dETAYLIToolStripMenuItem.Checked == false)
            {

                dETAYLIToolStripMenuItem.Checked = true;
                Form1 frm1 = new Form1();
                frm1.TopMost = Class1.usttetut;
                frm1.Show();
                this.Hide();
            }
        }
        private void sayitextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void hERZAMANENÜSTTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gÖRÜNÜMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sonuc_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

       


        /*
private void textbox1_KeyDown(object sender, KeyEventArgs e)
{
if (e.KeyCode == Keys.Delete)
{
sayitextBox1 = " ";
}

if (e.KeyCode == Keys.Delete)
{
sayitextBox1 = " ";

}
}*/
    }
}
