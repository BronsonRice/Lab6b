using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
  

  int i =0;
  int num = 0;
  int[] OddNum = new int[num];
  int[] EvenNum = new int[num];

  for(i=0; i <10; i++)
  {
    Console.WriteLine("Enter number");
    num = Convert.ToInt32(Console.ReadLine());
    int remainder = num % 2;
    if(remainder ==1)
    {
      Console.WriteLine(num + "odd");
    }
    else
    {
      Console.WriteLine(num + "even");
    }
  }
  



      
     
  
  





  




    




   

  }
}