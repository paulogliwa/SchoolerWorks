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
    public partial class NewTeacherForm : Form
    {
        private School s;

        public NewTeacherForm(ref School s)
        {
            this.s = s;
            InitializeComponent();
            addButton.DialogResult = DialogResult.OK;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime d = datePick.Value;
            s.addTeacher(new Teacher(txtName.Text, txtSurname.Text, new Date(d.Day+" "+d.Month+" "+d.Year)));
        }
    }
}
