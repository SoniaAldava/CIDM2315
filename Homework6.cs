namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Q1 create two professors
        Professor prof1 = new Professor();
        prof1.profName = "Alice";
        prof1.classTeach = "Java";
        prof1.SetSalary(900);

        Professor prof2 = new Professor();
        prof2.profName = "Bob";
        prof2.classTeach = "Math";
        prof1.SetSalary(800);

        // create 2 students
        Student stud1 = new Student();
        stud1.studentName = "Lisa";
        stud1.classEnroll = "Java";
        stud1.SetGrade(90);

        Student stud2 = new Student();
        stud2.studentName = "Tom";
        stud2.classEnroll = "Math";
        stud2.SetGrade(80);
        //q2 printing details for students and professors
        Console.WriteLine($"Professor {prof1.profName} teaches {prof1.classTeach}, and the salary is: {prof1.GetSalary()}");
        Console.WriteLine($"Professor {prof2.profName} teaches {prof2.classTeach}, and the salary is: {prof1.GetSalary()}");

        Console.WriteLine($"Student {stud1.studentName} enrolls {stud1.classEnroll}, and the grade is: {stud1.GetGrade()}");
        Console.WriteLine($"Student {stud2.studentName} enrolls {stud2.classEnroll}, and the grade is: {stud2.GetGrade()}");
        
        //calculates the salary difference and prints to console
        double salaryDiff = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDiff}");

        //calculate and print total grade of students
        double totalGrade = stud1.GetGrade() - stud2.GetGrade();
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");
    }
}

//professor class
class Professor
{
    public string? profName;
    public string? classTeach;
    private double salary;
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary;
    }
}

//student class
class Student
{
    public string? studentName; // using ? to stop warning CS8618 nullable reference types
    public string? classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    public double GetGrade()
    {
        return studentGrade;
    }
}
