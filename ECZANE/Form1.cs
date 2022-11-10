using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECZANE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastalarfrm frmhasta = new hastalarfrm();
            frmhasta.Show();
        }

        private void hastanelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dghastaneler frmhstn = new dghastaneler();
            frmhstn.Show();

        }

        private void ilaçÇeşitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İlaç_çeşitfrm frmilçç = new İlaç_çeşitfrm();
            frmilçç.Show();
        }
    }
}
