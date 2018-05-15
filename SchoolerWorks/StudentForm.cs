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
    public partial class StudentForm : Form
    {
        private Student s;
        private ClassForm f;

        public StudentForm(Student s, ClassForm f)
        {
            InitializeComponent();
            this.s = s;
            this.f = f;
            Text = f.Text + ": uczeń";
            displayControls();
        }

        private void displayControls()
        {
            int top = 5;
            int left = 15;
            int width = 23;

            foreach(Courses c in s.Marks.Keys)
            {
                gradesPanel.Controls.Add(
                    createButton("+", top, left, width, c.ToString())
                    );

                gradesPanel.Controls.Add(
                    createButton("-", top, left+width+2, width, c.ToString())
                    );

                gradesPanel.Controls.Add(
                    createTextBox(
                        top, 
                        left+width*2+2,
                        gradesPanel.Width-width-150,
                        c.ToString()
                        )
                    );

                gradesPanel.Controls.Add(
                    createLabel(
                        "średnia:",
                        top,
                        left + width * 2 + 2 + (gradesPanel.Width - width - 150) + 2,
                        c.ToString()
                        )
                    );

                top += width + 2;
            }
            refreshWindow();
        }

        private Label createLabel(string text, int top, int left, string tag)
        {
            Label l = new Label();
            l.Text = text;
            l.Top = top;
            l.Left = left;
            l.Tag = tag;
            l.Anchor = AnchorStyles.Top;

            return l;
        }

        private Button createButton(string text, int top, int left, int w, string tag)
        {
            Button button = new Button();
            button.Width = w;
            button.Text = text;
            button.Left = left;
            button.Top = top;
            button.Tag = tag;
            button.Anchor = AnchorStyles.Top;
            if(text == "+")
                button.Click += new System.EventHandler(this.addGrade_buttonClick);
            else
                button.Click += new System.EventHandler(this.removeGrade_buttonClick);
            
            return button;
        }

        private TextBox createTextBox(int top, int left, int w, string tag)
        {
            TextBox tb = new TextBox();
            tb.Width = w;
            tb.Left = left;
            tb.Top = top;
            tb.Tag = tag;
            tb.ReadOnly = true;
            tb.Anchor = AnchorStyles.Top;

            return tb;
        }

        private void refreshWindow()
        {
            foreach (Control c in gradesPanel.Controls)
            {
                if(c is TextBox)
                {
                    Courses co;
                    Enum.TryParse(c.Tag.ToString(), out co);
                    ((TextBox)c).Text = s.courseGradesAsString(co);
                }

                if(c is Label)
                {
                    Courses co;
                    Enum.TryParse(c.Tag.ToString(), out co);
                    ((Label)c).BackColor = (s.courseAvg(co)<2.0) ? Color.OrangeRed : SystemColors.Control;
                    ((Label)c).Text = "średnia: " + s.courseAvg(co);
                }
            }

            txtAvg.Text = s.avg().ToString();
            txtFails.Text = s.fails().ToString();
            labelFullName.Text = s.Name + " " + s.Surname;
            labelDOB.Text = s.DOB.ToString();
            f.refreshWindow();
        }

        private void addGrade_buttonClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(b != null)
            {
                Courses co;
                Enum.TryParse(b.Tag.ToString(), out co);
                s.addMark(co, int.Parse(txtGrade.Text));
            }
            refreshWindow();
        }

        private void removeGrade_buttonClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                Courses co;
                Enum.TryParse(b.Tag.ToString(), out co);
                s.removeMark(co, int.Parse(txtGrade.Text));
            }
            refreshWindow();
        }
        private void label_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Tag.ToString() == "name")
            {
                txtName.Visible = true;
                txtName.Text = labelFullName.Text;
            }
            if (((Label)sender).Tag.ToString() == "date")
            {
                txtDate.Visible = true;
                txtDate.Text = labelDOB.Text;
            }
        }
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((TextBox)sender).Tag.ToString() == "name")
            {
                string name = txtName.Text;
                string[] x = name.Split(' ');
                s.Name = x[0];
                s.Surname = x[1];
                txtName.Visible = false;
                refreshWindow();
            }
            if (e.KeyCode == Keys.Return && ((TextBox)sender).Tag.ToString() == "date")
            {
                s.DOB = new Date(txtDate.Text);
                txtDate.Visible = false;
                refreshWindow();
            }
        }
    }
}
