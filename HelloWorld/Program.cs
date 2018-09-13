using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //this comments a line

            /*this is for 
             * 
             * 
             * multiple lines*/

            //this is the shortcut to comment a line- use VS standard toolbar

            //console.writeline("Hello world!"); //write this string to the console and perform a carriage return
            //console.writeline("This is the second string of my program");
            //console.writeline(42);
            //console.writeline(1.23);
            //console.writeline(2 + 3);  //the compiler is reading the code from top down because it is linear

            //string message = "hello world!";
            //console.writeline(message);

            //system.string mystring = "my string";
            //console.writeline(mystring);

            ////Part One greetings statement
            string messageOne = "Hello world!";
            string messageTwo = "I am Spartacus";

            ////Part Two set initial Spartacus attributes
            int ageOne = 35;
            int ageTwo = 45;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.028461f;
            float weightTwo = 331.123457f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'm';
            char genderFemale = 'f';

            ////Part three display variable values
            //console.writeline();
            //console.writeline("original values:");
            //console.writeline(messageone);
            //console.writeline(messagetwo);

            ////Part four mathematical operator, bool and char examples
            //console.writeline(ageone + agetwo);
            //console.writeline(heightone - heighttwo);
            //console.writeline(weightone * weighttwo);
            //console.writeline(isgodlikeone);
            //console.writeline(gendermale);

            ////Part five variable reassignment
            //console.writeline();
            //console.writeline("new values:");
            //agetwo = 110;
            //heighttwo = 35.12345f;
            //weighttwo = -429.123456f;

            ////Part six mathematical operator examples
            //console.writeline(ageone + agetwo);
            //console.writeline(heightone - heighttwo);
            //console.writeline(weightone * weighttwo);

            //console.writeline(agetwo % 2 == 0);

            ////Prefix and Postfix increment operators
            //int test = 1;
            //test++;
            //console.writeline(test);
            ////console.writeline(test++);
            ////console.writeline(test);

            //test = 1;
            //console.writeline(test);
            //console.writeline(++test);
            //console.writeline(test);

            //console.writeline("test:");
            //console.writeline(false && false);

            ////Expressions example
            //bool isMitchells = true;
            //bool isBrookstone = false;
            //Console.WriteLine((isMitchells && isBrookstone) || (isMitchells || isBrookstone));
            //Console.WriteLine(!isMitchells);

            ////Real world AND/OR expressions example
            //bool isQuarterbackInjured = false;
            //bool isWeatherRain = false;
            //bool isLightningPresent= false;

            //bool isGameCancelled;
            //isGameCancelled = (isQuarterbackInjured || (isWeatherRain && isLightningPresent));

            //Console.WriteLine(isGameCancelled);
            //Console.WriteLine();

            //Part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " years old, and it is " + isGodLikeOne + " that I am godlike.");
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            //Console.WriteLine("{0} {1}", messageOne, messageTwo);

            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.Write("The length of messageTwo is " + messTwoLength + ".\n");

            ////Part 11: Conditional examples
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Solicit user input
            //Console.WriteLine("What is the distance to {0}", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is te distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && (city1Distance < city2Distance) && (city1Distance < city3Distance))
            //{
            //    Console.WriteLine("We will march to {0}", city1);
            //}
            //if ((city2Distance <= 125) && (city2Distance < city1Distance) && (city2Distance < city3Distance))
            //{
            //    Console.WriteLine("We will march to " + city2);
            //}
            //if ((city3Distance <= 125) && (city3Distance < city1Distance) && (city3Distance < city2Distance))
            //{
            //    Console.WriteLine("We will march to {0}", city3);
            //}

            //Console.WriteLine("What is your rank?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());

            //if ((rank.ToLower() == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are staying home.");
            //}

            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine().ToLower();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier?");
            //string job = Console.ReadLine().ToLower();

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook") && (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are staying home.");
            //}

            //switch (job)
            //{
            //    case "infantry":
            //        Console.WriteLine("You will carry a sword.");
            //        break;

            //    case "archer":
            //        Console.WriteLine("You will carry a bow and arrow.");
            //        break;

            //    case "supply":
            //        Console.WriteLine("You will carry pots and pans.");
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate the catapult.");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback.");
            //        break;
            //}

            //List<int> fibArray = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            //foreach (int element in fibArray)
            //{
            //    Console.WriteLine(element);
            //}

            //isGodLikeOne = IsGodLike(ageOne);  //ageOne previously assigned to 35
            //Console.WriteLine("To say our hero is God like is " + isGodLikeOne);
            Console.WriteLine(Reverse(messageTwo));  //messageTwo previously assigned to 'I am Spartacus'

        } //Main() method

        static bool IsGodLike(int age)
        {
            bool status;
            if (age % 2 == 0)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        } //IsGodLike() method

        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = " ";
            for (int i = cArray.Length -1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        } //Reverse() method

    } //Program

} //HelloWorld Namespace
