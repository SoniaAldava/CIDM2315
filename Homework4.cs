namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        
Console.WriteLine("Please input two integers:"); //asks user for input
        int a = Convert.ToInt16(Console.ReadLine()); //stores user input
        int b = Convert.ToInt16(Console.ReadLine()); //stores user input
        Largest(a,b); //calls method Largest
Console.WriteLine("Please input an integer and a direction [left or right]:");//asks user for input
        int n = Convert.ToInt16(Console.ReadLine()); //stores user input
        string direction = Console.ReadLine();//stores user input
        direction = direction.ToLowerInvariant();//takes string from user and makes it all lowercase
Console.WriteLine("N is: " + n + "; shape is " + direction); //prints what the user chose for int and shape/direction
        Shape(n, direction);//calls method Shape
    
    }
    static void Largest(int a, int b) //method that compares values and prints the largest code for q1 method 1
    {
        if(a > b) //if a is greater than b a is the largest number
        {
            Console.WriteLine("The largest number is: " + a); //prints a is the largest number
        }
        else if(b > a) //else if b is greater than a b is the largest number
        {
            Console.WriteLine("The largest number is: " + b); //prints b is the largest number
        }
        else
        {
            Console.WriteLine("Invalid input.");//if anything other than two ints is inputed is put prints this statement
        }
    }
    static void Shape(int n, string direction) //method for Shape, stores an int n and a string direction code for q2 method 2
    {
        if(direction == "left") //if the direction is left
        {
        for(int row = 1; row <= n; row++)//for statement that sets the value of the row
        {
            for(int col = 1; col <= row; col++)//for statement that sets the value of the colum
            {
                Console.Write("*");//prints the * symbol in the left direction
            }
            Console.WriteLine();
        }
        }
        else if(direction == "right"){ //if the direction = right
            for(int rows = 1; rows <= n; rows++)//for statement that sets the value of the rows
            {
                for(int cols = 1; cols <= (n - rows); cols++)//for statement that sets the value of the columns
                {
                    Console.Write(" ");//prints the spaces
                }
                for(int i = 1; i <= rows; i++)//for statement that prints the * symbol in the right direction
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
            
        }
        else
        {
            Console.WriteLine("Invalid input."); //if any direction is not left or right print this statement
        }

    }
    
}

