using Xunit;
using System;
using System.Collections.Generic;

namespace Anagram
{
  public class AnagramTest
  {
    [Fact]
    public void AnagramChecker_CheckLengthOfUserInput_listWordOfEqualLength()
    {
      string userInput = "cat";
      List<string> listWordInput = new List<string>(){"act", "bread"};
      AnagramChecker testAnagram = new AnagramChecker();
      List<string> result = testAnagram.Check(userInput, listWordInput);
      List<string> expectedResult = new List<string>() {"act"};
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void AnagramChecker_CheckSortedUserInput_listWordOfSameLetters()
    {
      string userInput = "bread";
      List<string> listWordInput = new List<string>(){"beard", "cat"};
      AnagramChecker testAnagram = new AnagramChecker();
      List<string> result = testAnagram.Check(userInput, listWordInput);
      List<string> expectedResult = new List<string>() {"beard"};
      Assert.Equal(expectedResult, result);
    }
  }
}
