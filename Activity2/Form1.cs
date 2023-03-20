using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listbox_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wishlist.Items.Add("House");
            wishlist.Items.Add("Billion Dollars");
            wishlist.Items.Add("Yacht");
            wishlist.Items.Add("Private Island");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           textBox2.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = wishlist.Text;
        }
    }
}
