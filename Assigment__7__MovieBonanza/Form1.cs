using Assigment__7__MovieBonanza.Properties;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when the list box index is selected the the data from it is
        /// is changed in cost,picbox and category using if conditional staments
        /// to pass in a string to them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if statments that use the listbox index selected
            //to pass  string data  to catagory image and title
            TitleTextBox.Text = listBox1.SelectedItem.ToString();
            if (listBox1.SelectedIndex == 0)
            {    
                CategoryTextBox.Text = "comedy";
                Convert.ToDouble(CostTextBox.Text = "1.99");
                pictureBox1.Image = Resources.cedarrapids;
            }
            if (listBox1.SelectedIndex == 1)
            {
                CategoryTextBox.Text = "action";
                CostTextBox.Text = "2.99";
                pictureBox1.Image = Resources.companymen;
            }
            if (listBox1.SelectedIndex == 3)
            {
                CategoryTextBox.Text = "action";
                CostTextBox.Text = "2.99";
                pictureBox1.Image = Resources.deathrace2;
            }
            if (listBox1.SelectedIndex == 4)
            {
                CategoryTextBox.Text = "new releases";
                CostTextBox.Text = "4.99";
                pictureBox1.Image = Resources.footloose;
            }
            if (listBox1.SelectedIndex == 5)
            {
                CategoryTextBox.Text = "family";
                CostTextBox.Text = "0.99";
                pictureBox1.Image = Resources.gnomeoandjuliet;
            }
            if (listBox1.SelectedIndex == 6)
            {
                CategoryTextBox.Text = "sci-fi";
                CostTextBox.Text = "1.99";
                pictureBox1.Image = Resources.iamnumberfour;
            }
            if (listBox1.SelectedIndex == 7)
            {
                CategoryTextBox.Text = "comedy";
                CostTextBox.Text = "1.99";
                pictureBox1.Image = Resources.justgowithit;
            }
            if (listBox1.SelectedIndex == 8)
            {
                CategoryTextBox.Text = "comedy";
                CostTextBox.Text = "1.99";
                pictureBox1.Image = Resources.nostringsattached;
            }
            if (listBox1.SelectedIndex == 9)
            {
                CategoryTextBox.Text = "action";
                CostTextBox.Text = "2.99";
                pictureBox1.Image = Resources.sanctum;
            }
            if (listBox1.SelectedIndex == 10)
            {
                CategoryTextBox.Text = "sci-fi";
                CostTextBox.Text = "2.99";
                pictureBox1.Image = Resources.seasonofthewitch;
            }
            if (listBox1.SelectedIndex == 11)
            {
                CategoryTextBox.Text = "comedy";
                CostTextBox.Text = "1.99";
                pictureBox1.Image = Resources.thedilemma;
            }
            if (listBox1.SelectedIndex == 12)
            {
                CategoryTextBox.Text = "action";
                CostTextBox.Text = "2.99";
                pictureBox1.Image = Resources.theeagle;
            }
            if (listBox1.SelectedIndex == 13)
            {
                CategoryTextBox.Text = "action";
                CostTextBox.Text = "2.99";
                pictureBox1.Image = Resources.thegreenhornet;
            }
            if (listBox1.SelectedIndex == 14)
            {
                CategoryTextBox.Text = "action";
                CostTextBox.Text = "2.99";
                pictureBox1.Image = Resources.themechanic;
            }
            if (listBox1.SelectedIndex == 15)
            {
                CategoryTextBox.Text = "action";
                CostTextBox.Text = "2.99";
                pictureBox1.Image = Resources.theotherwoman;
            }
            if (listBox1.SelectedIndex == 16)
            {
                CategoryTextBox.Text = "horror";
                CostTextBox.Text = "1.99";
                pictureBox1.Image = Resources.therite;
            }
            if (listBox1.SelectedIndex == 17)
            {
                CategoryTextBox.Text = "thriller";
                CostTextBox.Text = "1.99";
                pictureBox1.Image = Resources.theroommate;
            }
            if (listBox1.SelectedIndex == 18)
            {
                CategoryTextBox.Text = "drama";
                CostTextBox.Text = "1.99";
                pictureBox1.Image = Resources.thewayback;
            }
            else if (listBox1.SelectedIndex == 19)
            {
                CategoryTextBox.Text = "drama";
                CostTextBox.Text = "1.99";
                pictureBox1.Image = Resources.waitingforever;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //initialize
            OrderForm orderForm = new OrderForm();
            //call
            orderForm.Form1Prop = this;
            //pass data and open new form and hide form1
            orderForm.TitleTextBox2.Text = listBox1.SelectedItem.ToString();
            orderForm.CategoryTextBox2.Text = CategoryTextBox.Text;
            orderForm.pictureBox2.Image = pictureBox1.Image;
            orderForm.SubtotaltextBox.Text = CostTextBox.Text;
            orderForm.CostTextBox2.Text = CostTextBox.Text;
            orderForm.Show();
            this.Hide();
        }
        /// <summary>
        /// this sets the default so an index is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }
    }
}
