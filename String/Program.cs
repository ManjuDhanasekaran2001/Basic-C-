using System;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Main String");
        string name = Console.ReadLine();
        Console.WriteLine("String to be searched");
        string name2=Console.ReadLine();
        string name3 = name.Replace(name2,"1");
        int count=0;
        foreach(char i in name3){
            if(i=='1'){
                count++;

            }
        }  
        Console.WriteLine("String searched count is " +count); 
    }
}