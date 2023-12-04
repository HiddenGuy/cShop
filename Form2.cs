﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈도우프로그래밍_프로젝트
{
    public partial class Form2 : Form
    {

        private Dictionary<string, List<string>> gradeSubjectDictionary = new Dictionary<string, List<string>>();

        DataGridViewCell selectedCell; //datagridviewcell <- 이게 표임
        public Form2()
        {
            InitializeComponent();
            InitializeTimetable(); //시작할 때 같이 실행

            // 1학년, 2학년, 3학년, 4학년에 대한 과목 목록을 딕셔너리에 추가
            gradeSubjectDictionary.Add("1학년", new List<string> { "국어", "수학", "영어" });
            gradeSubjectDictionary.Add("2학년", new List<string> { "과학", "역사", "미술" });
            gradeSubjectDictionary.Add("3학년", new List<string> { "체육", "음악", "기술" });
            gradeSubjectDictionary.Add("4학년", new List<string> { "한국사", "도덕", "사회" });

            comboBoxGrade.Items.AddRange(new string[] { "1학년", "2학년", "3학년", "4학년" });

        }

        private void InitializeTimetable()
        {
            TimeTable.RowTemplate.Height = 20;

            // 초기설정 datagridview <- 이게 표임
            TimeTable.ColumnCount = 6; // 교시 열(0번 열은 교시 사용)
            TimeTable.Rows.Add("교시", "월요일", "화요일", "수요일", "목요일", "금요일");
            for (int i = 0; i < 6; i++)
            {
                TimeTable.RowTemplate.Height = 70;
            }

            // 요일 설정
            TimeTable.Rows.Add("1교시");
            TimeTable.Rows.Add("2교시");
            TimeTable.Rows.Add("3교시");
            TimeTable.Rows.Add("4교시");
            TimeTable.Rows.Add("5교시");
            TimeTable.Rows.Add("6교시");
            TimeTable.Rows.Add("7교시");
            TimeTable.Rows.Add("8교시");


            // 요일과 교시 셀들 눌러서 못 바꾸게 하는 거임(2차원 배열)
            for (int i = 0; i < TimeTable.Rows.Count; i++)
            {
                for (int j = 0; j < TimeTable.Columns.Count; j++)
                {
                    DataGridViewCell cell = TimeTable.Rows[i].Cells[j];
                    cell.ReadOnly = true; // 읽을 수만 있게
                }
            }

            // DataGridView 셀 클릭 이벤트 추가
            TimeTable.CellClick += TimeTable_CellClick; //cellclick 이벤트에 함수 추가

            // 변경 버튼 클릭 이벤트 추가
            PlusButton.Click += PlusButton_Click; //마찬가지 
        }

        private void TimeTable_CellClick(object sender, DataGridViewCellEventArgs e) // 셀 눌렀을 떄
        {

        }

        private void PlusButton_Click(object sender, EventArgs e) //추가 버튼 클릭했을떄
        {
            if (selectedCell != null) //셀 선택 됐을떄만 실행
            {
                string newContent = TextBox.Text.Trim(); // 변경할 새로운 내용(trim이 텍스트박스 가져오는거)

                // newcontent << textbox 내용
                selectedCell.Value = newContent; //이거 값 newContent로 채움
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요."); //안됐으면 선택하라 뜸
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox.Text = string.Empty; //텍스트박스에 입력 누르면 바로 지워지게
        }

        private void UpdateSubjectComboBox()
        {
            if (comboBoxGrade.SelectedItem != null)
            {
                string selectedGrade = comboBoxGrade.SelectedItem.ToString();

                // 딕셔너리에서 선택한 학년에 해당하는 과목 목록을 가져와서 두 번째 콤보박스에 설정
                if (gradeSubjectDictionary.ContainsKey(selectedGrade))
                {
                    comboBoxSubject.Items.Clear();
                    comboBoxSubject.Items.AddRange(gradeSubjectDictionary[selectedGrade].ToArray());
                }
            }
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 첫 번째 콤보박스의 선택에 따라 두 번째 콤보박스의 항목을 변경
            string selectedGrade = comboBoxGrade.SelectedItem.ToString();

            // 딕셔너리에서 선택한 학년에 해당하는 과목 목록을 가져와서 두 번째 콤보박스에 설정
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(gradeSubjectDictionary[selectedGrade].ToArray());
            

        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubjectComboBox();

        }

        private void TimeTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = TimeTable.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // 1행과 1열인 경우 (인덱스가 0일 때) 변경되지 않도록 경고 메시지 표시
                if (e.RowIndex == 0 || e.ColumnIndex == 0)
                {
                    MessageBox.Show("이 셀은 변경할 수 없습니다.");
                    return;
                }

            
            }
        }
    }
}

