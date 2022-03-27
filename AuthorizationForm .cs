using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab4
{
    public partial class AuthorizationForm : Form
    {
        readonly Professor[] professors =
        {
            new Professor
            ("Afonov14322", "dartFlutter",
             new List<Discipline>()
             {
                 new Discipline("СО421АТС", "Диспетчерское управление"), 
                 new Discipline("СО223ОПМ", "Общая электротехника"),
                 new Discipline("СО231КОБ", "Теория информации"),
                 new Discipline("СО231КОБ", "Безопасность операционных систем")
             },
             "Иван", "Афонов", "Сергеевич",
             "доцент", "высшая математика", "ЕНИ",
             "+7 (924) 566-34-63", "afonofkrytoi123@mail.ru","afonof.tyt"),

            new Professor
            ("Vino455", "WineAndGrad",
             new List<Discipline>()
             {
                 new Discipline("СО212КОБ", "Физика"),
                 new Discipline("СО211КОБ", "Физика"),
                 new Discipline("БО221ИСТ", "Электродинамика")
             },
             "Никита", "Виноградов", "Евгеньевич",
             "преподаватель", "ФиТМ", "ЕНИ",
             "+7 (914) 350-20-15", "Wines145@mail.ru","Vinogradov.tyt"),
        };
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void ExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            Professor currentProfessor = null;
            foreach (Professor professor in professors)
            {
                if (professor.Login == loginTextBox.Text 
                 && professor.Password == passwordTextBox.Text)
                {
                    currentProfessor = new Professor(professor);
                    Hide();

                    ProfessorForm professorForm = new ProfessorForm(currentProfessor, this);
                    professorForm.Show();
                }
            }
            if (currentProfessor == null)
            {
                MessageBox.Show("Ошибка в логине или пароле!", "Сообщение", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
