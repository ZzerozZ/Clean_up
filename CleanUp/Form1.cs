﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr.exe");
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\Games\\Garena Plus\\GarenaMessenger.exe");
        }
    }
}
