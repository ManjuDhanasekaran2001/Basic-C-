using System;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        int mark1 = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        int mark2 = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        int mark3 = int.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        string grade = Console.ReadLine();
        Console.Write("Enter mobile number: ");
        long mobileNo = long.Parse(Console.ReadLine());
        Console.Write("Enter mail id: ");
        string mail = Console.ReadLine();
        float total = mark1+mark2+mark3;
        float average=total/3;
        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine("Name: "+name);
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {mobileNo}");
        Console.WriteLine($"Marks1: {mark1}");
        Console.WriteLine($"Marks2: {mark2}");
        Console.WriteLine($"Marks3: {mark3}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine("Grade: "+grade);
        Console.WriteLine("Mail id: "+mail);
        

        
    }
}