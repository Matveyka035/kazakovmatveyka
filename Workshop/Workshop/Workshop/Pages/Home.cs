﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop.Pages
{
    public partial class Home : Form
    {
        Main mainpage;
        public Home(Main main)
        {
            InitializeComponent();
            mainpage = main;
        }
    }
}
