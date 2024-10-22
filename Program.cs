
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value
        NPZ(-1);
        NPZ(0);
        NPZ(1);
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);
        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);
        DivisibleBy5(5);
        DivisibleBy5(6);
        EvanOrOdd(2);
        EvanOrOdd(3);
        VowelOrConsonant('e');
        VowelOrConsonant('E');
        VowelOrConsonant('s');
        VowelOrConsonant('S');
        DayOfWeek(0);
        DayOfWeek(3);
        DayOfWeek(6);
        // Test your functions by calling them below:
        // CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        // CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        // CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    public static void NPZ(int x)
    {
    // Define your functions below:
            if (x == 0){
                Console.WriteLine("Your number is zero");
            } else if (x < 0){
                Console.WriteLine("Your number is negative");
            }else{
                Console.WriteLine("Your number is positive");
            }
    }

    public static void FindMinimum(int min1, int min2, int min3)
    {
            if (min1 < min2 && min1 < min3){
                Console.WriteLine("The minimum value is " + min1);
            } else if (min2 < min1 && min2 < min3){
                Console.WriteLine("The minimum value is " + min2);
            }else{
                Console.WriteLine("The minimum value is " + min3);
            }
    }

public static void FindMaximum(int min1, int min2, int min3)
    {
        if (min1 > min2 && min1 > min3){
            Console.WriteLine("The minimum value is " + min1);
        } else if (min2 > min1 && min2 > min3){
            Console.WriteLine("The minimum value is " + min2);
        }else{
            Console.WriteLine("The minimum value is " + min3);
        }
    }

public static void DivisibleBy5(int x)
    {
        if (x%5 == 0){
            Console.WriteLine("Your number is divisible by 5");
        }else{
            Console.WriteLine("Your number is not divisible by 5");
        }
    }

public static void EvanOrOdd(int x)
    {
        if (x%2 == 0){
            Console.WriteLine("Your number is evan");
        }else{
            Console.WriteLine("Your number is odd");
        }
    }

public static void VowelOrConsonant(char letter)
    {
        switch (letter)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                Console.WriteLine("vowel");
                break;
            default:
                Console.WriteLine("not a vowel");
                break;
        }
    }

public static void DayOfWeek(int x)
    {
        if (x == 0){
            Console.WriteLine("It is sunday");
        }else if (x == 1){
            Console.WriteLine("It is monday");
        }else if (x == 2){
            Console.WriteLine("It is tuesday");
        }else if (x == 3){
            Console.WriteLine("It is wednesday");
        }else if (x == 4){
            Console.WriteLine("It is thursday");
        }else if (x == 5){
            Console.WriteLine("It is friday");
        }else if (x == 6){
            Console.WriteLine("It is saturday");
        }else{
            Console.WriteLine("That is not a day of the week");
        }
    }
}