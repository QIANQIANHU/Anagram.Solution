using System.Collections.Generic;

namespace Anagram.Models
{
  public class AnagramVariable
  {
    private string _wordOne;
    private string _wordTwo;

    public AnagramVariable(string wordOne, string wordTwo)
    {
      _wordOne = wordOne;
      _wordTwo = wordTwo;
    }

    public string GetWordOne()
    {
      return _wordOne;
    }
    public string GetWordTwo()
    {
      return _wordTwo;
    }

  }
}
