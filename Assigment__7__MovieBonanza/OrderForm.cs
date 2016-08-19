using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Assignment 7 : Movie bonanza
/// Mohamoud Mohamed
/// 300 435 435
/// v.1
/// </summary>
namespace Assigment__7__MovieBonanza
{
    public partial class OrderForm : Form
    {
        //public properties
        public Form1 Form1Prop { get; set; }
        /// <summary>
        /// constructor
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// back button shows selection form1 and hides order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //converting the string val in subtotal box to get tax by *.13
             double tax = Convert.ToDouble(SubtotaltextBox.Text) * 0.13;
           tax = Math.Round(tax, 2);
            
            SubtotaltextBox.Text = tax.ToString();

            double subtotes = Convert.ToDouble(CostTextBox2.Text);
            subtotes = Math.Round(subtotes, 2);
            AddtenTextbox.Text = subtotes.ToString();
            
            //dday is a variable to group the total cost 
                double dday = tax + subtotes;
                GrandTotalTextBox.Text = dday.ToString();
            

            

           
            
        }
        /// <summary>
        /// when the checbox is checked this method adds 10 dollars if true
        /// and doesnt do anything if false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// closes current form and opens previous one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Form1Prop.Show();
            this.Close();
        }
        /// <summary>
        /// displays about box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //insatiate
            AboutBox aboutbox = new AboutBox();
            //show dialog
            aboutbox.ShowDialog();
        }
        /// <summary>
        /// when stream button is clicked this method closes current form and 
        /// displays the stream form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            //initialize streamform object
            StreamForm streamform = new StreamForm();
            //call
            streamform.orderformprop1 = this;
            //pass data
            streamform.StreamCosttextBox1.Text = GrandTotalTextBox.Text;
            streamform.StreamTitletextBox2.Text = TitleTextBox2.Text;
            //open and close
            streamform.Show();
            this.Hide();

        }
        /// <summary>
        /// msg box to show user that he/she has printed order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Your order is printing");
        }
    }
}
