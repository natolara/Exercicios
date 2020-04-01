using ExercicioStringBuilder.Entities;
using System;

namespace ExercicioStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Tenha uma boa viagem");
            Comment c2 = new Comment("Espero vc lá");
            Post post1 = new Post(DateTime.Parse("15/03/2015 23:14:20"),
                                                 "Viajar é bom",
                                                 "Vejo vcs amanha",
                                                 12);
            post1.Comments.Add(c1);
            post1.Comments.Add(c2);

            Console.WriteLine(post1);

            Comment c3 = new Comment("Tenha uma otima viagem");
            Comment c4 = new Comment("Espero vc lá ou aqui");
            Post post2 = new Post(DateTime.Parse("30/03/2015 23:14:20"),
                                                 "Viajar é ruim",
                                                 "Vejo vcs sempre",
                                                 15);
            post2.Comments.Add(c3);
            post2.Comments.Add(c4);

            Console.WriteLine(post2);





        }
    }
}
