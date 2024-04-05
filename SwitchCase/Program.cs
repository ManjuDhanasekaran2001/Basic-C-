using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Number1: ");
        double number1= double.Parse(Console.ReadLine());
        Console.Write("Enter the Number2: ");
        double number2= double.Parse(Console.ReadLine());
        Console.WriteLine("1. +\n2. -\n3. *\n4. / \n4. %");
        Console.Write("Choose The Operation to perfom: ");
        string option =Console.ReadLine();
        switch(option){
            case "+":{
                Console.WriteLine(number1+number2);
                break;
            }
             case "-":{
                Console.WriteLine(number1-number2);
                break;
            }
             case "*":{
                Console.WriteLine(number1*number2);
                break;
            }
             case "/":{
                Console.WriteLine(number1/number2);
                break;
            }
             case "%":{
                Console.WriteLine(number1%number2);
                break;
            }
            default:{
                Console.WriteLine("Operation is Invalid ");
                break;
            }
        }
    }
}