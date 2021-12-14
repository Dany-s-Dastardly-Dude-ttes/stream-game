using UnityEngine;

namespace Cards
{
    [System.Serializable]
    public class AttackCard : MonoBehaviour, ICard
    {
        public string description;
        public float damage;
        
        public CardType Type => CardType.Attack;
        public void ExecuteAction()
        {
            //throw new System.NotImplementedException();
        }

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