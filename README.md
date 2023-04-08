# WordleEngine
Simple solution to score  a guess for the wordle game. 

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

Edge Cases:
> Guess: easee | Answer: steer | Expected: YXYGX

> Guess: error | Answer: steer | Expected: YXXXG

