using System;
using Cards;
using Managers;
using UnityEngine;

public class CardGameManager : MonoBehaviour
{
    [SerializeField] private GameObject submitZone;
    [SerializeField] private PlayerDeck _playerDeck;
    [SerializeField] private EnemyDeck _enemyDeck;

    private void Start()
    {
       float width = submitZone.GetComponent<RectTransform>().rect.width;
    }

    private void Update()
    {
        
    }

    public ICard SubmitCard()
    {
        GameManager.Instance.CurrentCard.ExecuteAction();
        return null;
    }
}
