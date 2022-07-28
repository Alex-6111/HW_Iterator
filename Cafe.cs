using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Iterator
{
    public class Cafe
    {
        public List<Worker> workers = new List<Worker>()
        {
            new Worker(1, "Anna", "Kostuk", "Admin"),
            new Worker(2, "Olena", "Melnyk", "Waitress"),
            new Worker(3, "Alina", "Boyko", "Waitress")
        };

        public IEnumerator<Worker> GetEnumerator()
        {
            for(int i = 0; i < workers.Count; i++)
            {
                yield return workers[i];
            }
        }
    }

    public class Worker
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Position { get; set; } 

        public Worker(int? id, string? name, string? surname, string? position)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Position = position;
        }

        public override string ToString()
        {
            return $"ID -> {Id}\n Name -> {Name}\n Surname-> {Surname}\n Position -> {Position}\n";
        }
    }
}
