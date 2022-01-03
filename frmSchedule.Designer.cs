namespace DGateWay
{
    partial class frmSchedule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkSchedule = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskSchTry = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskSchLoop = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDays = new System.Windows.Forms.CheckedListBox();
            this.mskSchDay = new System.Windows.Forms.MaskedTextBox();
            this.mskSchEnd = new System.Windows.Forms.MaskedTextBox();
            this.mskSchStart = new System.Windows.Forms.MaskedTextBox();
            this.cmbSchType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.chkSchedule);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(97, 65);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 5;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkSchedule
            // 
            this.chkSchedule.AutoSize = true;
            this.chkSchedule.Location = new System.Drawing.Point(21, 65);
            this.chkSchedule.Name = "chkSchedule";
            this.chkSchedule.Size = new System.Drawing.Size(71, 17);
            this.chkSchedule.TabIndex = 4;
            this.chkSchedule.Text = "Schedule";
            this.chkSchedule.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(191, 39);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(305, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.mskSchTry);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mskSchLoop);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chkDays);
            this.groupBox2.Controls.Add(this.mskSchDay);
            this.groupBox2.Controls.Add(this.mskSchEnd);
            this.groupBox2.Controls.Add(this.mskSchStart);
            this.groupBox2.Controls.Add(this.cmbSchType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule";
            // 
            // mskSchTry
            // 
            this.mskSchTry.Location = new System.Drawing.Point(423, 45);
            this.mskSchTry.Mask = "00";
            this.mskSchTry.Name = "mskSchTry";
            this.mskSchTry.Size = new System.Drawing.Size(60, 20);
            this.mskSchTry.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Time Try";
            // 
            // mskSchLoop
            // 
            this.mskSchLoop.Location = new System.Drawing.Point(357, 46);
            this.mskSchLoop.Mask = "00";
            this.mskSchLoop.Name = "mskSchLoop";
            this.mskSchLoop.Size = new System.Drawing.Size(60, 20);
            this.mskSchLoop.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Loop";
            // 
            // chkDays
            // 
            this.chkDays.CheckOnClick = true;
            this.chkDays.FormattingEnabled = true;
            this.chkDays.Items.AddRange(new object[] {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"});
            this.chkDays.Location = new System.Drawing.Point(12, 84);
            this.chkDays.Margin = new System.Windows.Forms.Padding(1);
            this.chkDays.MultiColumn = true;
            this.chkDays.Name = "chkDays";
            this.chkDays.Size = new System.Drawing.Size(504, 34);
            this.chkDays.TabIndex = 12;
            // 
            // mskSchDay
            // 
            this.mskSchDay.Location = new System.Drawing.Point(291, 46);
            this.mskSchDay.Mask = "00";
            this.mskSchDay.Name = "mskSchDay";
            this.mskSchDay.Size = new System.Drawing.Size(60, 20);
            this.mskSchDay.TabIndex = 9;
            // 
            // mskSchEnd
            // 
            this.mskSchEnd.Location = new System.Drawing.Point(215, 46);
            this.mskSchEnd.Mask = "00:00:00";
            this.mskSchEnd.Name = "mskSchEnd";
            this.mskSchEnd.Size = new System.Drawing.Size(60, 20);
            this.mskSchEnd.TabIndex = 8;
            // 
            // mskSchStart
            // 
            this.mskSchStart.Location = new System.Drawing.Point(149, 45);
            this.mskSchStart.Mask = "00:00:00";
            this.mskSchStart.Name = "mskSchStart";
            this.mskSchStart.Size = new System.Drawing.Size(60, 20);
            this.mskSchStart.TabIndex = 7;
            // 
            // cmbSchType
            // 
            this.cmbSchType.FormattingEnabled = true;
            this.cmbSchType.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cmbSchType.Location = new System.Drawing.Point(12, 45);
            this.cmbSchType.Name = "cmbSchType";
            this.cmbSchType.Size = new System.Drawing.Size(121, 21);
            this.cmbSchType.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Month Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 292);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSchedule";
            this.Text = "Schedule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskSchTry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskSchLoop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox chkDays;
        private System.Windows.Forms.MaskedTextBox mskSchDay;
        private System.Windows.Forms.MaskedTextBox mskSchEnd;
        private System.Windows.Forms.MaskedTextBox mskSchStart;
        private System.Windows.Forms.ComboBox cmbSchType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}