using System;

namespace Addnumbers
{
    class Program
    {
  static void Main(string[] args) 
  {
      int number1;
      int number2;
      int total;
      
    Console.WriteLine("enter 1st number");
    number1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("enter 2nd number");
    number2 = Convert.ToInt32(Console.ReadLine());
    
    total = number1 + number2;
    
    Console.WriteLine("total is" +  total);
  }
    }
}