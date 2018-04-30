using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBox
{
    public partial class ChatBoxForm : Form
    {
        public ChatBoxForm()
        {
            InitializeComponent();
        }

       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(FnametextBox4.Text + ":  " + FirsttextBox1.Text);

                string s = timelabel4.Text = DateTime.Now.ToLongTimeString();
                listBox1.Items.Add(s);

                FirsttextBox1.Clear();
                FirsttextBox1.Focus();
                //textBox2.Text = textBox1.Text;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(SnametextBox3.Text + ":  " + SecondtextBox2.Text);

                string s = timelabel4.Text = DateTime.Now.ToLongTimeString();
                listBox1.Items.Add(s);

                SecondtextBox2.Clear();
                SecondtextBox2.Focus();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isEmpty())
            {
                FnametextBox4.Enabled = false;
                fnamelabel3.Text = FnametextBox4.Text;
                SnametextBox3.Enabled = false;
                Snamelabel3.Text = SnametextBox3.Text;

                FirsttextBox1.Enabled = true;
                SecondtextBox2.Enabled = true;
                FirsttextBox1.Focus();
            }
        }




        private bool isEmpty()
        {
            if (FnametextBox4.Text == string.Empty)
            {
                MessageBox.Show("First Name is Required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FnametextBox4.Focus();
                return false;
            }
            if (SnametextBox3.Text == string.Empty)
            {
                MessageBox.Show("Second Name is Required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SnametextBox3.Focus();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FnametextBox4.Clear();
            SnametextBox3.Clear();
            listBox1.Items.Clear();
            FirsttextBox1.Clear();
            fnamelabel3.Text = string.Empty;
            Snamelabel3.Text = string.Empty;
            SecondtextBox2.Clear();
            FnametextBox4.Focus();
            FirsttextBox1.Enabled = false;
            SecondtextBox2.Enabled = false;
            FnametextBox4.Enabled = true;
            SnametextBox3.Enabled = true;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Chat Box Developing By Hassan Malik \nMcs IUB BahawalNagar Campus \nContact: 0334-9055786", "AboutUs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
