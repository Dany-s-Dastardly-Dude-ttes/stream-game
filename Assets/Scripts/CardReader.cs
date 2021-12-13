using Cards;
using Managers;
using UnityEngine;

public class CardReader : MonoBehaviour
{ 
    private static TextAsset _cardData;

    private static void ReadAttackCards()
    {
        GameManager.Instance.AttackDeck = JsonUtility.FromJson<AttackDeck>(_cardData.text);
    }

    private static void ReadSkillCards()
    {
        GameManager.Instance.SkillDeck = JsonUtility.FromJson<SkillDeck>(_cardData.text);
    }

    private static void ReadPowerCards()
    {
        GameManager.Instance.PowerDeck = JsonUtility.FromJson<PowerDeck>(_cardData.text);
    }

    public static void LoadCards()
    {
        //Load a text file (Assets/Resources/Text/CardData.json)
        _cardData = Resources.Load<TextAsset>("Text/CardData");
        ReadAttackCards();
        ReadSkillCards();
        ReadPowerCards();
    }
}