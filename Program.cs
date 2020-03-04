﻿using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko"));
            university.AddStudent(new Student("Julia Veselkina"));
            university.AddStudent(new Student("Maria Perechrest"));

            Internship internship = new Internship("Interlink");
            internship.setStudentsFromUniversity(university);



            // Console.WriteLine("List of internship's students:");
            // Console.WriteLine(internship.GetStudents());



            // System.Console.WriteLine(s.getKnowledgeLevel());
            // System.Console.WriteLine(a.getKnowledgeLevel());
            // System.Console.WriteLine(b.getKnowledgeLevel());
        }
    }
}
