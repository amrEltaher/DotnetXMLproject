﻿namespace DotnetXmlProject.adminUserControl
{
    partial class attendanceMangement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            tabPage3 = new TabPage();
            sessionData = new DataGridView();
            panel1 = new Panel();
            DeleteRecordBtn = new Button();
            EditRecordBtn = new Button();
            tabPage2 = new TabPage();
            dateSession = new DateTimePicker();
            panel3 = new Panel();
            Date = new Label();
            label5 = new Label();
            addRecordBtn = new Button();
            subjectCombobox = new ComboBox();
            panel4 = new Panel();
            ClassIDcb = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            stdSessionData = new DataGridView();
            button1 = new Button();
            sessionIDText = new ComboBox();
            panel2 = new Panel();
            label1 = new Label();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sessionData).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stdSessionData).BeginInit();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(sessionData);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(618, 292);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sessions";
            // 
            // sessionData
            // 
            sessionData.BackgroundColor = Color.White;
            sessionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sessionData.Location = new Point(12, 6);
            sessionData.Name = "sessionData";
            sessionData.Size = new Size(586, 224);
            sessionData.TabIndex = 7;
            
            sessionData.CellBeginEdit += sessionData_CellBeginEdit;
            // 
            // panel1
            // 
            panel1.Controls.Add(DeleteRecordBtn);
            panel1.Controls.Add(EditRecordBtn);
            panel1.Location = new Point(6, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 50);
            panel1.TabIndex = 6;
            // 
            // DeleteRecordBtn
            // 
            DeleteRecordBtn.BackColor = Color.Indigo;
            DeleteRecordBtn.ForeColor = Color.White;
            DeleteRecordBtn.Location = new Point(487, 7);
            DeleteRecordBtn.Name = "DeleteRecordBtn";
            DeleteRecordBtn.Size = new Size(86, 31);
            DeleteRecordBtn.TabIndex = 7;
            DeleteRecordBtn.Text = "Delete";
            DeleteRecordBtn.UseVisualStyleBackColor = false;
            DeleteRecordBtn.Click += DeleteRecordBtn_Click;
            // 
            // EditRecordBtn
            // 
            EditRecordBtn.BackColor = Color.Indigo;
            EditRecordBtn.ForeColor = Color.White;
            EditRecordBtn.Location = new Point(395, 7);
            EditRecordBtn.Name = "EditRecordBtn";
            EditRecordBtn.Size = new Size(86, 31);
            EditRecordBtn.TabIndex = 8;
            EditRecordBtn.Text = "Edit";
            EditRecordBtn.UseVisualStyleBackColor = false;
            EditRecordBtn.Click += EditRecordBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(dateSession);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(Date);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(addRecordBtn);
            tabPage2.Controls.Add(subjectCombobox);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(ClassIDcb);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(618, 292);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            // 
            // dateSession
            // 
            dateSession.Location = new Point(314, 146);
            dateSession.Name = "dateSession";
            dateSession.Size = new Size(200, 23);
            dateSession.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Indigo;
            panel3.Location = new Point(314, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 33;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 12F);
            Date.ForeColor = Color.Indigo;
            Date.Location = new Point(314, 104);
            Date.Name = "Date";
            Date.Size = new Size(59, 21);
            Date.TabIndex = 34;
            Date.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(226, 16);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 29;
            label5.Text = "Add Session";
            // 
            // addRecordBtn
            // 
            addRecordBtn.BackColor = Color.Indigo;
            addRecordBtn.ForeColor = Color.White;
            addRecordBtn.Location = new Point(215, 233);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(133, 42);
            addRecordBtn.TabIndex = 28;
            addRecordBtn.Text = "Add";
            addRecordBtn.UseVisualStyleBackColor = false;
            addRecordBtn.Click += addRecordBtn_Click;
            // 
            // subjectCombobox
            // 
            subjectCombobox.FlatStyle = FlatStyle.Flat;
            subjectCombobox.FormattingEnabled = true;
            subjectCombobox.Location = new Point(37, 143);
            subjectCombobox.Name = "subjectCombobox";
            subjectCombobox.Size = new Size(200, 23);
            subjectCombobox.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Indigo;
            panel4.Location = new Point(37, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 2);
            panel4.TabIndex = 21;
            // 
            // ClassIDcb
            // 
            ClassIDcb.AutoSize = true;
            ClassIDcb.Font = new Font("Segoe UI", 12F);
            ClassIDcb.ForeColor = Color.Indigo;
            ClassIDcb.Location = new Point(37, 111);
            ClassIDcb.Name = "ClassIDcb";
            ClassIDcb.Size = new Size(83, 21);
            ClassIDcb.TabIndex = 23;
            ClassIDcb.Text = "Subject ID:";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(626, 320);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(stdSessionData);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(sessionIDText);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(618, 292);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Students In Session";
            // 
            // stdSessionData
            // 
            stdSessionData.BackgroundColor = Color.White;
            stdSessionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stdSessionData.EditMode = DataGridViewEditMode.EditProgrammatically;
            stdSessionData.Location = new Point(20, 62);
            stdSessionData.Name = "stdSessionData";
            stdSessionData.Size = new Size(586, 224);
            stdSessionData.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.ForeColor = Color.White;
            button1.Location = new Point(391, 11);
            button1.Name = "button1";
            button1.Size = new Size(133, 42);
            button1.TabIndex = 31;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sessionIDText
            // 
            sessionIDText.FlatStyle = FlatStyle.Flat;
            sessionIDText.FormattingEnabled = true;
            sessionIDText.Location = new Point(118, 18);
            sessionIDText.Name = "sessionIDText";
            sessionIDText.Size = new Size(200, 23);
            sessionIDText.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Location = new Point(118, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 2);
            panel2.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 29;
            label1.Text = "Session ID:";
            // 
            // attendanceMangement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "attendanceMangement";
            Size = new Size(637, 323);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sessionData).EndInit();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stdSessionData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private TabPage tabPage3;
        private DataGridView sessionData;
        private Panel panel1;
        private Button DeleteRecordBtn;
        private Button EditRecordBtn;
        private TabPage tabPage2;
        private ComboBox Statuscb;
        private Panel panel3;
        private Label Date;
        private Label label5;
        private Button addRecordBtn;
        private ComboBox subjectCombobox;
        private Panel panel4;
        private Label ClassIDcb;
        private TabControl tabControl1;
        private DateTimePicker dateSession;
        private TabPage tabPage1;
        private Button button1;
        private ComboBox sessionIDText;
        private Panel panel2;
        private Label label1;
        private DataGridView stdSessionData;
    }
}
