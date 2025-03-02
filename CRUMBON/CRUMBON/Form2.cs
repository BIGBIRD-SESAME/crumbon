using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUMBON
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(opennf);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void opennf(object obj)
        {
            Application.Run(new payloadMgr());
        }
    }
}
