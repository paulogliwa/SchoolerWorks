namespace SchoolerWorks
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.labelFullName = new System.Windows.Forms.Label();
            this.gradesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.txtFails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFullName.Location = new System.Drawing.Point(13, 13);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(112, 26);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Tag = "name";
            this.labelFullName.Text = "Full Name";
            this.labelFullName.DoubleClick += new System.EventHandler(this.label_Click);
            // 
            // gradesPanel
            // 
            this.gradesPanel.AutoScroll = true;
            this.gradesPanel.Location = new System.Drawing.Point(12, 167);
            this.gradesPanel.Name = "gradesPanel";
            this.gradesPanel.Size = new System.Drawing.Size(451, 218);
            this.gradesPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ocena:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(60, 145);
            this.txtGrade.MaxLength = 1;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(26, 20);
            this.txtGrade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Srednia ocen:";
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(414, 32);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(44, 20);
            this.txtAvg.TabIndex = 5;
            // 
            // txtFails
            // 
            this.txtFails.Location = new System.Drawing.Point(414, 58);
            this.txtFails.Name = "txtFails";
            this.txtFails.ReadOnly = true;
            this.txtFails.Size = new System.Drawing.Size(44, 20);
            this.txtFails.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zagrożenia:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(39, 39);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(35, 13);
            this.labelDOB.TabIndex = 8;
            this.labelDOB.Tag = "date";
            this.labelDOB.Text = "label4";
            this.labelDOB.DoubleClick += new System.EventHandler(this.label_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(15, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 32);
            this.txtName.TabIndex = 9;
            this.txtName.Tag = "name";
            this.txtName.Visible = false;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(25, 35);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 10;
            this.txtDate.Tag = "date";
            this.txtDate.Visible = false;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 397);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.txtFails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradesPanel);
            this.Controls.Add(this.labelFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.Text = "Uczen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel gradesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtFails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
    }
}