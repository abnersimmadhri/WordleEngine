using System;
using System.Collections.Generic;

public class Program
{
    /*
         In Wordle, players have six attempts to guess a five-letter word, with feedback given for each guess in the 
         form of coloured tiles indicating when letters match or occupy the correct position.
         
         For example, if the word a player is trying to guess is "space" and they enter "stamp" then:
         > The s is the correct letter and in the correct position so a green tile would be shown in the first position
         > Similarly the a is in the correct position so the 3rd tile would also be green
         > The p is the correct letter, but in the wrong position so a yellow tile would be displayed for the p
         > The t and the m are not in the answer the player is trying to guess so they would be displayed as grey
         
         You need to implement an algorithm that, given the player's guess and the correct answer, outputs a 5 character string with:
         > A "G" for each character in the guess that is in the correct position and should be marked "Green"
         > A "Y" for each character in the guess that is in the answer, but not in the correct position
         > An "X" for each character in the guess that is not in the answer
         
         For the example above (guess = stamp, answer = space) the expected output of the algorithm is "GXGXY"
    */

    public static void Main()
    {
        //Answer = space
        Console.WriteLine("Guess: stamp | Answer: space | Expected: GXGXY | Output: " + WordlePattern("stamp", "space"));
        Console.WriteLine("Guess: space | Answer: space | Expected: GGGGG | Output: " + WordlePattern("space", "space"));
        Console.WriteLine(string.Empty);
        //Answer = bored
        Console.WriteLine("Guess: bloom | Answer: bored | Expected: GXYXX | Output: " + WordlePattern("bloom", "bored"));
        Console.WriteLine(string.Empty);
        //Answer = erase
        Console.WriteLine("Guess: sleep | Answer: erase | Expected: YXYYX | Output: " + WordlePattern("sleep", "erase"));
        Console.WriteLine("Guess: eject | Answer: erase | Expected: GXYXX | Output: " + WordlePattern("eject", "erase"));

        //Answer = steer
        Console.WriteLine("Guess: easee | Answer: steer | Expected: YXYGX | Output: " + WordlePattern("easee", "steer"));

        //Answer = error
        Console.WriteLine("Guess: error | Answer: steer | Expected: YXXXG | Output: " + WordlePattern("error", "steer"));

    }

    public static string WordlePattern(string guess, string answer)
    {
        char[] response = new char[guess.Length];

        Dictionary<char, int> answerDict = new Dictionary<char, int>();

        for(int i =0; i< answer.Length; i++)
        {
            if (answer[i] == guess[i])
            {
                response[i] = 'G';
            }
            else
            {                
                if (answerDict.ContainsKey(answer[i]))
                {
                    answerDict[answer[i]]++;
                }
                else
                {
                    answerDict.Add(answer[i], 1);
                }

                response[i] = 'X';
            }
        }


        for (int i= 0; i< guess.Length; i++)
        {
            if(response[i] == 'X' && answerDict.ContainsKey(guess[i]))
            {
                if(answerDict[guess[i]] >0)
                {
                    response[i] = 'Y';
                    answerDict[guess[i]]--;
                }
               
            }

        }


        return new string(response);
    }


    
}