using System;

namespace Numbercomparison
{
    class Program
    {
  static void Main(string[] args) 
  {
      int number1;
      int number2;
      int number3;
      
    Console.Write("enter 1st number");
    number1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("enter 2nd number");
    number2 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("enter 3rd number");
    number3 = Convert.ToInt32(Console.ReadLine());
    
    if(number1>number2 && number1>number3)
    {
        Console.WriteLine("Largest number is" + number1);
    }
    else if(number2>number1 && number2>number3)
    {
        Console.WriteLine("Largest number is" + number2);
    }
    else
    {
        Console.WriteLine("Largest number is" + number3);
    }
        
        
    }  
    }
}