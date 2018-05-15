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
    public partial class NewStudentForm : Form
    {
        private Classes c;
        public NewStudentForm(ref Classes c)
        {
            this.c = c;
            InitializeComponent();
            addButton.DialogResult = DialogResult.OK;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime d = datePick.Value;
            c.addStudent(new Student(txtName.Text,txtSurname.Text,new Date(d.Day+" "+d.Month+" "+d.Year)));
        }
    }
}
