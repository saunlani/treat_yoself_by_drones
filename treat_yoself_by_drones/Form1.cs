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

    public partial class Form1 : Form
    {
        public static string txtInput;
        private int haircut = 0;
        private int shave = 0;
        private int manicure = 0;
        private int pedicure = 0;
        private int massage = 0;
        private int wax = 0;
        private int whitening = 0;
        private int accupuncture = 0;
        private int dbrush = 0;
        private int lotion = 0;
        private int hgel = 0;
        private int palosan = 0;
        double[] itemcost = new double[12];

        double iTax, iSubTotal, iTotal;

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            haircut++;
            textBox1.Text = haircut.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            whitening++;
            textBox7.Text = whitening.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            accupuncture++;
            textBox8.Text = accupuncture.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            hgel++;
            textBox11.Text = hgel.ToString();
      
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            palosan++;
            textBox12.Text = palosan.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to exit?", "Treat YoSelf by Drone", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }
        //== ==============================RESET===================================
        public void ResetTextBox()
        {
        haircut = 0;
        shave = 0;
        manicure = 0;
        pedicure = 0;
        massage = 0;
        wax = 0;
        whitening = 0;
        accupuncture = 0;
        dbrush = 0;
        lotion = 0;
        hgel = 0;
        palosan = 0;
        Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";

                    else
                        func(control.Controls);
            };
            func(Controls);

        }
        //========================================================================

        //== ==============================Enable===================================
        public void EnableTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);

        }
        //========================================================================
        private void button14_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            EnableTextBox();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shave++;
            textBox2.Text = shave.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manicure++;
            textBox3.Text = manicure.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pedicure++;
            textBox4.Text = pedicure.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            massage++;
            textBox5.Text = massage.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            wax++;
            textBox6.Text = wax.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dbrush++;
            textBox9.Text = dbrush.ToString();
        }

        //total button
        private void button13_Click(object sender, EventArgs e)
        {
            //declare tax rate
            double Tax_rate = 0.06;

            //cost of each item 
            itemcost[0] = Convert.ToDouble(textBox1.Text) * 15;
            itemcost[1] = Convert.ToDouble(textBox2.Text) * 10;
            itemcost[2] = Convert.ToDouble(textBox3.Text) * 15;
            itemcost[3] = Convert.ToDouble(textBox4.Text) * 40;
            itemcost[4] = Convert.ToDouble(textBox5.Text) * 50;
            itemcost[5] = Convert.ToDouble(textBox6.Text) * 45;
            itemcost[6] = Convert.ToDouble(textBox7.Text) * 25;
            itemcost[7] = Convert.ToDouble(textBox8.Text) * 80;
            itemcost[8] = Convert.ToDouble(textBox9.Text) * 5;
            itemcost[9] = Convert.ToDouble(textBox10.Text) * 10;
            itemcost[10] = Convert.ToDouble(textBox11.Text) * 10;
            itemcost[11] = Convert.ToDouble(textBox12.Text) * 5;


            // calculates subtotal and sends to subtotal box
            iSubTotal = itemcost.Sum();
            iTax = iSubTotal * Tax_rate;
            double iGrandTotal = (iTax + iSubTotal);
            textBox15.Text = Convert.ToString("$"+iSubTotal);
            textBox14.Text = Convert.ToString("$" + iTax);
            textBox13.Text = Convert.ToString("$" + iGrandTotal);

        }

        private void textBox15_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged_1(object sender, EventArgs e)
        {

        }



        private void textBox13_TextChanged_2(object sender, EventArgs e)
        {
            
            txtInput=textBox13.Text;

        
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Checkout checkoutscreen = new Checkout();
            checkoutscreen.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lotion++;
            textBox10.Text = lotion.ToString();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
