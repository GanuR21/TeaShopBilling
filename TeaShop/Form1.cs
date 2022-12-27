using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //#region InitializationOfVariables
            //int PricePerTea = 12;
            //int PricePerCoffee = 15;
            //int PricePerVada = 6;
            //int PricePerCigarette = 10;
            //int PricePerBiscuit = 10;
            //int PricePerPakoda = 20;
            //int BillAmount = 0;
            //#endregion

            TeaBilling a = new TeaBilling();


            listBox1.Items.Clear();
            listBox1.Items.Add("  Welcome to Ee Saala Coffee Namde");

            if (checkBox1.Checked)
            {
                int capacity = (int)numericUpDown1.Value;
                capacity = capacity * a.PricePerTea1; 
                listBox1.Items.Add("TEA              :  " + capacity);
                a.BillAmount1 += capacity;
            }

            if (checkBox2.Checked)
            {
                int capacity = (int)numericUpDown2.Value;
                capacity = capacity * a.PricePerCoffee1;
                listBox1.Items.Add("COFFEE         :  " + capacity);
                a.BillAmount1 += capacity;

            } 

            if (checkBox3.Checked)
            {
                int capacity = (int)numericUpDown3.Value;
                capacity = capacity * a.PricePerBiscuit1;
                listBox1.Items.Add("BISCUIT       :  " + capacity);
                a.BillAmount1 += capacity;

            }

            if (checkBox4.Checked)
            {
                int capacity = (int)numericUpDown4.Value;
                capacity = capacity * a.PricePerVada1;
                listBox1.Items.Add("VADA           :  " + capacity);
                a.BillAmount1 += capacity;

            }

            if (checkBox5.Checked)
            {
                int capacity = (int)numericUpDown5.Value;
                capacity = capacity * a.PricePerCigarette1;
                listBox1.Items.Add("CIGARETTE   : " + capacity);
                a.BillAmount1 += capacity;

            }

            if (checkBox6.Checked)
            {
                int capacity = (int)numericUpDown6.Value;
                capacity = capacity * a.PricePerPakoda1;
                listBox1.Items.Add("PAKODA       :  " + capacity);
                a.BillAmount1 += capacity;

            }

            listBox1.Items.Add("TOTAL BILL : " + a.BillAmount1);
        }
    }
}
