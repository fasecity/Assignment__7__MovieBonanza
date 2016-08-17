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
            this.Close();
        }
    }
}
