using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appligestion
{
    public partial class User_mat_location : UserControl
    {
        private static User_mat_location userlocation;
        public static User_mat_location Instance
        {
            get
            {
                if (userlocation == null)
                {
                    userlocation = new User_mat_location();
                } return userlocation;
            }
        }

        public User_mat_location()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "recherche")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "recherche";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void buttonsupprim_Click(object sender, EventArgs e)
        {

        }

        private void buttonajout_Click(object sender, EventArgs e)
        {
            Formlocation ajout = new Formlocation();
            ajout.ShowDialog();
        }

        private void buttonmodif_Click(object sender, EventArgs e)
        {
            Formlocation modifier = new Formlocation();
            modifier.labeltitre.Text = "modifier materiel";
            modifier.buttonactual.Visible = false;
            modifier.ShowDialog();
        }
    }
}
