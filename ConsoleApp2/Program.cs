using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Request full name
            Console.Write("Please type your full name and press <Enter> ");
            String fullName = Console.ReadLine();
            Console.WriteLine($"Your full name is {fullName} \n");

            //Request Location
            Console.Write("Please enter your location(State/Country) and press <Enter> ");
            String location = Console.ReadLine();
            Console.WriteLine($"Your location is {location} \n");

            //Display name and location using interpolation
            Console.WriteLine($"Your name is {fullName}, and you are from {location}. \n");

            //Current Date
            Console.WriteLine($"The Current date is {DateTime.Now.ToString("MM/d/yyyy")} \n");

            //Days Until Christmas  
            DateTime christmas = new DateTime(2019, 12, 25);
            double daysUntilChristmas = christmas.Subtract(DateTime.Today).TotalDays;

            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas \n");

            //Code from the textbook 2.1.1
            double width, height, woodLength, glassArea;

            const double maxWidth = 5.0;
            const double minWidth = 0.5;
            const double maxHeight = 3.0;
            const double minHeight = 0.75;

            string widthString, heightString;

            //Get width
            Console.Write("Enter width without the metric unit and press <Enter>");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine();

            while (width < minWidth || width > maxWidth)
            {
                Console.Write($"Give the width of the window between {minWidth} and {maxWidth} and press <Enter>: ");

                widthString = Console.ReadLine();
                width = double.Parse(widthString);
                Console.WriteLine();
            }
                

            //Get height
            Console.Write("Enter height without the metric unit and press <Enter>");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            Console.WriteLine();


            while (height < minHeight || height > maxHeight)
            {
                Console.Write($"Give the height of the window between {minHeight} and {maxHeight} and press <Enter>: ");

                heightString = Console.ReadLine();
                height = double.Parse(heightString);
                Console.WriteLine();
            }

            //Calcualate Width and height
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //Output final width and height
            Console.WriteLine($"The length of the wood is {woodLength} feet \n");
            Console.WriteLine($"The area of the glass is {glassArea} square metres \n");

            Console.Write("Please enter any key to terminate the program");
            Console.ReadKey();
        }
    }
}
