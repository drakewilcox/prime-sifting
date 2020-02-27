using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace UserInput
{
  public class Program
  {
   
    public static void Main()
    {
      Console.WriteLine("Enter a Number to Count To:");
      string stringInputNumber = Console.ReadLine();
      int startNumber = int.Parse(stringInputNumber);

      Numbers newNumber = new Numbers(startNumber);
      newNumber.CreateList();
     

    }
    
  }
}