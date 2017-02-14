using System;
using System.Collections.Generic;

namespace Anagram
{
  public class AnagramChecker
  {
    public List<string> Check(string singleWord, List<string> listWord)
    {
      char[] char1 = singleWord.ToLower().ToCharArray();
      Array.Sort(char1);
      List<string> output = new List<string>(){};
      foreach (string word in listWord)
      {
        char[] char2 = word.ToLower().ToCharArray();
        Array.Sort(char2);
        if (singleWord.Length == word.Length && string.Join("",char1) == string.Join("",char1)){
          output.Add(word);
        }
      }
      return output;
    }
  }
}
