﻿using UtilizandoStringBuilders.Entities;
using System.Text;

namespace UtilizandoStringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome! B)");


            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComents(c1);
            p1.AddComents(c2);

            Comment c3 = new Comment("Good night S2");
            Comment c4 = new Comment("May the Force be with you!");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComents(c3);
            p2.AddComents(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
