using System.Collections.Generic;
using System;

namespace PrimeSift.Models
{
  public class Prime
  {

    public int Number { get; set; }
    private static List<int> _numberList = new List<int> { };
    public Prime(int inputNumber)
    {
      Number = inputNumber;
      for (int i = 2; i <= inputNumber; i++)
      {
        _numberList.Add(i);
      }
    }

    public string primeFinder()
    {
      string primeList = "";
      for (int i = 0; i < _numberList.Count; i++)
      {
        int moduloCounter = 0;
        for (int j = 2; j <= (_numberList[i]/2); j++)
        {
          if ((_numberList[i] % j) == 0 && _numberList[i] != j)
          {
            moduloCounter++;
          }
        }
        if (moduloCounter == 0)
        {
          primeList = primeList + _numberList[i].ToString() + ", ";
        }
      }
      return primeList;
    }

    public static List<int> GetAll()
    {
      return _numberList;
    }
    public static void ClearAll()
    {
      _numberList.Clear();
    }

  }
}