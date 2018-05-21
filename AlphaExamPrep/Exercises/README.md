# Exercises for Telerik Alpha 2018 Exam

## Max Sum of 3x3 (MaxSum3x3)
	
	- Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.

## Sequence in Matrix (SequenceInMatrix)
	
	- We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

## Matrix of Numbers (MatrixOfNumbers)
	
	- Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.

## Miss Cat (MissCat)
	
	- There are two things that cats love most: 1) sleeping and 2) attending beauty contests. The most important thing for each female cat is the contest “Miss Cat”. There are always ten cats that participate in the final round of the contest, numbered 1 to 10.
The jury of the contest consists of N people who subjectively decide which cat to vote for. In other words each person votes for just 1 cat that he has most liked, or from whose owner he has received the biggest bribe. The winner of the contest is the cat that has gathered most votes. If two cats have equal votes, the winner of the contest is the one whose number is smaller.
Your task is to write a computer program that finds the number of the cat that is going to win the contest “Miss cat”

## Spell Caster (SpellCaster)

	- Step 1 - Extracting the characters
You are given a sentence that consists only of words of Latin characters (no punctuation, no special symbols or numbers). First, you need to turn that sentence into a sequence of characters in the following way: until all words disappear, the last letter of each word (if exists) is removed from the word and is appended to the output sequence of letters.
For example, let's say you receive the sentence "Fun exam right". You first split into 3 words: ["Fun", "exam", "right"]. Then the last letters are extracted: ["Fun", "exam", "right"] results into "nmt". And you continue as such:
["Fu", "exa", "righ"] => "nmtuah"
["F", "ex", "rig"] => "nmtuahFxg"
["", "e", "ri"] => "nmtuahFxgei"
["", "", "r"] => "nmtuahFxgeir".
After the extraction is finished, you are left with the sequence "nmtuahFxgei". It is now time to use that into the next step.
NOTE: Completing just step 1 of this task does not reward any points
	- Step 2 - Moving the characters
The next step in the ancient spell is to move each letter (from positions 0, 1, …, n­1) to the right N times. The number N is the position of the letter in the Latin alphabet regardless of its casing ('a' => 1, 'b' => 2, …, 'z' => 26). When a letter is moved to the right, if it is the last letter of the sequence, its next position is the first position in the sequence, just before all the letters.
The moving of letters starts from the sequence you reached in step 1. In the current example, that is "nmtuahFxgeir". First, the letter 'n' at position 0 is moved right 14 times: "nmtuahFxgeir" => "mtnuahFxgeir". Then the letter 't' at position 1 is moved right 20 times: "mtnuahFxgeir" => "mnuahFxgetir". Then the process continues:
"mnuahFxgetir" => "mnahFxgetiru" => "mnaFxgetiruh" => "mnaFxgetiruh" => "gmnaFxetiruh" => "gmnaFxtiruhe" => "gmnaiFxtruhe" => "gmrnaiFxtuhe" => "gmrnaiuFxthe" => "gmrnaihuFxte" => "gmrneaihuFxt"
Finally, you are left with "gmrneaihuFxt", which is the result.

## Counting (Counting)
	- Steve is imprisoned in Telerik Academy and punished to count to infinity.
You know how that goes. When you reach N and you start to forget what is the next number, what was the previous number and so on.
Write a program which prints ten numbers after a given N.

## Joro the Rabbit (JoroTheRabbit)
	- Joro can enter the terrain from every position, jump only on numbers larger than the one he is on, only in direction left-to-right and with the same step. Joro’s jumping steps range from 1 to the size of the terrain. Joro cannot jump on position that he already visited.

## Legs (Legs)
 - Skoki is also a magician. He once made an incantation which sent him to another universe. There chickens have 7 legs, bears have 2 and humans have 5.
 - Print the number of possible combinations on a single line

## Signal from Space (SignalFromSpace)
	- One day a signal from space was registered. Scientists managed to record the signal as a sequence of N symbols. It turned out that due to a technical difficulty some symbols have been repeated. Help the scientists by writing a program which removes consecutive repetitions of symbols, decoding the message.

## Numbers (Numbers)
	- Coki loves numbers. He also loves operations with them.

Since the regular arithmetic operations are too mainstream for him, he decided he wants a brand new calculator.

The calculator supports the following operations:

set NUMBER
Sets the current value to number
front-add DIGIT
Adds the digit DIGIT to the front (at the leftmost)
front-remove
Removes the first (the leftmost) digit
does nothing if there are no digits
back-add DIGIT
Adds the digit DIGIT to the back (at the rightmost)
back-remove
Removes the last (the rightmost) digit
does nothing if there are no digits
reverse
Reverses the digits of the current number
print
Prints the current number
prints an empty line if there are no digits
end
Stops the program
Sadly, Coki is not smart enough to implement the calculator. Pleeeeeease, help him, he is annoying!!

