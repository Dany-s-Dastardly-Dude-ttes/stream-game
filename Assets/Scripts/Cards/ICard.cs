namespace Cards
{
    public interface ICard
    {
        CardType Type { get; }
        void ExecuteAction();
    }
}
