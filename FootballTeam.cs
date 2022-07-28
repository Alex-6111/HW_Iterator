

namespace HW_Iterator
{
    public class FootballTeam
    {
        public List<Player> team = new List<Player>()
        {
            new Player("Bohdan", 5, 23),
            new Player("Ivan", 4, 21),
            new Player("Oleg", 3, 22),
        };

        public IEnumerator<Player> GetEnumerator()
        {
            for(int i = 0; i < team.Count; i++)
            {
                yield return team[i];
            }
        }
    }

    public class Player
    {
        public string? Name { get; set; }
        public int? Number { get; set; }
        public int? Age { get; set; }

        public Player(string? name, int? number, int? age)
        {
            Name = name;
            Number = number;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name -> {Name}\n Number -> {Number}\n Age -> {Age}\n";
        }
    }
}
