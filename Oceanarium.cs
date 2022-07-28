using System;


namespace HW_Iterator
{
    public class Oceanarium
    {
        public List<SeaDwellers> Oceanariums { get; set; } = new List<SeaDwellers>
        {
            new Jellyfish(),
            new Whale(),
            new Octopus(),
            new Crab(),
            new Shark()
        };

        public int Count => Oceanariums.Count;

        public IEnumerator<SeaDwellers> GetEnumerator()
        {
            for(int i = 0; i < Oceanariums.Count; i++)
            {
                yield return Oceanariums[i];
            }
        }
    }

    public class SeaDwellers
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class Jellyfish : SeaDwellers
    {

        public Jellyfish(string? name, string? description)
        {
            Name = name;
            Description = description;
        }

        public Jellyfish()
        {
            Name = "Medusozoa";
            Description = "A subtype of free-swimming marine animals of the cnidarian type";
        }

        public override string ToString()
        {
            return $"Name -> {Name}\n Description -> {Description}\n";
        }
    }

    public class Whale : SeaDwellers
    {
        public Whale(string? name, string? description)
        {
            Name = name;
            Description = description;
        }

        public Whale()
        {
            Name = "Humpback whale";
            Description = "A marine mammal of the Smugachev family of the cetacean suborder";
        }

        public override string ToString()
        {
            return $"Name -> {Name}\n Description -> {Description}\n";
        }
    }

    public class Octopus : SeaDwellers
    {
        public Octopus(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
        public Octopus()
        {
            Name = "Coconut octopus";
            Description = "Belong to the genus Amphioctopus";
        }

        public override string ToString()
        {
            return $"Name -> {Name}\n Description -> {Description}\n";
        }
    }

    public class Crab : SeaDwellers 
    {
        public Crab(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
        public Crab()
        {
            Name = "Ghost crab";
            Description = "Are semi-terrestrial crabs of the subfamily Ocypodinae";
        }
        public override string ToString()
        {
            return $"Name -> {Name}\n Description -> {Description}\n";
        }
    }

    public class Shark : SeaDwellers
    { 
        public Shark(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
        public Shark()
        {
            Name = "Whale shark";
            Description = "The largest species of shark, as well as the largest species of modern fish";
        }

        public override string ToString()
        {
            return $"Name -> {Name}\n Description -> {Description}\n";
        }
    }
}
