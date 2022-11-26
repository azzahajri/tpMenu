using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace tpform2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
  
        }
        Form2 f2;
        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

           if (f2 == null)
           {
               f2 = new Form2();
               f2.MdiParent = this;
               f2.FormClosed += f2_FormClosed;
               f2.Show();
           }
           {
               f2.Activate();
           } 
        }
        void f2_FormClosed(object sender, EventArgs e)
        {
            f2 = null;
        }
        Form3 f3;
        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.MdiParent = this;
                f3.FormClosed += f3_FormClosed;
                f3.Show();
            }
            {
                f3.Activate();
            }
        }
        void f3_FormClosed(object sender, EventArgs e)
        {
            f3 = null;
        }

        private void calculatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

      

        private void fermerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form[] c = this.MdiChildren;
            foreach (Form ch in c)
                ch.Close();
        }

        private void reduireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] c = this.MdiChildren;
            foreach (Form ch in c)
                ch.WindowState = FormWindowState.Minimized;
        }        

        private void agrantirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] c = this.MdiChildren;
            foreach (Form ch in c)
                ch.WindowState = FormWindowState.Normal;

        }

    }
}
