namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //had help from my old computer science teacher Jill! She helped me work through the logic together :)
        //Code for q1:
        Console.WriteLine("Please input a letter grade:");
        string input = Console.ReadLine();
        string grade = input.ToLower();
        //Console.WriteLine(grade); commented line out to not double output the same value for all of these!

        if(grade == "a")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if(grade == "b")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if(grade == "c")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if(grade == "d")
        {
            Console.WriteLine("GPA point: 1");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
        
        Console.WriteLine("Please input the first num:");
        string input1 = Console.ReadLine();
       //Console.WriteLine(input1);
        Console.WriteLine("Please input the second num:");
        string input2 = Console.ReadLine();
        //Console.WriteLine(input2);
        Console.WriteLine("Please input the third num:");
        string input3 = Console.ReadLine();
        //Console.WriteLine(input3);

        int num1 = Convert.ToInt16(input1);
        int num2 = Convert.ToInt16(input2);
        int num3 = Convert.ToInt16(input3);

        if(num1 < num2 && num1 < num3)
        {
            Console.WriteLine("The smallest value is: " + num1);
        }
        else if(num2 < num1 && num2 < num3)
        {
            Console.WriteLine("The smallest value is: "+ num2);
        }
        else
        {
            Console.WriteLine("The smallest value is: " + num3);
        }

        
        
        //Code for  bonus question
        Console.WriteLine("Please input a year: ");
        string leap = Console.ReadLine();
        //Console.WriteLine(leap);
        int leapYear = Convert.ToInt16(leap);
       
       
        if(leapYear % 4 == 0) //checking if leapYear is divisible by 4 exactly
        {
            Console.WriteLine($"{leapYear} is a Leap Year.");
        }
        else if(leapYear % 100 == 0) //checking if leapYear is divisible by 100 exactly
        {
             Console.WriteLine($"{leapYear} is not a Leap Year");
        }
        else if(leapYear % 400 == 0) //checking if leapYear is divisible by 400 exactly
        { 

            Console.WriteLine($"{leapYear} is a Leap Year.");
        }
        else
        {
            Console.WriteLine($"{leapYear} is not a Leap Year");
        }
        
    }
}
    

