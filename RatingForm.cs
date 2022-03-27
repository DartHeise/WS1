using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace lab4
{
    public partial class RatingForm : Form
    {
        readonly Discipline currentDiscipline = null;
        readonly string path = "Rating.txt";

        public RatingForm(Discipline discipline)
        {
            InitializeComponent();

            currentDiscipline = new Discipline(discipline);
            groupNameLabel.Text = discipline.DisciplineName + " " + discipline.GroupName;

            List<string> currentStudents = Get();

            foreach (string checkPoint in Discipline.CheckPoints)
            {
                studentsDataGridView.Columns.Add("checkPointColumn", checkPoint);
            }

            for (int i = 0; i < currentStudents.Count; i++)
            {
                string[] studentInfo = currentStudents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                studentsDataGridView.Rows.Add($"{studentInfo[0]} {studentInfo[1]} {studentInfo[2]}");
                for (int j = 1; j < studentsDataGridView.ColumnCount; j++)
                {
                    studentsDataGridView[j, i].Value = studentInfo[j + 2];
                }
            }
        }

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            string[] UpdatedStudentsInfo = GetAll();
            SaveAll(UpdatedStudentsInfo);
        }

        private void CloseButtonClicked(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValueEqualsDiscipline(string value)
        {
            return value == $"{currentDiscipline.DisciplineName}({currentDiscipline.GroupName})";
        }

        public string[] GetAll()
        {
            var streamReader = new StreamReader(path);
            var ratingText = new List<string>();
            while (!streamReader.EndOfStream)
            {
                ratingText.Add(streamReader.ReadLine());
                if (IsValueEqualsDiscipline(ratingText[ratingText.Count - 1]))
                {
                    for (int i = 0; i < studentsDataGridView.RowCount; i++)
                    {
                        ratingText.Add("");
                        for (int j = 0; j < studentsDataGridView.ColumnCount; j++)
                        {
                            ratingText[ratingText.Count - 1] += $" {studentsDataGridView[j, i].Value}";
                        }
                        streamReader.ReadLine();
                    }
                }
            }
            streamReader.Close();
            return ratingText.ToArray();
        }

        public void SaveAll(string[] mas)
        {
            var streamWriter = new StreamWriter(path);
            foreach (string line in mas)
            {
                streamWriter.WriteLine(line);
            }
            streamWriter.Close();
        }

        public List<string> Get()
        {
            var streamReader = new StreamReader(path);
            var disciplineInfo = new List<string>();
            while (!streamReader.EndOfStream)
            {
                if (IsValueEqualsDiscipline(streamReader.ReadLine()))
                {
                    var ratingLine = streamReader.ReadLine();
                    while (ratingLine != "..")
                    {
                        disciplineInfo.Add(ratingLine);
                        ratingLine = streamReader.ReadLine();
                    }
                    break;
                }
            }
            streamReader.Close();
            return disciplineInfo;
        }
    }
}
