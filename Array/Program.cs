using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        string [] array = new string[5]{"Mani", "Ganesh", "Venkat", "Suresh", "Venkat"};
         for(int i =0;i<array.Length;i++){
            Console.WriteLine(array[i]);
         }
         bool flag =true;
         Console.WriteLine("Enter the name to search");
         string name = Console.ReadLine();
         for(int i=0; i<array.Length;i++){
            if(name==array[i]){
                flag=false;
                Console.WriteLine("The name is present in the array");
                Console.WriteLine(i);

            }
            
         }
         if(flag){
            Console.WriteLine("The name is not present in the array");
         }
         Console.WriteLine("Enter the name to search");
          string name1 = Console.ReadLine();
          flag=true;
          foreach(String i in array){
            if(name1==i){
                flag=false;
                Console.WriteLine("The name is present in the array");
            }

          }
          if(flag){
            Console.WriteLine("The name is not present in the array");
    }
          
}
}
