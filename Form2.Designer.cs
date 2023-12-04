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
            this.TimeTable.Location = new System.Drawing.Point(-17, 4);
            this.TimeTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowHeadersWidth = 82;
            this.TimeTable.RowTemplate.Height = 23;
            this.TimeTable.Size = new System.Drawing.Size(1207, 1308);
            this.TimeTable.TabIndex = 1;
            this.TimeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeTable_CellClick_1);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(713, 1352);
            this.TextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(212, 35);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "입력";
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(960, 1324);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(230, 94);
            this.PlusButton.TabIndex = 4;
            this.PlusButton.Text = "추가";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(22, 1352);
            this.comboBoxGrade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(221, 32);
            this.comboBoxGrade.TabIndex = 5;
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(370, 1352);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(221, 32);
            this.comboBoxSubject.TabIndex = 7;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 1430);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TimeTable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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