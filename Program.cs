using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko"));
            university.AddStudent(new Student("Julia Veselkina"));
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(new Student("Viktoria Foo"));
            university.AddStudent(new Student("John Doe"));
            university.AddStudent(new Student("Viktor Bazas"));

            Console.WriteLine("List of university students:");
            Console.WriteLine(createReport(university.GetStudents()));

            Console.WriteLine($"Average score: {university.GetAverageScore()} \n");

            Internship internship = new Internship("Interlink");
            internship.SetStudentsFromUniversity(university);

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(createReport(internship.GetStudents()));
        }

        static public string createReport(List<Student> students)
        {
            var report = new StringBuilder();
            List<Student> sortedStudents = students.OrderBy(student => student.GetKnowledgeLevel()).Reverse().ToList();

            foreach (var student in sortedStudents)
            {
                report.AppendLine($"student: {student.GetName()}, with score: {student.GetKnowledgeLevel()}");
            }

            return report.ToString();
        }
    }
}
