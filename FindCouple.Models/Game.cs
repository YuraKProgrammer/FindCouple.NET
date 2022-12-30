using FindCouple.Models.Generators;

namespace FindCouple.Models
{
    public class Game
    {
        public GameField Field;
        public FieldGenerator fieldGenerator = new FieldGenerator();

        public Game(int size)
        {
            Field = fieldGenerator.Generate(size);
        }
    }
}