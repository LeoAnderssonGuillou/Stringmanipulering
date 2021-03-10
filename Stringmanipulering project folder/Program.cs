using System;

namespace Stringmanipulering_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] highScores = { "LENA 100000", "MICKE 23004", "MARTIN 2000" };
            string[] person;
            int totalScore = 0;


            for (int i = 0; i < 3; i++)
            {
                person = highScores[i].Split(' ');
                totalScore = totalScore + int.Parse(person[1]);
                Console.WriteLine(String.Join(" har ", person) + " poäng");
            }

            Console.WriteLine("Medelpoängen är " + totalScore / highScores.Length);



            Console.ReadLine();
        }
    }
}
