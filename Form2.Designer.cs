﻿namespace 윈도우프로그래밍_프로젝트
{
    partial class Form2
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
            this.TimeTable = new System.Windows.Forms.DataGridView();
            this.grade = new System.Windows.Forms.ComboBox();
            this.firstGrade = new System.Windows.Forms.ComboBox();
            this.fourthGrade = new System.Windows.Forms.ComboBox();
            this.secondGrade = new System.Windows.Forms.ComboBox();
            this.thirdGrade = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeTable
            // 
            this.TimeTable.ColumnHeadersHeight = 46;
            this.TimeTable.Location = new System.Drawing.Point(26, -2);
            this.TimeTable.Margin = new System.Windows.Forms.Padding(6);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowHeadersWidth = 82;
            this.TimeTable.RowTemplate.Height = 23;
            this.TimeTable.Size = new System.Drawing.Size(1252, 1330);
            this.TimeTable.TabIndex = 1;
            this.TimeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeTable_CellClick_1);
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "first",
            "second",
            "third",
            "fourth"});
            this.grade.Location = new System.Drawing.Point(35, 1340);
            this.grade.Margin = new System.Windows.Forms.Padding(6);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(164, 32);
            this.grade.TabIndex = 5;
            this.grade.SelectedIndexChanged += new System.EventHandler(this.grade_SelectedIndexChanged);
            // 
            // firstGrade
            // 
            this.firstGrade.FormattingEnabled = true;
            this.firstGrade.Items.AddRange(new object[] {
            "C언어 기초",
            "병신같은 과목",
            "원어민 외국어"});
            this.firstGrade.Location = new System.Drawing.Point(262, 1340);
            this.firstGrade.Margin = new System.Windows.Forms.Padding(6);
            this.firstGrade.Name = "firstGrade";
            this.firstGrade.Size = new System.Drawing.Size(173, 32);
            this.firstGrade.TabIndex = 6;
            this.firstGrade.Visible = false;
            this.firstGrade.SelectedIndexChanged += new System.EventHandler(this.firstGrade_SelectedIndexChanged);
            // 
            // fourthGrade
            // 
            this.fourthGrade.FormattingEnabled = true;
            this.fourthGrade.Items.AddRange(new object[] {
            "취업",
            "해야지",
            "이런"});
            this.fourthGrade.Location = new System.Drawing.Point(262, 1340);
            this.fourthGrade.Margin = new System.Windows.Forms.Padding(6);
            this.fourthGrade.Name = "fourthGrade";
            this.fourthGrade.Size = new System.Drawing.Size(173, 32);
            this.fourthGrade.TabIndex = 7;
            this.fourthGrade.Visible = false;
            // 
            // secondGrade
            // 
            this.secondGrade.FormattingEnabled = true;
            this.secondGrade.Items.AddRange(new object[] {
            "2학년과목",
            "고급프로그래밍"});
            this.secondGrade.Location = new System.Drawing.Point(262, 1340);
            this.secondGrade.Margin = new System.Windows.Forms.Padding(6);
            this.secondGrade.Name = "secondGrade";
            this.secondGrade.Size = new System.Drawing.Size(173, 32);
            this.secondGrade.TabIndex = 8;
            this.secondGrade.Visible = false;
            this.secondGrade.SelectedIndexChanged += new System.EventHandler(this.secondGrade_SelectedIndexChanged);
            // 
            // thirdGrade
            // 
            this.thirdGrade.FormattingEnabled = true;
            this.thirdGrade.Items.AddRange(new object[] {
            "3학년과목1",
            "빵상",
            "데이터베이스"});
            this.thirdGrade.Location = new System.Drawing.Point(262, 1340);
            this.thirdGrade.Margin = new System.Windows.Forms.Padding(6);
            this.thirdGrade.Name = "thirdGrade";
            this.thirdGrade.Size = new System.Drawing.Size(173, 32);
            this.thirdGrade.TabIndex = 9;
            this.thirdGrade.Visible = false;
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "lightBlue",
            "pink",
            "yellow",
            "blue",
            "white",
            "gray"});
            this.color.Location = new System.Drawing.Point(956, 1394);
            this.color.Margin = new System.Windows.Forms.Padding(6);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(182, 32);
            this.color.TabIndex = 11;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 1502);
            this.Controls.Add(this.color);
            this.Controls.Add(this.thirdGrade);
            this.Controls.Add(this.secondGrade);
            this.Controls.Add(this.fourthGrade);
            this.Controls.Add(this.firstGrade);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.TimeTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TimeTable;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.ComboBox firstGrade;
        private System.Windows.Forms.ComboBox fourthGrade;
        private System.Windows.Forms.ComboBox secondGrade;
        private System.Windows.Forms.ComboBox thirdGrade;
        private System.Windows.Forms.ComboBox color;
    }
}