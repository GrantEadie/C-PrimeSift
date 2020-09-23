using System;
using System.Collections.Generic;
using PrimeSift.Models;

namespace PrimeSift
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      int inputNumber = int.Parse(Console.ReadLine());
      Prime input = new Prime(inputNumber);

      string primedList = input.primeFinder();
      Console.WriteLine(primedList);

    }
  }
}