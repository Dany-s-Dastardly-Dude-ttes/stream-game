namespace Cards
{
    [System.Serializable]
    public class PowerCard : ICard
    {
        public string description;
        
        public CardType Type => CardType.Power;
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
