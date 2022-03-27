using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class ProfessorForm : Form
    {
        readonly Professor currentProfessor = null;
        readonly AuthorizationForm authorizationForm = null;
        public ProfessorForm(Professor professor, AuthorizationForm authorizationForm)
        {
            InitializeComponent();

            currentProfessor = new Professor(professor);
            this.authorizationForm = authorizationForm;

            name.Text = $"{currentProfessor.Surname} {currentProfessor.Name} {currentProfessor.Patronymic}";
            Position.Text += currentProfessor.Position;
            department.Text += currentProfessor.Department;
            institute.Text += currentProfessor.Institute;
            phone.Text += currentProfessor.Phone;
            mail.Text += currentProfessor.Mail;
            skype.Text += currentProfessor.Skype;

            foreach (Discipline discipline in currentProfessor.Disciplines)
            {
                disciplinesListBox.Items.Add($"{discipline.DisciplineName}({discipline.GroupName})");
            }
        }

        private void OpenButtonClicked(object sender, EventArgs e)
        {
            string str = (string)disciplinesListBox.SelectedItem;
            if (str != null)
            {
                string[] mas = str.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                Discipline currentDiscipline = new Discipline($"{mas[1]}", $"{mas[0]}");
                RatingForm ratingForm = new RatingForm(currentDiscipline);
                ratingForm.Show();
            }
        }

        private void ExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeUserButtonClicked(object sender, EventArgs e)
        {
            authorizationForm.Show();
            Close();
        }
    }
}
