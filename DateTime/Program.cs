using System;
namespace DateTimeAssignment;
class Program{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date.ToString("yyyy"));
        Console.WriteLine(date.ToString("MM"));
        Console.WriteLine(date.ToString("dd"));
        Console.WriteLine(date.ToString("hh"));
        Console.WriteLine(date.ToString("mm"));
        Console.WriteLine(date.ToString("ss"));
        
        string date1 = date.ToString();
        Console.WriteLine(date1);
        String [] date3 = date1.Split(new char[] {'/',':',' '});
        for(int i=date3.Length-1;i>=0;i--){
            Console.Write(date3[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Enter the date :yyyy/MM/dd hh:mm:ss tt");
        DateTime  date4 = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        Console.WriteLine(date4.ToString("yyyy"));
        Console.WriteLine(date4.ToString("MM"));
        Console.WriteLine(date4.ToString("dd"));
        
            }
     
}
