namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        //q1
        //Create two Customer objects
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        //Print initial information
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        //Update IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        //Print updated information
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        //Compare their ages (using customer1 to compare against customer2)
        customer1.CompareAge(customer2);
    }
}

//Customer class
class Customer
{
    private int cus_id;      //private
    public string cus_name;  //public 
    public int cus_age;      //public

    //Constructor to initialize id, name, and age
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    //change customer's ID
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    //print customer information
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
    }

    //compare ages and print the name of the older customer
    
    public void CompareAge(Customer objCustomer)
    {
        if (cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{cus_name} is older");
        }
        else if (cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
        
    }
}
