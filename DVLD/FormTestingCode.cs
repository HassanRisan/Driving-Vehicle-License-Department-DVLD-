﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using DVLD.Applications;

namespace DVLD
{
    public partial class FormTestingCode : Form
    {
        public FormTestingCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTestTypes form = new FormTestTypes();
            form.ShowDialog();

        }
    }
}
