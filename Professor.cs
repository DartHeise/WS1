using System.Collections.Generic;

namespace lab4
{
    public class Professor
    {
        public List<Discipline> Disciplines { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Institute { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Skype { get; set; }

        public Professor
        (string login, string password, List<Discipline> disciplines,
         string name, string surname, string patronymic, string position,
         string department, string institute, string phone, string mail, string skype)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = position;
            Department = department;
            Institute = institute;
            Phone = phone;
            Mail = mail;
            Skype = skype;
            Disciplines = new List<Discipline>(disciplines.Capacity);
            foreach (Discipline discipline in disciplines)
            {
                Disciplines.Add(new Discipline(discipline));
            }
        }

        public Professor (Professor pr)
        : this(pr.Login, pr.Password, pr.Disciplines, pr.Name, pr.Surname,
               pr.Patronymic, pr.Position, pr.Department, pr.Institute, pr.Phone, pr.Mail, pr.Skype)
        {

        }
    }
}
