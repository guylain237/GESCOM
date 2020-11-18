using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appligestion
{
    public partial class Form2 : Form
    {
        private  bool closed = true;
        public Form2()
        {
            InitializeComponent();
            checkBox1.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butok_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "root")
                {
                    Form3 page = new Form3();
                    page.Show();
                    this.Hide();
                }
                else label5.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
