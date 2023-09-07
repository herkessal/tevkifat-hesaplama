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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        


        private void hERZAMANÜSTTETUTToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            if (dETAYLIToolStripMenuItem.Checked == false)
            {

                dETAYLIToolStripMenuItem.Checked = true;
                Form1 frm1 = new Form1();
                frm1.TopMost = Class1.usttetut;
                frm1.Show();
                this.Hide();
            }
            else if (dETAYLIToolStripMenuItem.Checked == true)
            {

                dETAYLIToolStripMenuItem.Checked = false;
                Form2 frm2 = new Form2();
                frm2.TopMost = Class1.usttetut;
                frm2.Show();
                this.Hide();
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = Class1.usttetut;
        }
    }
}
