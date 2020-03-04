using System;

namespace InternshipTest.Person
{
    public class Student
    {
        public string Name;
        public Knowledge Knowledge;
        public Random random = new Random();

        public Student(string name)
        {
            //TODO: Implementation is needed
            Name = name;
            var initKnowledge = new Knowledge(random.Next(0, 100));
            SetKnowledge(initKnowledge);
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            //TODO: Implementation is needed
            Knowledge = knowledge;
        }

        public int getKnowledgeLevel()
        {
            return Knowledge.getKnowledgeLevel();
        }
    }
}