
namespace lab4
{
    public class Discipline
    {
        public static string[] CheckPoints = new string[]
        {
            "07.03",
            "04.04",
            "02.05",
            "30.05",
            "27.06",
            "25.07"
        };
        public string GroupName { get; set; }
        public string DisciplineName { get; set; }
        public Discipline(string groupName, string disciplineName)
        {
            GroupName = groupName;
            DisciplineName = disciplineName;
        }

        public Discipline(Discipline dis) : this (dis.GroupName, dis.DisciplineName)
        {

        }
    }
}
