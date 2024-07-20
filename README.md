# Programming Challenges
This repository contains a series of solutions to problems in the [Programming Booklet](https://github.com/Blaadam/ProgrammingChallenges/blob/c347d6f858c77b75bc4a6f760eea8c48df1efb69/260930-coding-challenges-booklet.pdf)

<hr/>

## Challenges

### Challenge 1 - Factorial Finder
The Factorial of a positive integer, n, is defined as the product of the sequence n, n-1, n-2, ...1 and the factorial of zero, 0, is defined as 1. Solve this using both loops and recursion.

### Challenge 2 - Speed Tracker
Create a program that takes the time for a car to go past a speed camera, the time going past the next one and the distance between them to calculate the average speed for the car in mph. The cameras are one mile apart
#### Extensions:
1. Speed cameras know the timings of each car going past, through number plate recognition. Valid number plates are two letters, two numbers and three letters afterwards, for example, XX77 787. Produce a part of the program that checks whether a number plate matches the given pattern. Tell the user either way.
2. Create a program to create a file of details for vehicles exceeding the speed limit set for a section of road. You must create a suitable file with test data, including randomised number plates and times. You will then use the code you've already written to process this list to determine who is breaking the speed limit (70mph) and who has invalid number plates.

### Challenge 3 - Thief!
A thief has managed to find the four digits for an online PIN code but doesn't know the correct sequence needed to hack into the account. Design and write a program that displays all the possible combinations for any four numerical digits entered by the user. The program should avoid displaying the same combination more than once.
Submit a fully detailed Showcase for your program.

### Challenge 4 - Classification
A simple classification system asks a series of Yes/No questions to work out what type of animal is being looked at. E.g. Does it have 4 legs? Does it eat meat? Does it have stripes?
These systems can often be drawn using a "tree" structure. Carry out some simple research on classification trees, then write a program to help the user decide between the following:
> horse, cow, sheep, pig, dog, cat, lion, tiger, whale, dolphin, seal, penguin, ostrich, sparrow, spider, ant, bee, wasp, termite, octopus, squid

Is there a better way to do this than using 101 IF...ELSE...END IFs?
Develop your classification system for your area of interest: pop bands; pokemon; cars; footballers; teachers; diseases etc.

### Challenge 5 - Fruit Machine
Write a program to simulate a Fruit Machine that displays three symbols at random Cherry, Bell, Lemon, Orange, Star, and Skull.
The player starts with El credit, with each go costing 20p. If the Fruit Machine "rolls" two of the same symbol, the user wins 50p. The player wins El for three of the same and E5 for 3 Bells. The player loses El if two skulls are rolled and all of his/her money if three skulls are rolled. The player can choose to quit with the winnings after each roll or keep playing until there is no money left.

### Challenge 7 - Credit Card Validator
Takes in a credit card number from a common credit card vendor (Visa, MasterCard, American Express, Discoverer) and validates it to make sure that it is a valid number.
(look into how credit cards use a checksum).

### Challenge 8 - Arithmetic Test
A primary school teacher wants a computer program to test the basic arithmetic skills of her students. Generate random questions (2 numbers only) consisting of addition, subtraction, multiplication and division.
The system should ask the student's name and then ask ten questions. The program should feedback if the answers are correct or not, and then generate a final score at the end.
#### Extensions:
1. Extend your program so that it stores the results somewhere. The teacher has three classes, so you need to enable the program to distinguish between them.
2. The teacher wants to be able to log student performance in these tests. The teacher would like the program to store the last three scores for each student and to be
able to output the results in alphabetical order with the student's highest score first out of the three.

### Challenge 9 - Happy Numbers
A happy number is defined by the following process:
Starting with any positive integer, replace the number with the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers, while those that do not end in 1 are unhappy numbers. 
Display an example of your output here. Find the first eight happy numbers.

### Challenge 11 - Regex Query Tool
This is a tool that allows the user to enter a text string and then in a separate text box enter a regex pattern. It will run the regular expression against the string and return any matches or flag errors in the regular expression.

### Challange 14 - Events Calendar
Create a menu-driven program that allows the user to add or delete events from a list of dates and timings, just like a calendar. The program should warn you if any of the events overlap when entering them.
#### Extensions:
1. Make it so that none of the events are hard-coded into the program
