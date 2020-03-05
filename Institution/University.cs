using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        private string Name;
        private int AverageScore;
        private List<Student> Students = new List<Student>();

        public University(string name)
        { 
            Name = name;
            AverageScore = 0;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            UpdateAverageScore();
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        private void UpdateAverageScore()
        {
            int studentCounter = 0;
            int generalScore = 0;

            foreach (var student in Students)
            {
                studentCounter++;
                generalScore += student.GetKnowledgeLevel();
            }

            AverageScore = generalScore / studentCounter;
        }

        public int GetAverageScore()
        {
            return AverageScore;
        }
    }
}
