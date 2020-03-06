using Microsoft.VisualStudio.TestTools.UnitTesting;
using Replacer.Models;
using System;

namespace Replacer.Tests
{
  [TestClass]
  public class MakeFilesTests
  {
    [TestMethod]
    public void ReplacerConstructor_CreatesNewInstance_Replacer()
    {
      // Arrange
      string phrase = "Hello world", word = "world", replacement = "Haru";
      Replacer newReplacer = new Replacer(phrase, word, replacement);
      // Act
      // Assert
      Assert.AreEqual(typeOf(newReplacer), Replacer.GetType());
    }

    [TestMethod]
    public void CheckForWord_PhraseContainsWord_True()
    {
      // Arrange
      string phrase = "Hello world", word = "world", replacement = "Haru";
      Replacer newReplacer = new Replacer(phrase, word, replacement);
      // Act
      bool wordExists = newReplacer.CheckForWord();
      // Assert
      Assert.AreEqual(true, wordExists);
    }

    [TestMethod]
    public void ReplaceWord_ReplacementWordReplacesWordInPhrase_String()
    {
      // Arrange
      string phrase = "Hello world", word = "world", replacement = "Haru";
      Replacer newReplacer = new Replacer(phrase, word, replacement);
      // Act
      string updatedPhrase = newReplacer.ReplaceWord();
      // Assert
      Assert.AreEqual(true, updatedPhrase);
    }

  }
}