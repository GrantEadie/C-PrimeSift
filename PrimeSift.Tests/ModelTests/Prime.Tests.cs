using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PrimeSift.Models;

namespace PrimeSift.Tests
{
  [TestClass]
  public class PrimeTests : IDisposable
  {
    public void Dispose()
    {
      Prime.ClearAll();
    }

    [TestMethod]
    public void NumberConstructor_CreateInstanceOfANumber_Number()
    {
      Prime newNumber = new Prime(20);
      Assert.AreEqual(typeof(Prime), newNumber.GetType());
    }

    [TestMethod]
    public void NumberConstructor_RecievesANumber_Number()
    {
      int inputNum = 2;
      Prime newNumber = new Prime(inputNum);
      int result = newNumber.Number;
      Assert.AreEqual(inputNum, result);
    }

    [TestMethod]
    public void GetAll_ReturnsIntegers_IntegerList()
    {
      Prime newNumber1 = new Prime(4);
      List<int> newNumberList = new List<int> {2,3,4};

      List<int> result = Prime.GetAll();

      CollectionAssert.AreEqual(newNumberList, result);
    }

        [TestMethod]
    public void PrimeFinder_ReturnsPrimeNumbers_IntegerList()
    {
      Prime newNumber1 = new Prime(9);
      string newNumberList = "2, 3, 5, 7, ";

      string primedList = newNumber1.primeFinder();

      Assert.AreEqual(newNumberList, primedList);
    }

  }
}