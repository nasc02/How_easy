# How_easy
A challenge in C# from BeeCrowd made by TopCoder.

TopCoder decided to automate the process of assigning levels of difficulty to the problems. TopCoder developers concluded that the difficulty of the problem is related only to average length of the words in the problem statement. If the average length of the words of the statement is less than or equal to 3, the problem difficulty receives 250 points. If the average length of the words of the statement is 4 or 5, the problem difficulty receives 500 points. If the average length of utterance of words is greater than or equal to 6, the problem difficulty receives 1000 points.


Definitions:

Symbol: A set of characters linked by spaces from both sides, or at the beginning of the description of the problem, or even the end of the description of the problem.

Word: a symbol that contains only letters a-z or A-Z, and can be finished with a single point.

Word length: number of letters in a word (a point is not a letter).


Examples of symbols are words (quotes just to exemplify): "AB", "ab".

Example of symbols that are not words: "ab..", "a.b", ".ab", "a.b.", "a2b.", ".".


The average length of the words is given by the sum of the sizes of the utterance of words divided by the number of words, the division is made by integers. If the word count is zero, then the average length of the words is zero.


Your task is given the problem statement, compute its classification of difficulty of the problem, which can be 250, 500, or 1000.

Input
The entry contains several test cases. Each test case is composed of a line containing the statement of a problem, is a string containing between 1 and 50 characters ('A'-'Z','a'-'z','0'-'9', ' ', '.') inclusive. The end of input is determined by EOF.

Output
Compute the average length of words in the statement of the problem, and show the classification of the problem, for more details see the example below.

      Sample Input                                                  Sample output
      This is a problem statement                                   500
      523hi.                                                        250
      Implement a class H5 which contains some method.              500
       no9 . wor7ds he8re. hj..                                     250
