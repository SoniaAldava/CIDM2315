namespace Homework9;

using System;
using System.Collections.Generic;

class Student
{
    private int studentID;
    private string studentName;

    // Public static list (Question 1)
    public static List<Student> studentList = new List<Student>();

    // Parameterized constructor
    // After creating the object, it automatically adds itself to the static list
    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    // Public PrintInfo method to print ID and name
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    // Helper getter so we can safely check names against the gradebook in Main
    // (private fields can't be accessed directly from outside the class)
    public string GetStudentName()
    {
        return studentName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // =============================================
        // Question 2: Create 4 students
        // =============================================
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        // =============================================
        // Question 3: Create gradebook Dictionary and add the 4 students' GPAs
        // =============================================
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook["Alice"] = 4.0;
        gradebook["Bob"] = 3.6;
        gradebook["Cathy"] = 2.5;
        gradebook["David"] = 1.8;

        // =============================================
        // Question 4: Check for "Tom" and insert if not present
        // =============================================
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        // =============================================
        // Question 5: Calculate and print average GPA of ALL entries in gradebook
        // =============================================
        double sum = 0;
        foreach (double gpa in gradebook.Values)
        {
            sum += gpa;
        }
        double averageGPA = sum / gradebook.Count;

        Console.WriteLine($"The average GPA is: {averageGPA}");

        // =============================================
        // Question 6: Print info for students (from studentList) whose GPA > average
        // Only Alice (4.0) and Bob (3.6) qualify; Tom is not in studentList
        // =============================================
        foreach (Student student in Student.studentList)
        {
            string name = student.GetStudentName();
            if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}
