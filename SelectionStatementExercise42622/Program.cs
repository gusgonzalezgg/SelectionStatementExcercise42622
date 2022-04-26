using System;

namespace SelectionStatementExercise42622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Guess my fav number! Between 1-1000");

            //int myFavNumber = 7;

            // var r = new Random();
            //var favNumber = r.Next(1, 1000);
            //var userInput = int.Parse(Console.ReadLine());

            // if (myFavNumber == favNumber) { Console.WriteLine("Correct!"); }

            //else if (userInput > myFavNumber) { Console.WriteLine("Too high"); }


            // else if (userInput < myFavNumber) { Console.WriteLine("Too low"); }

            // else { Console.WriteLine("Never mind"); }


            Console.WriteLine("What's your favorite subject??");

            string answer = Console.ReadLine();
           

            switch (answer)
            {
                case "Math":
                    Console.WriteLine($"Wow! {answer}? Alright");
                    break;
                case "English":
                    Console.WriteLine($"Wow! {answer}? Cool");
                    break;
                case "Chemistry":
                    Console.WriteLine($"Wow! {answer}? Nice");
                    break;
                case "Gym":
                    Console.WriteLine($"Wow! {answer}? Sweet");
                    break;
                default:
                    Console.WriteLine("Ok");
                    break;

            }









            }

    }
}
