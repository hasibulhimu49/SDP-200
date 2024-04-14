using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Startpoint = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Startpoint += 50;
            progressBar1.Value = Startpoint; 
            Percentags.Text = Startpoint + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                Timer1.Stop();
                Login Obj = new Login();
                this.Hide();
                Obj.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }
    }
}
