using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cards;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public Queue<ICard> playerDeck;
    public List<ICard> playerHand;

    [SerializeField] private int maxHandSize = 5;

    public void DrawCards()
    {
        while (playerHand.Count < maxHandSize)
        { 
            ICard lastCard = playerDeck.Dequeue();
            playerHand.Add(lastCard);
        }
    }
}
