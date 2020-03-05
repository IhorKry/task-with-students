using System;

namespace InternshipTest
{
    public class Knowledge
    {
        private int KnowledgeLevel;

        public Knowledge(int level)
        {
            KnowledgeLevel = level;
        }

        public int GetKnowledgeLevel()
        {
            return KnowledgeLevel;
        }
    }
}
