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
            string customName = "";
            int customScore = 0;

            Console.WriteLine("Skriv ett namn:");
            customName = Console.ReadLine();
            customName = customName.Trim();
            customName = customName.ToUpper();


            bool success = false;
            Console.WriteLine("Skriv hens poäng:");
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out customScore);
                if (success == false)
                {
                    Console.WriteLine("Poängen måste vara ett rimligt heltal:");
                }
            }
            highScores[2] = customName + " " + customScore;
            Console.WriteLine();

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
