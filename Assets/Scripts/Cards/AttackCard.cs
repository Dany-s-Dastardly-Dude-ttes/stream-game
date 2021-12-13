namespace Cards
{
    [System.Serializable]
    public class AttackCard
    {
        public string description;
        public float damage;
        
        public CardType Type => CardType.Attack;

        public string GetDescription()
        {
            return description; 
        }

        public float GetDamage()
        {
            return damage;
        }
        
        public void SetDescription(string descr)
        {
             description = descr; 
        }

        public void SetDamage(float amount)
        {
            damage = amount;
        }

    }
}