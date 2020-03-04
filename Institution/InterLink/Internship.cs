using System.Collections.Generic;
using System.Text;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string Name;
        public List<Student> Students = new List<Student>(); 

        public Internship(string name)
        {
            //TODO: Implementation is needed      
            Name = name;
        }

        public void setStudentsFromUniversity(University university)
        {
            var students = university.getAllStudents();

            foreach (var student in students)
            {
                System.Console.WriteLine($"name: {student.Name} knowledge: {student.getKnowledgeLevel()}");
            }
        }

        public string GetStudents()
        {
            //TODO: Implementation is needed
            var report = new StringBuilder();

            foreach (var student in Students)
            {
                report.AppendLine($"student: {student.Name}");
            }
            
            return report.ToString();
        }
    }
}
