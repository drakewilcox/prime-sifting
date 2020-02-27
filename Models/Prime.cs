using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Numbers
  {
    public List<int> NumberList = new List<int>(){};
    private int _singleNumber;
    public Numbers(int singleNumber)
    {
      _singleNumber = singleNumber;
    }
    
    public void CreateList()
    {
      Console.WriteLine("hi there");
      for(int index = 1; index < _singleNumber; index++)
      {
        NumberList.Add(index);
      }
    }
    


  // public void Addlist()
  // {
  //   startNumber
  // }

  }
}