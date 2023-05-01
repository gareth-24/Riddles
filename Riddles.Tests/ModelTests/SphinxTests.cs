using Microsoft.VisualStudio.TestTools.UnitTesting;
using Riddles.Models;
using System.Collections.Generic;
using System;

namespace Riddles.Tests
{
  [TestClass]
  public class SphinxTests
  {
    Sphinx newSphinx = new Sphinx();
    [TestMethod]
    public void SphinxConstructor_CreatesInstanceOfSphinx_Sphinx()
    {
      Assert.AreEqual(typeof(Sphinx), newSphinx.GetType());
    }

    [TestMethod]
    public void GetRiddle_ReturnsString_String()
    {
      string newRiddle = Sphinx.GetRiddle(0);
      Assert.AreEqual(typeof(string), newRiddle.GetType());
    }

    [TestMethod]
    public void GetRiddle_ReturnsRiddleKeyString_String()
    {
      string newRiddle = Sphinx.GetRiddle(0);
      Assert.AreEqual("What can bring back the dead; make you cry, make you laugh, make you young; is born in an instant, yet lasts a lifetime?", newRiddle);
    }

    [TestMethod]
    public void GetAnswer_ReturnsAnswerString_String()
    {
      string newAnswer = Sphinx.GetAnswer(0);
      Assert.AreEqual("memories", newAnswer);
    }
  }
}