using System.Xml.Schema;
using Cards;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        private GameState State;

        public GameState CurrentGameState => State;

        private void Awake()
        {
            if (Instance == null) Instance = this;

            DontDestroyOnLoad(Instance.gameObject);
            Initialize();
        }
        
        private void Initialize()
        {
            State ??= new GameState();
            SetGameState();
        }

        private void SetGameState()
        {
            CardReader.LoadCards();
        }

        public PowerDeck PowerDeck
        {
            get => State.powerDeck;
            set
            {
                State.powerDeck = value;
            }
        }
        
        public AttackDeck AttackDeck
        {
            get => State.attackDeck;
            set
            {
                State.attackDeck = value;
            }
        }
        
        public SkillDeck SkillDeck
        {
            get => State.skillDeck;
            set
            {
                State.skillDeck = value;
            }
        }

        public ICard CurrentCard
        {
            get => State.selectedCard;
            set
            {
                State.selectedCard = value;
            }
        }
    }
}
