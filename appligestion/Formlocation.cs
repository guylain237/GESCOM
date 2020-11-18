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
    public partial class Formlocation : Form
    {
        public Formlocation()
        {
            InitializeComponent();
        }
        string testobligatatoire()
        {
            if(textBoxnom.Text =="Nom materiel" || textBoxnom.Text == "")
            {
                return "entrer le nom du produit";
            }
            if(textBoxquantite.Text== "Quantite" || textBoxquantite.Text == "")
            {
                return "entrer la quantite";
            }
            return null;
        }

        private void textBoxnom_Enter(object sender, EventArgs e)
        {
                    if (textBoxnom.Text == "Nom materiel")
            {
                textBoxnom.Text = "";
                textBoxnom.ForeColor = Color.White;
            }
        }

        private void textBoxnom_Leave(object sender, EventArgs e)
        {

            if (textBoxnom.Text == "")
            {
                textBoxnom.Text = "Nom materiel";
                textBoxnom.ForeColor = Color.Silver;
            }
        }

        private void textBoxquantite_Enter(object sender, EventArgs e)
        {
            if (textBoxquantite.Text == "Quantite")
            {
                textBoxquantite.Text = "";
                textBoxquantite.ForeColor = Color.White;
            }
        }

        private void textBoxquantite_Leave(object sender, EventArgs e)
        {

            if (textBoxquantite.Text == "")
            {
                textBoxquantite.Text = "Quantite";
                textBoxquantite.ForeColor = Color.Silver;
            }
        }

        private void textBoxobserv_Leave(object sender, EventArgs e)
        {
            if (textBoxobserv.Text == "")
            {
                textBoxobserv.Text = "Observation";
                textBoxobserv.ForeColor = Color.Silver;
            }
        }

        private void textBoxobserv_Enter(object sender, EventArgs e)
        {
            if (textBoxobserv.Text == "Observation")
            {
                textBoxobserv.Text = "";
                textBoxobserv.ForeColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picturelocat.Image = Image.FromFile(op.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxnom.Text = "Nom materiel"; textBoxnom.ForeColor = Color.Silver;
            textBoxquantite.Text = "Quantite"; textBoxquantite.ForeColor = Color.Silver;
            textBoxobserv.Text = "Observation";textBoxobserv.ForeColor = Color.Silver;
            comboBox1.Text = "";
            picturelocat.Image = null;
        }

        private void textBoxquantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 ||e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (testobligatatoire() != null)
            {
                MessageBox.Show(testobligatatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxquantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void picturelocat_Click(object sender, EventArgs e)
        {

        }
    }
}
