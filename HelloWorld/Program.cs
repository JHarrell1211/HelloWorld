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
            // Part one greetings statement
            //string messageOne = "Hello World!";
            //string messageTwo = "I am Spartacus";

            //// Part two set initial Spartacus attributes
            //int ageOne = 35;
            //int ageTwo = 45;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false; 
            //char genderMale =  'M';
            //char genderFemale = 'F';

            ////Part three display variable value
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);

            ////Part four mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);

            ////Part five variable reassignment
            //heightTwo = 35.12345f;
            //weightTwo = -429 - 1234573f;
            //ageTwo = 70;

            ////Part six mathematical operator examples
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part seven increment and decrement operator examples
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);

            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);

            //Part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".\n" );

            //ageOne = 35;
            //weightOne = 210;
            //heightOne = 72;

            //Console.WriteLine("I am " + ageOne + " and yes it's " + isGodLikeOne + " I am godlike.");
            //Console.WriteLine("I weigh around " + weightOne + " pounds and I am around " + heightOne + " inches tall.\n");

            //Console.WriteLine("I am {0}, and yes it's {1} I am godlike.", ageOne, isGodLikeOne );
            //Console.WriteLine("I weigh around {0} pounds and I am around {1} inches tall.", weightOne, heightOne);

            //Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));
            //Console.WriteLine(ageOne.Equals(5));

            //Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //Console.WriteLine("Phil said, \"You've got red on you\".")

            //Part eleven conditional examples
            //string city1 = "Vesuvlus";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Select user input example
            //Console.WriteLine("What is the distance to {0}", city1);
            //city1Distance = int.Parse(Console.ReadLine()); ;
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the idstance to {0} ?", city3);
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && ((city1Distance < city2Distance) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("we will march to Vesuvlus");
            //}
            //if ((city2Distance <= 125) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("weil will march to Nola");
            //}
            //if ((city3Distance <= 125) && ((city3Distance < city1Distance) && (city3Distance < city2Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}

            //Part 12
            //Console.WriteLine("What is your rank soldier? ");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age soldier? ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier? ");
            //string job = Console.ReadLine();

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook") && (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat.  Pack your pots and pans");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry your are staying home.");
            //}

            //Part 13
            //switch (job)
            //
            //    case "infantry":
            //        Console.WriteLine("You will carry a sword");
            //        break;

            //    case "archers":
            //        Console.WriteLine("You will carry a bow and arrow");
            //        break;

            //    case "supply":
            //        Console.WriteLine("You will carry pots and pans");
            //        break;

            //    case "catapault":
            //        Console.WriteLine("You will operate the catapault");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback");
            //        break;

            //}

            //Part 14
            string[] foodList = new string[5];
            foodList[0] = "Milk";
            foodList[1] = "Fruit";
            foodList[2] = "Meat";
            foodList[3] = "Wine";
            foodList[4] = "Bread";

            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            int[] foodAmount = new int[5];
            foodAmount[0] = 1000;
            foodAmount[1] = 100;
            foodAmount[2] = 2000;
            foodAmount[3] = 10000;
            foodAmount[4] = 1500;

            //Console.WriteLine("{0}, {1}, {2}, {3}, {4} \n", foodAmount[0], foodAmount[1], foodAmount[2], foodAmount[3], foodAmount[4]);

            //Console.Write(foodAmount[0] + " " + foodList[0] + "; " + foodAmount[1] + " " + foodList[1] + "; " + foodAmount[2] + " " + foodList[2] + "; ");
            //Console.WriteLine(foodAmount[3] + " " + foodList[3] + "; " + foodAmount[4] + " " + foodList[4] +"\n");

            //Console.WriteLine(foodList.Length);

            // Splitting Strings
            //string[] elements = messageTwo.Split(' ');
            //Console.WriteLine(elements[0]);
            //Console.WriteLine(elements[1]);
            //Console.WriteLine(elements[2]);

            //string myName = "Sue";
            //char[] letters = myName.ToCharArray();
            //letters[1] = 'w';
            //Console.WriteLine(letters[0] + "" + letters[1] + "" + letters[2]);

            //string[] people = new string[4];
            //people[0] = "jim";
            //people[1] = "lisa";
            //people[2] = "ray";
            //people[3] = "greg";

            //Console.WriteLine("My friends are {0}, {1}, {2}, {3}", people[2],people[3],people[0],people[1]);

            //Part 15 - While Loop
            //string action = " ";

            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine(); 

            //Do While Loop
            //string action = " ";
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //}
            //    while (action != "exit");

            //Food Array
            //for (int i = 0; i < foodAmount.Length; i++)
            //{
            //    //Console.WriteLine("Enter Food: ");
            //    //foodList[i] = Console.ReadLine();
            //    Console.WriteLine("Please enter amount of " + foodList[i]);
            //    foodAmount[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("");
            //for (int i = 0; i < foodList.Length; i++)
            //{
            //    Console.WriteLine(foodAmount[i] + " " + foodList[i]);
            //}

            int size = 5;    //Equals the max number of columns and rows
            int i, k;
            for (i = 0; i <= size; i++)
            {
                for (k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }

    }
}
 