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
    public partial class NewSchoolForm : Form
    {
        private Form parent;
        public NewSchoolForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SchoolForm sf = new SchoolForm(txtName.Text,txtCity.Text);
            sf.MdiParent = parent;
            sf.Show();
            this.Close();
        }
    }
}
