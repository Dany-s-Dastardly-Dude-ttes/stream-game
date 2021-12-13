using System;
using Cards;

namespace Managers
{
  [Serializable]
  public class GameState
  { 
    public AttackDeck attackDeck;
    public SkillDeck skillDeck;
    public PowerDeck powerDeck;
  }
  
}
