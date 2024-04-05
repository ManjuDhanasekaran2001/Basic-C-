using System;
namespace DoWhileLoop;
class Program{
    public static void Main(string[] args)
    {
        // string choice = String.Empty;
        // do{
        //     Console.Write("Enter the number: ");
        //     int number = int.Parse(Console.ReadLine());
        //     if(number==0){
        //         Console.WriteLine(" 0 is not even not odd");
        //     }
        //     else if(number%2==0){
        //         Console.WriteLine("the number is even");
        //     }
        //     else{
        //         Console.WriteLine("the number is odd");
        //     }
            
        //     Console.WriteLine("You want to repeat the procee?yes/no: ");
        //     choice=Console.ReadLine();
        //     while(true){
        //     if(choice=="yes" || choice=="no"){
        //         break;
        //     }
        //     else{
        //         Console.WriteLine("Provided input is wrong:Enter yes/no: ");
        //         choice=Console.ReadLine();
        //         continue;

        //     }
        //     }
            
        // }while(choice=="yes");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int product = 1;
        do{
            product = number1*number1;
            number2 = number2-1;
        }while(number2>0);
        Console.WriteLine(product);

    }
}