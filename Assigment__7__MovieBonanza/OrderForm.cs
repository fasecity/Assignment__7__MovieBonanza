using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment__7__MovieBonanza
{
    public partial class OrderForm : Form
    {
        public Form1 Form1Prop { get; set; }
        public OrderForm()
        {
            InitializeComponent();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Form1Prop.Show();
            this.Hide();
        }

        private void SubtotaltextBox_TextChanged(object sender, EventArgs e)
        {
           
           

            
            
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
             double tax = Convert.ToDouble(SubtotaltextBox.Text) * 0.13;
           tax = Math.Round(tax, 2);
            SubtotaltextBox.Text = tax.ToString();
            double subtotes = Convert.ToDouble(CostTextBox2.Text);
            subtotes = Math.Round(subtotes, 2);
            AddtenTextbox.Text = subtotes.ToString();
            //if (string.IsNullOrEmpty(GrandTotalTextBox.Text)
            
                double dday = tax + subtotes;
                GrandTotalTextBox.Text = dday.ToString();
            

            

           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==true)
            {
                double subtotes = Convert.ToDouble(CostTextBox2.Text);
                subtotes = subtotes + 10;
                subtotes = Math.Round(subtotes, 2);
                AddtenTextbox.Text = subtotes.ToString();

                double tax = Convert.ToDouble(SubtotaltextBox.Text) * 0.13;
                tax = Math.Round(tax, 2);
                double dday = tax + subtotes;
                GrandTotalTextBox.Text = dday.ToString();
            }
            if (checkBox1.Checked == false)
            {
                double subtotes = Convert.ToDouble(CostTextBox2.Text);
               
                subtotes = Math.Round(subtotes, 2);
                AddtenTextbox.Text = subtotes.ToString();

                double tax = Convert.ToDouble(SubtotaltextBox.Text) * 0.13;
                tax = Math.Round(tax, 2);
                double dday = tax + subtotes;
                GrandTotalTextBox.Text = dday.ToString();
            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Form1Prop.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
