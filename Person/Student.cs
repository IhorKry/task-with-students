using System;

namespace InternshipTest.Person
{
    public class Student
    {
        private string Name;
        private Knowledge Knowledge;

        public Student(string name)
        {
            Name = name;

            Random random = new Random();
            Knowledge initKnowledge = new Knowledge(random.Next(0, 100));
            SetKnowledge(initKnowledge);
        }

        public void SetKnowledge(Knowledge newKnowledge)
        {
            if (newKnowledge.GetKnowledgeLevel() < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newKnowledge), "Level knowledge of student must be positive");
            }
            else if (newKnowledge.GetKnowledgeLevel() > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(newKnowledge), "Level knowledge of student must be in range from 0 to 100");
            }
            else
            {
                Knowledge = newKnowledge;
            }
        }

        public string GetName()
        {
            return Name;
        }

        public int GetKnowledgeLevel()
        {
            return Knowledge.GetKnowledgeLevel();
        }
    }
}
