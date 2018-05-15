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
    public partial class SchoolForm : Form
    {
        private string savePath;
        private School s;

        public SchoolForm(string name, string city)
        {
            InitializeComponent();
            this.s = new School(name,city);
            savePath = "";
            refreshWindow();
        }

        public SchoolForm(School s, string savePath)
        {
            InitializeComponent();
            this.s = s;
            schoolName.Text = s.Name;
            schoolCity.Text = s.City;
            this.savePath = savePath;
            refreshWindow();
        }

        public SchoolForm(string name, string city, string savePath)
        {
            InitializeComponent();
            this.s = new School(name, city);
            schoolName.Text = s.Name;
            schoolCity.Text = s.City;
            this.savePath = savePath;
            refreshWindow();
        }

        public void refreshWindow()
        {
            txtClassCount.Text = s.countClasses().ToString();
            txtStudentCount.Text = s.countStudents().ToString();
            ClassesList.DataSource = null;
            ClassesList.DataSource = s.Classes;
            StudentsList.DataSource = null;
            StudentsList.DataSource = s.Students;
            TeachersList.DataSource = null;
            TeachersList.DataSource = s.Teachers;
            schoolName.Text = s.Name;
            schoolCity.Text = s.City;
        }

        private void classAdd_Click(object sender, EventArgs e)
        {
            NewClassForm ncf = new NewClassForm(ref s);
            if (ncf.ShowDialog() == DialogResult.OK)
            {
                refreshWindow();
            }
            else
            {
                MessageBox.Show("Anulowano", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void classesList_DoubleClick(object sender, EventArgs e)
        {
            ClassForm cf = new ClassForm((Classes)ClassesList.SelectedItem, this);
            cf.MdiParent = this.MdiParent;
            cf.Text = s.Name + ": klasa";
            cf.Show();
        }

        private void teacherAdd_Click(object sender, EventArgs e)
        {
            NewTeacherForm ntf = new NewTeacherForm(ref s);
            if(ntf.ShowDialog() == DialogResult.OK)
            {
                refreshWindow();
            }
            else
            {
                MessageBox.Show("Anulowano", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(savePath == "")
            {
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if(sfd.ShowDialog() == DialogResult.OK && sfd.SelectedPath != "")
                {
                    savePath = sfd.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Nie wybrano pliku", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            SchoolFactory sf = new SchoolFactory(s, savePath);
            if(sf.Save())
            {
                MessageBox.Show("Zapisano", "Sukces",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cos nie dziala", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((TextBox)sender).Tag.ToString() == "name")
            {
                s.Name = txtName.Text;
                txtName.Visible = false;
                refreshWindow();
            }
            if (e.KeyCode == Keys.Return && ((TextBox)sender).Tag.ToString() == "city")
            {
                s.City = txtCity.Text;
                txtCity.Visible = false;
                refreshWindow();
            }
        }
        private void label_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Tag.ToString() == "name")
            {
                txtName.Visible = true;
                txtName.Text = schoolName.Text;
            }
            if (((Label)sender).Tag.ToString() == "city")
            {
                txtCity.Visible = true;
                txtCity.Text = schoolCity.Text;
            }
        }
    }
}
