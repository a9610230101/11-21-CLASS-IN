﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TurnLightON()
        {
            lightonpicturebox.Visible = true;
            lightoffpicturebox.Visible = false;
            lightstatelbel.Text = "ON";
        }
        private void TurnLightOFF()
        {
            lightonpicturebox.Visible = true;
            lightoffpicturebox.Visible = false;
            lightstatelbel.Text = "ON";
        }

        private void light_Click(object sender, EventArgs e)
        {
            if(lightonpicturebox.Visible==true)
            {
                TurnLightOFF();
            }
            else
            {
                TurnLightON();
            }
        }

        private void lightstatelbel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
