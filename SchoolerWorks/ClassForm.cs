using System;
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
    public partial class ClassForm : Form
    {
        private Classes c;
        private SchoolForm f;
        public ClassForm(Classes c, Form f)
        {
            this.c = c;
            this.f = (SchoolForm)f;
            InitializeComponent();
            refreshWindow();
        }

        public void refreshWindow()
        {
            StudentsList.DataSource = null;
            StudentsList.DataSource = c.Students;
            txtHigh.Text = c.avgHighest().ToString();
            txtLow.Text = c.avgLowest().ToString();
            txtGroupAVG.Text = c.avg().ToString();
            txtFailers.Text = c.failers().ToString();
            labelName.Text = c.Year.ToString() + c.Type;
            labelProfile.Text = c.Profile;
            f.refreshWindow();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewStudentForm nsf = new NewStudentForm(ref c);
            if(nsf.ShowDialog() == DialogResult.OK)
            {
                refreshWindow();
            }
            else
            {
                MessageBox.Show("Anulowano", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            c.removeStudent((Student)StudentsList.SelectedItem);
            refreshWindow();
        }

        private void StudentsList_DoubleClick(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm((Student)StudentsList.SelectedItem, this);
            sf.MdiParent = this.MdiParent;
            sf.Show();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return && ((TextBox)sender).Tag.ToString() == "name")
            {
                c.Year = int.Parse(txtName.Text[0].ToString());
                c.Type = txtName.Text[1].ToString();
                txtName.Visible = false;
                refreshWindow();
            }
            if (e.KeyCode == Keys.Return && ((TextBox)sender).Tag.ToString() == "profile")
            {
                c.Profile = txtProfile.Text;
                txtProfile.Visible = false;
                refreshWindow();
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            if(((Label)sender).Tag.ToString() == "name")
            {
                txtName.Visible = true;
                txtName.Text = labelName.Text;
            }
            if (((Label)sender).Tag.ToString() == "profile")
            {
                txtProfile.Visible = true;
                txtProfile.Text = labelProfile.Text;
            }
        }
    }
}
