namespace Battleships.Domain
{
    public class Player
    {
        public Player(string name, Field field)
        {
            Name = name;
            Field = field;
        }

        public string Name { get; }
        public Field Field { get; }
    }
}
