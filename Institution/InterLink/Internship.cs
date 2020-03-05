using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string Name;
        private List<Student> Students = new List<Student>(); 

        public Internship(string name)
        {     
            Name = name;
        }

        public void SetStudentsFromUniversity(University university)
        {
            // здесь использовать var или привести к типу(как сейчас)?
            List<Student> students = university.GetStudents();
            int universityAverageScore = university.GetAverageScore();

            foreach (var student in students)
            {
                if(student.GetKnowledgeLevel() >= universityAverageScore) Students.Add(student);
            }
        }

        public List<Student> GetStudents()
        {        
            return Students;
        }
    }
}
