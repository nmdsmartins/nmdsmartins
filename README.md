
# Word ladder test
I have been presented with the challenge of coming up with a solution for the problem that starts from being given a start and an end word to build a ladder of words from the start word by changing one character between words until it reaches the end word based on a supplied word dictionary file. 

## First step to solve the problem
To be able to solve the problem by writing down an algorithm, I must first try to solve the problem by myself. So I have taken a subset of words, paste them into Notepad++ and then tried to figure out a way to go from the start to the end word.

I immediately thought about using regular expressions to iterate over every found word's characters by replacing them with the *any character pattern* and then writing down every word found by that expression.

For example: 
having the word **cast**, perform the following:

 1. look for words in the dictionary with the pattern **.ast**, then **c.st**, then **ca.t** and then **cas.**
 2. Write down all the found words on every iteration
 3. Repeat the process for every word found and so on until the target word is found

There are 2 things we need to worry about. The first one is to avoid finding already found words so we need to ignore those as we go on and the second one is to somehow keep the connection between words so that when we find the target word we can navigate back to the start word.

## The algorithm

 - To perform the finding of the end or target word without knowing how many words we are going to find a long the way, we need to somehow iterate over a growing loop to avoid going into a recursive algorithm. We need to iterate over the length of the array of words that are being found as we move forward.
 - Next step is to iterate over the current word using regular expressions and look for every word in the dictionary except the ones that have already been found, matching the expression and finally iterate over every found word, add it to the found/ignored words. Do this until the end or target word is found.
 - To be able to go back to the start word, I have created a linked list structure called **Word** that contains the current word and a link to its parent, so that when I find the target word, I can easily navigate back to the start word.

## Code techniques and patterns

 - Coding standards are important and are present such as keeping coherence which makes code reading more easy to everybody, like for example using **_*variable-name*** for private variables, Pascal case for the name of the classes as well as using an **I**Interface-name for interfaces.
 -  Use of C# 8.0 such as initializing the **using statement** with a semi-comma in the end.
 - I have also used a Nuget package just to help me handle the command line parameters (*link available bellow*). 
 - [SOLID](https://en.wikipedia.org/wiki/SOLID) principles can be verified within the code and some are marked as regions with the it's abbreviation.
 - [TDD](https://en.wikipedia.org/wiki/Test-driven_development#:~:text=Test-driven%20development%20%28TDD%29,software%20against%20all%20test%20cases.) can also be verified in the separate project for tests.

## Running the program
To run the program using the command line, set the parameters like for example:

    wordladder.exe -s:else -e:safe -d:"words-english.txt" -o:"c:\temp\outputfile.txt"
  
Used Nuget packages:
 - Command line helper: [https://github.com/cajuncoding/CommandLineArgsHelper](https://github.com/cajuncoding/CommandLineArgsHelper)
