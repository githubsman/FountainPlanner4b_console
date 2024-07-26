//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using FountainPlanner;

namespace FountainPlanner
{


    class Program
    {
        static void Main()
        {
            //TODO Invite user to begin design by setting MaxPressureTotal



            Console.WriteLine("Let's design a fountain project!");

            //FIXME allow the user to try again
            //while (countLineItem < 1 || countLineItem > 4)
            // {

            Console.WriteLine("You can have 1 to 4 features.  How many do you want?  ");
            string? UserInput = Console.ReadLine();     // in case of Null for entry, '?' makes UserInput nullable.

            if (int.TryParse(UserInput, out int intUserInput))
            {
                if (intUserInput > 0 && intUserInput < 5)
                {
                    
                    FountainProject MyProject;
                    MyProject = new FountainProject();
                    MyProject.countLineItem = intUserInput;
                    //FixtureWater[] myWaterFixtures = new FixtureWater[intUserInput]; //FIXME 3 is a placeholder
                    MyProject.FountainProjectBegin();

                }
                else
                {
                    Console.WriteLine("Enter a number between 0 and 4.");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

            //}
        }
    }
}