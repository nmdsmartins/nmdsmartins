
# Word ladder test
Having been given a start and an end word, I need to build a chain of words from the start word by changing one character between words until it reaches the end word based on a supplied word dictionary file. 

## First step to solve the problem
To be able to solve the problem by writing down an algorithm, I must first try to solve the problem by myself. So I have taken a subset of words, paste them into Notepad++ and then tried to figure out a way to go from the start to the end word.

I immediately thought about using regular expressions to iterate over every word's characters by replacing them with the *any character pattern* and then writing down every word found by that expression.

For example: 
having the word **cast**, perform the following:

 1. look for words in the dictionary with the pattern **.ast**, then **c.st**, then **ca.t** and then **cas.**
 2. Write down all the found words on every pattern
 3. Repeat the process for every word found and so on until the target word is found

There are 2 things we need to worry about. The first one is to avoid finding already found words so we need to discard those as we go on. The second one is to somehow keep the connection between words so that when we find the target word we can navigate from that word back to the start word.
    

Nuget packages:
 - [https://github.com/cajuncoding/CommandLineArgsHelper](https://github.com/cajuncoding/CommandLineArgsHelper)
