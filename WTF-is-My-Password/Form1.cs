using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTF_is_My_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FindPass();
            frm.MdiParent = this;
            if (this.ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frm.Show();
        }

        private void addNewPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AddPass();
            frm.MdiParent = this;
            if (this.ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frm.Show();
        }
    }
}
