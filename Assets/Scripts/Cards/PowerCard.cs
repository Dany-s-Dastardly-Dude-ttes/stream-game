namespace Cards
{
    [System.Serializable]
    public class PowerCard 
    {
        public string description;

        public CardType Type => CardType.Power;

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
