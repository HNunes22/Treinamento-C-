using StringBuilder.Entities;

namespace stringBuilderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow That's Aweasome!");

            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Travelling to New Zealand", "I'm Going to visit this wonderful countty!", 12);
            p1.addComent(c1);
            p1.addComent(c2);


            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the Force be with you!");
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good Night guys", "See you tomorrow", 5);
            p2.addComent(c3);
            p2.addComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}