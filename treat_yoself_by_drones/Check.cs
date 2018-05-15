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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkout checkoutscreen = new Checkout();
            checkoutscreen.ShowDialog();
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
    }
}
