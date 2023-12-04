namespace 윈도우프로그래밍_프로젝트
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeTable
            // 
            this.TimeTable.ColumnHeadersHeight = 46;
            this.TimeTable.Location = new System.Drawing.Point(-9, 2);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowHeadersWidth = 82;
            this.TimeTable.RowTemplate.Height = 23;
            this.TimeTable.Size = new System.Drawing.Size(650, 654);
            this.TimeTable.TabIndex = 1;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(384, 676);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(116, 21);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "입력";
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(517, 662);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(124, 47);
            this.PlusButton.TabIndex = 4;
            this.PlusButton.Text = "추가";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(12, 676);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(121, 20);
            this.comboBoxGrade.TabIndex = 5;
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(199, 676);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSubject.TabIndex = 7;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 715);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TimeTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TimeTable;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxSubject;
    }
}