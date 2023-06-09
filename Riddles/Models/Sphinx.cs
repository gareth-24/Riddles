using System.Collections.Generic;

namespace Riddles.Models
{
  public class Sphinx
  {
    private static string[] _questions = 
    {
      "What can bring back the dead; make you cry, make you laugh, make you young; is born in an instant, yet lasts a lifetime?",
      "This thing all things devour: birds, beasts, trees, flowers; gnaws iron, bites steel; grinds hard stones to meal; slays kings, ruins towns; and beats high mountains down.",
      "Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name; I promise you'll know, when you I do claim.",
      "As small as your thumb, I am light in the air. You may hear me before you see me, but trust that I'm there.",
      "I'm alive, but without breath; I'm as cold in life as in death; I'm never thirsty, though I always drink.",
      "I create my lair with earthen string, and dispatch my prey with a biting sting.",
      "What is always old and sometimes new; never sad, sometimes blue; never empty, but sometimes full; never pushes, always pulls?",
      "Never resting, never still; moving silently from hill to hill; it does not walk, run or trot; all is cool where it is not.",
      "At night they come without being fetched, and by day they are lost without being stolen.",
      "In spring I am gay in handsome array; in summer more clothing I wear; when colder it grows, I fling off my clothes; and in winter quite naked appear.",
      "What is large, yet never grows; has roots that cannot be seen; and taller than trees?",
      "What can run, but never walks; has a mouth, but never talks; has a head, but never weeps; has a bed, but never sleeps?"
    };
    private static string[] _answers = {"memories", "time", "death", "bumblebee", "fish", "spider", "moon", "sun", "stars", "tree", "mountain", "river"};
    public static string GetRiddle(int questionNumber)
    {
      string questionText = _questions[questionNumber];
      //List<string> riddlesList = _riddles.Keys.ToList();
      return questionText;
    }
    public static string GetAnswer(int answerNumber)
    {
      string answerText = _answers[answerNumber];
      //List<string> riddlesList = _riddles.Keys.ToList();
      return answerText;
    }
  }
}

// Question: What can bring back the dead; make you cry, make you laugh, make you young; is born in an instant, yet lasts a lifetime?
// Answer: Memories

// Question: This thing all things devour: birds, beasts, trees, flowers; gnaws iron, bites steel; grinds hard stones to meal; slays kings, ruins towns; and beats high mountains down.
// Answer: Time

// Question: Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name; I promise you'll know, when you I do claim.
// Answer: Death

// Question:  As small as your thumb, I am light in the air. You may hear me before you see me, but trust that I'm there.
// Answer: Bumblebee

// Question: I'm alive, but without breath; I'm as cold in life as in death; I'm never thirsty, though I always drink.
// Answer: Fish

// Question: I create my lair with earthen string, and dispatch my prey with a biting sting.
// Answer: Spider

// Question: What is always old and sometimes new; never sad, sometimes blue; never empty, but sometimes full; never pushes, always pulls?
// Answer: Moon

// Question: Never resting, never still; moving silently from hill to hill; it does not walk, run or trot; all is cool where it is not.
// Answer: Sun

// Question: At night they come without being fetched, and by day they are lost without being stolen.
// Answer: Stars

// Question: In spring I am gay in handsome array; in summer more clothing I wear; when colder it grows, I fling off my clothes; and in winter quite naked appear.
// Answer: Tree

// Question: What is large, yet never grows; has roots that cannot be seen; and taller than trees?
// Answer: Mountain

// Question: What can run, but never walks; has a mouth, but never talks; has a head, but never weeps; has a bed, but never sleeps?
// Answer: River