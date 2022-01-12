//https://coderbyte.com/editor/First%20Factorial:Csharp?utm_campaign=NewHomepage
/*First Factorial
Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it. 
For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24. 
For the test cases, the range will be between 1 and 18 and the input will always be an integer.
*/
using System;

class MainClass {

  public static int FirstFactorial(int num) {

    // code goes here  
        for (int i = num - 1; i > 0; i--) {
        num = num*i;
    }
    return num;

  }

  static void Main() {  
    // keep this function call here
    // Console.WriteLine(FirstFactorial(Console.ReadLine()));
    Console.WriteLine("Enter a number from 1-10.");
    int number = Console.ReadLine();
    FirstFactorial(number);
    Console.WriteLine(number);
    } 
//Code doesn't work in VS Code console. dotnet build returns error 
//(19,18): error CS0029: Cannot implicitly convert type 'string' to 'int'
}