using System;  
class factorial  
{  
    static void Main(string[] args)
{
  int i,fact=1,num;
  
    Console.Write("Calculate the factorial of a given number:\n");

    Console.Write("Input the number : ");
   num= Convert.ToInt32(Console.ReadLine()); 
  for(i=1;i<=num;i++)
      fact=fact*i;

  Console.Write("The Factorial of {0} is: {1}\n",num,fact);
 }
}
