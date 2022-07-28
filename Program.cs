
namespace HW_Iterator
{
    internal class Program
    {
        static void Main()
        {
            //Problem1();
            //Problem2();
            Problem3();
        }

        public static void Problem1()
        {
            Oceanarium seaDwellers = new Oceanarium();
            foreach(var item in seaDwellers)
            {
                Console.WriteLine(item);
            }
        }

        public static void Problem2()
        {
            FootballTeam players = new FootballTeam();
            foreach(var item in players)
            {
                Console.WriteLine(item);
            }
        }

        public static void Problem3()
        {
            Cafe cafe = new Cafe();
            foreach(var item in cafe)
            {
                Console.WriteLine(item);
            }
        }



    }
}