﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolerWorks
{
    public partial class NewClassForm : Form
    {
        private School s;
        public NewClassForm(ref School s)
        {
            this.s = s;
            InitializeComponent();
            addButton.DialogResult = DialogResult.OK;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            s.addClass(new Classes(int.Parse(txtYear.Text),txtType.Text,txtProfile.Text));
        }
    }
}
