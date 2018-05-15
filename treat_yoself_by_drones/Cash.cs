using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treat_yoself_by_drones
{
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
            string getForm1Value;
            getForm1Value = Form1.txtInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to complete this order?", "Treat YoSelf by Drone", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
                Confirmed screen = new Confirmed();
                screen.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkout checkoutscreen = new Checkout();
            checkoutscreen.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string getForm1Value;
            getForm1Value = Form1.txtInput;
        }
    }
}
