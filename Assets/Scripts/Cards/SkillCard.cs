namespace Cards
{
   [System.Serializable]
    public class SkillCard : ICard
    {
        public string description;

        public CardType Type => CardType.Skill;
        public void ExecuteAction()
        {
            
        }

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
