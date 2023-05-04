// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What's your name?");

//variable declaration and assignment
string name = Console.ReadLine();

//string concatenation
Console.WriteLine("Hello " + name + "!");

Console.WriteLine("How about your age?");

string ageInput = Console.ReadLine();
// int.TryParse does the same job too, without throwing exception
int age = int.Parse(ageInput);

if ( age < 30 ) {
    Console.WriteLine("you young'un!");
}

Console.WriteLine("Type something!");
string input = Console.ReadLine();
Console.WriteLine("Your first character is: " + input[0]);

for(int i = 0; i < input.Length; i++) {
    Console.WriteLine("Your " + i + "th character is: " + input[i]);
}

while(true) {
    Console.WriteLine("This is while loop");
    break;
}

do {
    Console.WriteLine("This will execute at least once");
} while(false);

string[] hobbies = new string[6];
for( int i = 0; i < hobbies.Length; i++ ) {
    Console.WriteLine("What's your hobby?");
    hobbies[i] = Console.ReadLine();
}

foreach(string hby in hobbies) {
    Console.WriteLine(hby);
}

// FizzBuzz Problem
// 1
// 2
// Fizz
// 4
// Buzz
// Fizz
// 7
// 8
// Fizz
// Buzz
// 11
// Fizz
// 13
// 14
// FizzBuzz

// given a number N, iterate from 1 to N, with the following condition
// if number n is divisible by 3, print "Fizz"
// if number n is divisible by 5, print "Buzz"
// if n is divisible by 3 and 5, print "FizzBuzz"
// if none of that is true, then print the number 
Console.WriteLine("Fizzbuzz");
Console.WriteLine("Enter a number for the upper bound: ");
// Ask the user for the upper bound number
string upperBoundInput = Console.ReadLine();
// Parse the string to integer
int upperBound = int.Parse(upperBoundInput);

Fizzbuzz(upperBound);

//methods
void Fizzbuzz(int n) {
    for(int i = 1; i <= n; i++) {
        if(i % 3 == 0 && i % 5 == 0) {
            Console.WriteLine("FizzBuzz");
        }
        else if(i % 5 == 0) {
            Console.WriteLine("Buzz");
        }
        else if(i % 3 == 0) {
            Console.WriteLine("Fizz");
        }
        else {
            Console.WriteLine(i);
        }
    }
}