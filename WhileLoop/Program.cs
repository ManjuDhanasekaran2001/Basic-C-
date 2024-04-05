using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        //Exercise1
        int i =0;
        while(i<=25){
            if(i%2==0){
                Console.WriteLine(i);
            }
            i++;
        }

       //Exercise2

     while(true){
        Console.WriteLine("Enter the number input: ");
        int a= 0;
        bool result=int.TryParse(Console.ReadLine(),out a);
        
            if(result){
                Console.WriteLine(a);
                break;
            }
            else{
                Console.WriteLine("Invalid input format. Please enter the input in number format");
            }
        }
            Console.WriteLine("Enter the number input: ");
            bool isvalid  = int.TryParse(Console.ReadLine(),out int ouput);
            while(!isvalid){
                Console.WriteLine("Invalid:")
            }
        
    }
}