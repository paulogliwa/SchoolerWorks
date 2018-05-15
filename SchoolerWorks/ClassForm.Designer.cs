namespace SchoolerWorks
{
    partial class ClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassForm));
            this.labelName = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupAVG = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFailers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(132, 47);
            this.labelName.TabIndex = 0;
            this.labelName.Tag = "name";
            this.labelName.Text = "label1";
            this.labelName.Click += new System.EventHandler(this.label_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Location = new System.Drawing.Point(29, 56);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(35, 13);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Tag = "profile";
            this.labelProfile.Text = "label1";
            this.labelProfile.DoubleClick += new System.EventHandler(this.label_Click);
            // 
            // StudentsList
            // 
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.Location = new System.Drawing.Point(12, 111);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(295, 303);
            this.StudentsList.TabIndex = 2;
            this.StudentsList.DoubleClick += new System.EventHandler(this.StudentsList_DoubleClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 82);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Dodaj ucznia";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(98, 82);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Usun ucznia";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Srednia klasy:";
            // 
            // txtGroupAVG
            // 
            this.txtGroupAVG.Location = new System.Drawing.Point(387, 108);
            this.txtGroupAVG.Name = "txtGroupAVG";
            this.txtGroupAVG.ReadOnly = true;
            this.txtGroupAVG.Size = new System.Drawing.Size(100, 20);
            this.txtGroupAVG.TabIndex = 6;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(387, 134);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.ReadOnly = true;
            this.txtHigh.Size = new System.Drawing.Size(100, 20);
            this.txtHigh.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Najwyzsza:";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(387, 160);
            this.txtLow.Name = "txtLow";
            this.txtLow.ReadOnly = true;
            this.txtLow.Size = new System.Drawing.Size(100, 20);
            this.txtLow.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Najnizsza:";
            // 
            // txtFailers
            // 
            this.txtFailers.Location = new System.Drawing.Point(387, 186);
            this.txtFailers.Name = "txtFailers";
            this.txtFailers.ReadOnly = true;
            this.txtFailers.Size = new System.Drawing.Size(100, 20);
            this.txtFailers.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Zagrozonych:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(20, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 53);
            this.txtName.TabIndex = 13;
            this.txtName.Tag = "name";
            this.txtName.Visible = false;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(32, 49);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(275, 20);
            this.txtProfile.TabIndex = 14;
            this.txtProfile.Tag = "profile";
            this.txtProfile.Visible = false;
            this.txtProfile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 418);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFailers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroupAVG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClassForm";
            this.Text = "Klasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.ListBox StudentsList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupAVG;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFailers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProfile;
    }
}