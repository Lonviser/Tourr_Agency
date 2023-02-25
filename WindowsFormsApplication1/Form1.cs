using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void страныToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void гостиницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void прайслистToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void лучшиеКлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clients form = new Clients();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Turi form = new Turi();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Prodazhi form = new Prodazhi();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotels form = new Hotels();
            form.ShowDialog();
        }
    }
}
