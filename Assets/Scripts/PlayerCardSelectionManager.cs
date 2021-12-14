using System;
using Cards;
using Managers;
using UnityEngine;

public class PlayerCardSelectionManager : MonoBehaviour
{
    [SerializeField] private GameObject submitZone;
    [SerializeField] private float submitTime = 5f;
    [SerializeField] private PlayerDeck _playerDeck;

    private Rect rect;
    private float deltaTime = 0f;
    
    private void Start()
    {
        rect = submitZone.GetComponent<RectTransform>().rect;
    }

    private void Update()
    {
        if (IsCursorWithinBounds() && GameManager.Instance.CurrentCard != null)
        {
            deltaTime += Time.deltaTime;
        }
        else
        {
            deltaTime = 0f;
        }

        if (deltaTime >= submitTime)
        {
            SubmitPlayerCard();
        }
    }

    private bool IsCursorWithinBounds()
    {
        float width = rect.width;
        float height = rect.height;
        
        float xPos = Input.mousePosition.x;
        float yPos = Input.mousePosition.y;

        Vector3 submitPos = submitZone.transform.position;

        bool isX = (xPos < submitPos.x + width / 2 && xPos > submitPos.x - width / 2);
        bool isY = (yPos < submitPos.y + height / 2 && yPos > submitPos.y - height / 2);

        return isX && isY;
    }

    private void SubmitPlayerCard()
    {
        if (GameManager.Instance.CurrentCard == null)
            return;
        
        Debug.Log("Submitted");
        GameManager.Instance.CurrentCard.ExecuteAction();
        _playerDeck.playerHand.Remove(GameManager.Instance.CurrentCard);
        _playerDeck.playerDeck.Enqueue(GameManager.Instance.CurrentCard);

        GameManager.Instance.CurrentCard = null;
        
    }
}
