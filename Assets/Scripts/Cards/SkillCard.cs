namespace Cards
{
   [System.Serializable]
    public class SkillCard
    {
        public string description;

        public CardType Type => CardType.Skill;

        public string GetDescription()
        {
            return description; 
        }

        public void SetDescription(string descr)
        {
            description = descr; 
        }
    }
}
