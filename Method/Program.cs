using System;
using System.ComponentModel;
namespace Method;
class Program{
    public static void Main(string[] args)
    {
        
        string choice = String.Empty;
        do{
            Console.Write("Enter the number1: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the number2: ");
            double number2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("1.Additon\n2.Subtraction\n3.Multiplication\n4.Division");
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());
            switch(option){
                case 1:{
                    double result=Addition(number1,number2);
                    Console.WriteLine(result);
                    break;
                }
                case 2:{
                    double result=Subtraction(number1,number2);
                     Console.WriteLine(result);
                    break;
                }
                case 3:{
                    double result=Multiplication(number1,number2);
                     Console.WriteLine(result);
                    break;
                }
                case 4:{
                    double result=Division(number1,number2);
                     
                    break;
                }
            }
            Console.WriteLine("You want to repeat the procee?yes/no: ");
            choice=Console.ReadLine();
            
    

        }while(choice=="yes");
        static double Addition(double number1, double number2){
            double result=number1+number2;
            return result;
        }
        static double Subtraction(double number1, double number2){
            double result=number1-number2;
            return result;
        }
        static double Multiplication(double number1, double number2){
            double result=number1*number2;
            return result;
        }
        static double Division(double number1, double number2){
            double result=0;
            if(number2!=0){
            result =number1/number2;
            Console.WriteLine(result);
            
            }
            else{
                Console.WriteLine("We can not divide the number by 0");
                
            }
            return result;
            
        }
            }
}