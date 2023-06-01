using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            progressBar1.Increment(4);
            Opacity -= 0.020;
            label1.Text = progressBar1.Value.ToString() + "%";

            if (Opacity == 0.0) 
            {
                timer1.Stop();
                this.Hide();
                FormLogin frmlogin = new FormLogin();
                frmlogin.ShowDialog();
            }*/


            pbTime.Increment(2);
            lblN.Text = "Created by Nacho Fonseca";

            if (pbTime.Value == pbTime.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Menu frmlogin = new Menu();
                frmlogin.Show();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("a.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
    }
}
