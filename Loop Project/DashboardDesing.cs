using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop_Project
{
    public partial class DashboardDesing : Form
    {
        public DashboardDesing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmWhileLoop whileLoop = new frmWhileLoop();
            Hide();
            whileLoop.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmForLoop forLoop = new FrmForLoop();
            Hide();
            forLoop.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDo__While_loop do__While_Loop = new FrmDo__While_loop();
            Hide();
            do__While_Loop.Show();
        }
    }
}
