using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        public string Name;
        public List<Student> Students = new List<Student>(); 

        public University(string name)
        {
            //TODO: Implementation is needed  
            Name = name;
        }

        public void AddStudent(Student student)
        {
            //TODO: Implementation is needed
            Students.Add(student);
        }

        public List<Student> getAllStudents()
        {
            return Students;
        }
    }
}
