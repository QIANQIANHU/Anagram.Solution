using System.Collections.Generic;

namespace Anagram.Models
{
  public class AnagramVariable
  {
    private string _wordOne;
    private string _wordTwo;
    private int _id;

    public string GetUserName()
    {
      return _wordOne;
    }

    public void SetUserName(string newUserName)
    {
      _wordOne = newUserName;
    }

    public string GetPhoneNumber()
    {
      return _wordTwo;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _wordTwo = newPhoneNumber;
    }
  }
}
