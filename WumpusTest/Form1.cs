﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private GameControl _GameControl;
        private void ConstructorButton_Click(object sender, EventArgs e)
        {
           
            _GameControl = new GameControl();
        }
    }
}
