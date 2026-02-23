namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        Console.WriteLine("Please input two integers:"); //asks user for input and stores into variables a and b
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int large = Largest(a, b);
        Console.WriteLine($"The largest number is: {large}");

        // Q2 - calls Maximum()
        Maximum();

        // Q3 calls CreateAccount()
        CreateAccount();
    }

    static int Largest(int a, int b) //Method named largest stores two variables
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Maximum() //method 2
    {
        Console.WriteLine("Please input four integers for Q2:"); // Asking user for input for q2

        int a = Convert.ToInt32(Console.ReadLine()); //stores user input
        int b = Convert.ToInt32(Console.ReadLine());//stores user input
        int c = Convert.ToInt32(Console.ReadLine());//stores user input
        int d = Convert.ToInt32(Console.ReadLine());//stores user input

        int max1 = Largest(a, b);//compares a and b and stores variable in max3
        int max2 = Largest(c, d);//compares c and d and stores variable in max2
        int max = Largest(max1, max2);//compares max1 and max2 and stores result in variable max

        Console.WriteLine($"a = {a}; b={b}; c = {c}; d={d};");
        Console.WriteLine($"The largest number is: {max}");
    }

    static bool CheckAge(int birth_year) //checks the age of the user
    {
        int current_year = 2026;
        int age = current_year - birth_year;
        if (age >= 18)//checks age is 18 and up
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void CreateAccount()
    {
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Your Password:");
        string password = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again:");
        string passwordAgain = Console.ReadLine();

        Console.WriteLine("Enter Your Birthyear:");
        int birth_year = Convert.ToInt32(Console.ReadLine());

        if (CheckAge(birth_year)) //if birth year is above 18
        {
            if (password == passwordAgain)//checks passwords 
            {
                Console.WriteLine("Account is created successfully");  //prints if passwords do match
            }
            else
            {
                Console.WriteLine("Wrong password");  //prints if passwords do not match
            }
        }
        else
        {
            Console.WriteLine("Could not create an account.");  // prints this statement if age is not 18 or above.
        }
    }
}