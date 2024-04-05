using System.Security.Cryptography.X509Certificates;

namespace Prog120_S24_Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.ReadLine();

            // Vicky Le
            // 04 04 2024
            // Programming 1

            // Asked for the users name
            Console.Write("Enter your name: ");
            // string variable to hold value that is being returned from Console.ReadLine();
            string userName = Console.ReadLine();

            Console.WriteLine("Display User Name:" + userName);

            // Ask for the date
            // Console.Write("What is the date? ");
            // string userDate = Console.ReadLine();
            // $ - String Interpolation
            // $"{placeholder}
            // Console.WriteLine($"The date is {userDate}");

            // Ask for the class
            Console.Write("What is the class? ");
            string userClass = Console.ReadLine();
            Console.WriteLine($"Your class is {userClass}");
            // $
            // @


            // Vicky Le
            // 04 04 2024
            // Programming 1
            Console.WriteLine("//" + userName);
            Console.WriteLine($"// {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"// {userClass}");

            // Console.ReadKey();

        } // End of Main
        public static void StringExample() 
        {  // Variables
           // type
           // string, bool, int, double
           // String - A collection of characters
           // A string is defined with double quotes

            // Declaring and initializing a variable
            // equal sign, = , assignment operator

            string teachersName = "Will";

            // Declare a variable
            // Naming convention for variables
            string futureProgrammer; //Declare
            string favoriteGame = "Tears of the Kingdom"; //Declare and initialize



            string x, q, y, XX, t, u;

            // Declaring multiple variables of the same type in one line
            string student1, student2, student3;

            // Cannot use a variable before it's been declared

            string bestWindInstrument;
            bestWindInstrument = "Flute";


            Console.Write("Hello, ");
            Console.WriteLine(teachersName);

            teachersName = "Hoang";
            Console.Write("Hello, ");
            Console.WriteLine(teachersName);


            // Debugger
            // git commit -m "Update"
            // Concatenate
            // Adding two strings together to form one long string
            string firstName = "Vicky";
            string lastName = "Le";


            Console.WriteLine(firstName + " " + lastName);

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            firstName = "Vitalli";
            lastName = "Bobyr";
            fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);


            // The shortcut for console writeline is cw tab tab 
        }

        //public static void Name() { }
        public static void Practice()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Benny Goodman");
            Console.WriteLine("-------------");
            Console.WriteLine("Where and When");
            Console.WriteLine("Sing, Sing, Sing");

            //Console.WriteLine()
            //Console.Write()

            //Curly Brace

            //Error
            //Compiled Time Error

            //Comments
            //End of practice
        }
    } // End of Class

} // End of namespace
