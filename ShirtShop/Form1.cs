﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShirtShop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            var database = new DatabaseRepository();
            database.GetAllHats();
        }
    }
}
