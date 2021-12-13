namespace Cards
{
    public interface ICard
    {
        CardType type { get; }
        public void ExecuteAction();
    }
}
