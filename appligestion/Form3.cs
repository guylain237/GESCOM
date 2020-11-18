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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panelpointe.Size = new Size(229, 612);
           // panelparametre.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form4 stock = new Form4();
            //stock.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

       

        private void button1LOCAT_Click(object sender, EventArgs e)
        {
            panelpointe.Top = buttonLOCAT.Top;
            if (!panelaffiche.Controls.Contains(User_mat_location.Instance)){ 
            
                panelaffiche.Controls.Add(User_mat_location.Instance);
                User_mat_location.Instance.Dock = DockStyle.Fill;
                User_mat_location.Instance.BringToFront();
            }else
            { User_mat_location.Instance.BringToFront(); }

        }
            private void buttonVENTE_Click(object sender, EventArgs e)
        {
            panelpointe.Top -= buttonVENTE.Top;
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(panelpointe.Width==229)
            {
                panelpointe.Size = new Size(82, 612);

            }
            else
            {
                panelpointe.Size = new Size(229, 312);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           //panelparametre.Size = new Size(313, 175);
           // panelparametre.Visible = !panelparametre.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 connexion = new Form2();
            connexion.Show();
        }

        private void panelaffiche_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (panelpointe.Width == 229)
            {
                panelpointe.Size = new Size(82, 612);

            }
            else
            {
                panelpointe.Size = new Size(229, 312);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonVENTE_Click_1(object sender, EventArgs e)
        {

        }
    }
}
