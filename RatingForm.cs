using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace lab4
{
    public partial class RatingForm : Form
    {
        readonly Discipline currentDiscipline = null;

        public RatingForm(Discipline discipline)
        {
            InitializeComponent();

            currentDiscipline = new Discipline(discipline);
            groupNameLabel.Text = discipline.DisciplineName + " " + discipline.GroupName;
            foreach (string checkPoint in Discipline.CheckPoints)
            {
                studentsDataGridView.Columns.Add("checkPointColumn", checkPoint);
            }

            StreamReader streamReader = new StreamReader("Rating.txt");
            while (!streamReader.EndOfStream)
            {
                if (streamReader.ReadLine() == $"{currentDiscipline.DisciplineName}({currentDiscipline.GroupName})")
                {
                    string line = streamReader.ReadLine();
                    int index = 0;
                    while (line != "..")
                    {
                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        studentsDataGridView.Rows.Add($"{words[0]} {words[1]} {words[2]}");
                        for (int i = 1; i < studentsDataGridView.Columns.Count; i++)
                        {
                            studentsDataGridView[i, index].Value = words[i + 2];
                        }
                        index++;
                        line = streamReader.ReadLine();
                    }
                    break;
                }
            }
            streamReader.Close();
        }

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            LinkedList<string> text = new LinkedList<string>();
            StreamReader streamReader = new StreamReader("Rating.txt");
            do
            {
                text.AddLast(streamReader.ReadLine());
                if (text.Last.Value == $"{currentDiscipline.DisciplineName}({currentDiscipline.GroupName})")
                {
                    for (int i = 0; i < studentsDataGridView.RowCount; i++)
                    {
                        string line = "";
                        for (int j = 0; j < studentsDataGridView.ColumnCount; j++)
                        {
                            line += $" {studentsDataGridView[j, i].Value}";
                        }
                        streamReader.ReadLine();
                        text.AddLast(line);
                    }
                }
            }
            while (!streamReader.EndOfStream);

            streamReader.Close();
            StreamWriter streamWriter = new StreamWriter("Rating.txt");
            foreach (string txt in text)
            {
                streamWriter.WriteLine(txt);
            }

            streamWriter.Close();
        }

        private void CloseButtonClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}
