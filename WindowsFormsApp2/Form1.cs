using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DataGridViewCell selectedCell;
        public Form1()
        {
            InitializeComponent();
            InitializeTimetable();

        }

        private void InitializeTimetable()
        {
            // 시간표 DataGridView 초기 설정
            TimeTable.ColumnCount = 9; // 교시 열(0번 열은 요일로 사용)
            TimeTable.Rows.Add("요일", "1교시", "2교시", "3교시", "4교시", "5교시", "6교시", "7교시", "8교시");

            // 요일 설정
            TimeTable.Rows.Add("월요일");
            TimeTable.Rows.Add("화요일");
            TimeTable.Rows.Add("수요일");
            TimeTable.Rows.Add("목요일");
            TimeTable.Rows.Add("금요일");

            // 요일과 교시 셀들을 읽기 전용으로 설정
            for (int i = 0; i < TimeTable.Rows.Count; i++)
            {
                for (int j = 0; j < TimeTable.Columns.Count; j++)
                {
                    DataGridViewCell cell = TimeTable.Rows[i].Cells[j];
                    cell.ReadOnly = true;
                }
            }

            // DataGridView 셀 클릭 이벤트 추가
            TimeTable.CellClick += TimeTable_CellClick;

            // 변경 버튼 클릭 이벤트 추가
            PlusButton.Click += PlusButton_Click;
        }

        private void TimeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedCell = TimeTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (selectedCell != null)
            {
                string newContent = TextBox.Text.Trim(); // 변경할 새로운 내용

                // 선택된 셀의 내용 변경
                selectedCell.Value = newContent;
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox.Text = string.Empty;
        }
    }
}
