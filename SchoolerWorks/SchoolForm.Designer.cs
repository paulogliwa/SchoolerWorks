namespace SchoolerWorks
{
    partial class SchoolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolForm));
            this.schoolName = new System.Windows.Forms.Label();
            this.schoolCity = new System.Windows.Forms.Label();
            this.menuSchool = new System.Windows.Forms.MenuStrip();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolTabs = new System.Windows.Forms.TabControl();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.ClassesList = new System.Windows.Forms.ListBox();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TeachersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassCount = new System.Windows.Forms.TextBox();
            this.txtStudentCount = new System.Windows.Forms.TextBox();
            this.classAdd = new System.Windows.Forms.Button();
            this.studentAdd = new System.Windows.Forms.Button();
            this.teacherAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.menuSchool.SuspendLayout();
            this.schoolTabs.SuspendLayout();
            this.tabClasses.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoolName
            // 
            this.schoolName.AutoSize = true;
            this.schoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.schoolName.Location = new System.Drawing.Point(12, 24);
            this.schoolName.Name = "schoolName";
            this.schoolName.Size = new System.Drawing.Size(92, 31);
            this.schoolName.TabIndex = 0;
            this.schoolName.Tag = "name";
            this.schoolName.Text = "label1";
            this.schoolName.DoubleClick += new System.EventHandler(this.label_Click);
            // 
            // schoolCity
            // 
            this.schoolCity.AutoSize = true;
            this.schoolCity.Location = new System.Drawing.Point(31, 55);
            this.schoolCity.Name = "schoolCity";
            this.schoolCity.Size = new System.Drawing.Size(35, 13);
            this.schoolCity.TabIndex = 1;
            this.schoolCity.Tag = "city";
            this.schoolCity.Text = "label2";
            this.schoolCity.DoubleClick += new System.EventHandler(this.label_Click);
            // 
            // menuSchool
            // 
            this.menuSchool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem});
            this.menuSchool.Location = new System.Drawing.Point(0, 0);
            this.menuSchool.Name = "menuSchool";
            this.menuSchool.Size = new System.Drawing.Size(482, 24);
            this.menuSchool.TabIndex = 2;
            this.menuSchool.Text = "menuStrip1";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // schoolTabs
            // 
            this.schoolTabs.Controls.Add(this.tabClasses);
            this.schoolTabs.Controls.Add(this.tabStudents);
            this.schoolTabs.Controls.Add(this.tabPage1);
            this.schoolTabs.Location = new System.Drawing.Point(130, 101);
            this.schoolTabs.Name = "schoolTabs";
            this.schoolTabs.SelectedIndex = 0;
            this.schoolTabs.Size = new System.Drawing.Size(349, 257);
            this.schoolTabs.TabIndex = 3;
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.ClassesList);
            this.tabClasses.Location = new System.Drawing.Point(4, 22);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(341, 231);
            this.tabClasses.TabIndex = 0;
            this.tabClasses.Text = "Klasy";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // ClassesList
            // 
            this.ClassesList.FormattingEnabled = true;
            this.ClassesList.Location = new System.Drawing.Point(0, 0);
            this.ClassesList.Name = "ClassesList";
            this.ClassesList.Size = new System.Drawing.Size(341, 225);
            this.ClassesList.TabIndex = 0;
            this.ClassesList.DoubleClick += new System.EventHandler(this.classesList_DoubleClick);
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.StudentsList);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(341, 231);
            this.tabStudents.TabIndex = 1;
            this.tabStudents.Text = "Uczniowie";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // StudentsList
            // 
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.Location = new System.Drawing.Point(0, 0);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(341, 225);
            this.StudentsList.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TeachersList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 231);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Nauczyciele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TeachersList
            // 
            this.TeachersList.FormattingEnabled = true;
            this.TeachersList.Location = new System.Drawing.Point(0, 3);
            this.TeachersList.Name = "TeachersList";
            this.TeachersList.Size = new System.Drawing.Size(338, 225);
            this.TeachersList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ilość uczniów:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ilość klas:";
            // 
            // txtClassCount
            // 
            this.txtClassCount.Location = new System.Drawing.Point(13, 144);
            this.txtClassCount.Name = "txtClassCount";
            this.txtClassCount.ReadOnly = true;
            this.txtClassCount.Size = new System.Drawing.Size(100, 20);
            this.txtClassCount.TabIndex = 6;
            this.txtClassCount.Text = "0";
            // 
            // txtStudentCount
            // 
            this.txtStudentCount.Location = new System.Drawing.Point(13, 191);
            this.txtStudentCount.Name = "txtStudentCount";
            this.txtStudentCount.ReadOnly = true;
            this.txtStudentCount.Size = new System.Drawing.Size(100, 20);
            this.txtStudentCount.TabIndex = 7;
            this.txtStudentCount.Text = "0";
            // 
            // classAdd
            // 
            this.classAdd.Location = new System.Drawing.Point(12, 276);
            this.classAdd.Name = "classAdd";
            this.classAdd.Size = new System.Drawing.Size(112, 23);
            this.classAdd.TabIndex = 8;
            this.classAdd.Text = "Dodaj klasę";
            this.classAdd.UseVisualStyleBackColor = true;
            this.classAdd.Click += new System.EventHandler(this.classAdd_Click);
            // 
            // studentAdd
            // 
            this.studentAdd.Enabled = false;
            this.studentAdd.Location = new System.Drawing.Point(12, 305);
            this.studentAdd.Name = "studentAdd";
            this.studentAdd.Size = new System.Drawing.Size(112, 23);
            this.studentAdd.TabIndex = 9;
            this.studentAdd.Text = "Dodaj ucznia";
            this.studentAdd.UseVisualStyleBackColor = true;
            // 
            // teacherAdd
            // 
            this.teacherAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teacherAdd.Location = new System.Drawing.Point(12, 335);
            this.teacherAdd.Name = "teacherAdd";
            this.teacherAdd.Size = new System.Drawing.Size(112, 23);
            this.teacherAdd.TabIndex = 10;
            this.teacherAdd.Text = "Dodaj nauczyciela";
            this.teacherAdd.UseVisualStyleBackColor = true;
            this.teacherAdd.Click += new System.EventHandler(this.teacherAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(18, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(452, 38);
            this.txtName.TabIndex = 11;
            this.txtName.Tag = "name";
            this.txtName.Visible = false;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(24, 52);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(185, 20);
            this.txtCity.TabIndex = 12;
            this.txtCity.Tag = "city";
            this.txtCity.Visible = false;
            this.txtCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // SchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 370);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.teacherAdd);
            this.Controls.Add(this.studentAdd);
            this.Controls.Add(this.classAdd);
            this.Controls.Add(this.txtStudentCount);
            this.Controls.Add(this.txtClassCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.schoolTabs);
            this.Controls.Add(this.schoolCity);
            this.Controls.Add(this.schoolName);
            this.Controls.Add(this.menuSchool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuSchool;
            this.MaximizeBox = false;
            this.Name = "SchoolForm";
            this.Text = "Szkoła";
            this.menuSchool.ResumeLayout(false);
            this.menuSchool.PerformLayout();
            this.schoolTabs.ResumeLayout(false);
            this.tabClasses.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schoolName;
        private System.Windows.Forms.Label schoolCity;
        private System.Windows.Forms.MenuStrip menuSchool;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.TabControl schoolTabs;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassCount;
        private System.Windows.Forms.TextBox txtStudentCount;
        private System.Windows.Forms.Button classAdd;
        private System.Windows.Forms.Button studentAdd;
        private System.Windows.Forms.ListBox ClassesList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button teacherAdd;
        private System.Windows.Forms.ListBox TeachersList;
        private System.Windows.Forms.ListBox StudentsList;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCity;
    }
}