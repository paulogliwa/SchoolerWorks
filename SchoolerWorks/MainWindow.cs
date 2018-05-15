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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nowaSzkolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSchoolForm nsf = new NewSchoolForm(this);
            nsf.Show();

        }

        private void wczytajSzkoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sfd = new FolderBrowserDialog();
            if (sfd.ShowDialog() == DialogResult.OK && sfd.SelectedPath != "")
            {
                SchoolFactory sf = new SchoolFactory(sfd.SelectedPath);
                SchoolForm sForm = new SchoolForm(sf.Open(), sfd.SelectedPath.Remove(sfd.SelectedPath.LastIndexOf('\\')));
                sForm.MdiParent = this;
                sForm.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano pliku", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void oMnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paulo Gliwa \n15015@student.pwsz.elblag.pl \npaulo.gliwa@gmail.com", "O mnie",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
