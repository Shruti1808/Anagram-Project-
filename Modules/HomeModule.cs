using Nancy;
using Anagram;
using System;
using System.Collections.Generic;

namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/results"] = _ => {
        string word = Request.Query["word"];
        string stringListWord = Request.Query["list-word"];
        string[] arrayListWord = stringListWord.Split(',');
        List<string> listWord = new List<string>(){};
        foreach (string singleword in arrayListWord)
        {
          listWord.Add(singleword);
        }
        AnagramChecker Anagram = new AnagramChecker();
        List<string> result = Anagram.Check(word, listWord);
        return View["results.cshtml", result];
      };
    }
  }
}
