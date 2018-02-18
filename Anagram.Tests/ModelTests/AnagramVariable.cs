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
    public void Get WordOne_ReturnWordOne_String()
    {
      //Arrange
      string wordOne = "wordOne";
      AnagramVariable wordOneInst = new AnagramVariable(wordOne,"");

      //Act

      //Assert
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
  // }
}
