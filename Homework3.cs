namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //code for q1
        Console.WriteLine("Please input an integer:"); //asking for user input
        int n = Convert.ToInt16(Console.ReadLine()); //stores user input in int value n
        bool prime = true; //default value of prime is true
        if(n <= 1) //checks numbers less than or equal to 1
    {
      prime = false;
    }
    else
    {
      for(int numb = 2; numb < n; numb++) //checks numbers from 2 to n-1
      {
        if(n % numb == 0) //if input is divided by numb equals 0 exactly
        {
          prime = false; //prime becomes false
          break;//and breaks the loop
        }
      }
    }
    if (prime) //if user input is prime number
    {
      Console.WriteLine("N is prime"); //print n is prime
    }
    else
    {
      Console.WriteLine("N is non-prime");//else print n is non-prime
    }

//code for q2
      Console.WriteLine("Assign an int value to N:"); //asking for user input
      int num = Convert.ToInt16(Console.ReadLine()); //stores user input in int value num
      for(int i = 0; i<num; i++) //first for loop to set up first value comparison
      {
      for(int x =0; x<num; x++) //second for loop to set up second value comparison
        {
          Console.Write('#');
        }
        Console.WriteLine("");
      } 

//code for q3
     Console.WriteLine("Assign an int value to N:"); //asking for user input
      int nums = Convert.ToInt16(Console.ReadLine()); //stores user input in int value nums
      for(int rows = 0; rows<nums; rows++) //first for loop to set up first value comparison
      {
      for(int cols =0; cols<nums; cols++) //second for loop to set up second value comparison
        {
        if(rows>=cols) //if statement that compares first and second values
        {
            Console.Write('*');
        }
        }
        Console.WriteLine("");
      }  















    }
}
