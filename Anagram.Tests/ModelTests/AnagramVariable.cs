using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;//namespace here is strict.
using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace Anagram.TestTools{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      //Arrange
      string wordOne = "lalala";
      AnagramVariable wordOneInst = new AnagramVariable(wordOne,"");
      //Act
      string wordOneResult = wordOneInst.GetWordOne();
      //Assert
      Assert.AreEqual(wordOne,wordOneResult);
    }
  //   [TestMethod]
  //   public void Get WordOne_ReturnWordOne_String()
  //   {
  //     //Arrange
  //
  //     //Act
  //
  //     //Assert
  //   }
  }
}
