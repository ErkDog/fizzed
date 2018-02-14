SuperFizzBuzz Coding Exercize


3rd party Nuget packages: NUnit

All unit tests are in the SuperFizzBuzz.UnitTests project.

There is only one main class called SuperFizzBuzz.cs that has all the code in it.

The two console apps are included in this solution for simplicity and to help keep everything together.
You can either set each project individually as the startup project and press F5, or go to each of their
respective bin folders and run the executables manually.

---

Instructions converted to text form (from Instructions.docx file):

Coding Exercise
This brief coding exercise will help us better understand how you think through problems and design solutions.
FizzBuzz – The Basics
Regular fizzbuzz output is typically described as “Write a program that prints the numbers from 1 to 100. But for multiples of 3, print “Fizz” instead of the number. For multiples of 5, print “Buzz”. For Multiples of 3 and 5, print “FizzBuzz”. Typical fizzbuzz output looks like:

1
2
Fizz
4
Buzz
…
88
89
FizzBuzz
91
….
…and so on. But that’s way too simple!


Super FizzBuzz - Requirements:

Develop a class library called SuperFizzBuzz that can do the following:

Can produce fizzbuzz output for a user-supplied range of numbers – e.g., from 2 to 35, or from 1 to 1,000,000,000, or from -1 to -35, etc.

Can produce output for a user supplied set of integers, even if they’re not sequential.

Can generate tokens other than “Fizz” and “Buzz” and can evaluate division by numbers other than 3 and 5. Maybe a user wants to test division by 4, 13, and 9, and output “Frog”, “Duck,” and “Chicken” for them (e.g., in this case, 52 would ouput “FrogDuck”, 36 would output “FrogChicken”, 468 would output “FrogDuckChicken”, etc.)

Write a console application, using your SuperFizzBuzz class, to solve the classic FizzBuzz problem as described above in “The Basics”.

Write a second console application demonstrating advanced usage of SuperFizzBuzz that performs the following:

Print the numbers from -12 through 145.

For multiples of 3, print “Fizz”

For Multiples of 7, print “Buzz”

For Multiples of 38, print “Bazz”

Print the appropriate combination of tokens for any number that matches more than one of those rules

In your solution, include tests for your SuperFizzBuzz class and any other related classes you develop.

Put all your work in a zip file and upload it with the results from your questionnaire to the link we provided you.

Note: Requirements 2 and 3 should not require command line parsing to complete. 

---

Enjoy,
-Eric

