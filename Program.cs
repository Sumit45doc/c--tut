﻿// // See https://aka.ms/new-console-template for more information


// // using System;

// namespace HelloWorld
// {
//     class Car
//     {
//         //         // field
//         public string color;
//         public int numberOfSeats;

//         public Car(string col, int nos){
//             color = col;
//             numberOfSeats = nos;
//         }

//         public void Start()
//         {
//             Console.WriteLine($"Car color is {color} and there are {numberOfSeats} seats in car");
//         }
//     }

//     class Program
//     {
//         // static void MyMethod(string name, int age){
//         //     Console.WriteLine($"My name is {name}. I am {age} years old ");
//         // }
//         // string color = "red";


//         static void Main(string[] args)
//         {
//             // MyMethod("Sumit Kumar Sharma", 22);
//             // int number1 = 10;
//             // int number2 = 10;

//             // variable types
//             // int, double, string, char, bool
//             // use const to avoid reassigning of variable

//             // double num = 10.2D;
//             // Console.WriteLine(number1 + number2);
//             // Console.WriteLine(num);
//             // float explicitNum = 10;
//             // int myInt = (int) explicitNum;
//             // Console.WriteLine(Convert.ToString(myInt));
//             // Console.WriteLine(Convert.ToDouble(myInt));
//             // Console.WriteLine(true);

//             // string userName = Console.ReadLine();
//             // Console.Write(userName);
//             // int age = Convert.ToInt32(Console.ReadLine());
//             // Console.Write(age + 10);


//             // operator is same as javascript

//             // math is same as js
//             // Console.WriteLine(Math.Abs(-10));
//             // Console.WriteLine(Math.Ceiling(6.3));
//             // Console.WriteLine(Math.Floor(6.3));
//             // int a = (int) Math.Pow(10, 2);
//             // Console.WriteLine(a);


//             // string

//             // NOTE: All the prebuild method are in pascal only variables are in camelCase
//             // string name = "sumit kumarsharma";
//             // Console.WriteLine(name.Length);
//             // Console.WriteLine("Name is upper case " + name.ToUpper());
//             // Console.WriteLine("Name in lower case " + name.ToLower());


//             // interpolation;
//             // string description = $"{name} is very talent person in the world";
//             // Console.WriteLine(description);

//             // indexof
//             // Console.WriteLine(name.IndexOf("e"));

//             // substring
//             // Console.WriteLine(name.Substring(name.IndexOf("a"), 2));

//             // foreach loop
//             // int[] arr = { 1, 3, 2 };
//             // Console.WriteLine($"{arr} is real array");
//             // foreach (int item in arr)
//             // {
//             //     Console.WriteLine($"{item} is the looping numbers!!");
//             // }
//             // Array.Sort(arr);
//             // Console.WriteLine($"{arr} is Sort array");
//             // foreach (int item in arr)
//             // {
//             //     Console.WriteLine($"{item} is the looping numbers!!");
//             // }

//             // max, min, sum of array using Systemlinq;
//             // Console.WriteLine(arr.Max());
//             // Console.WriteLine(arr.Min());
//             // Console.WriteLine(arr.Sum());

//             // overloading
//             // Console.WriteLine(PlusMethod(1, 1));
//             // Console.WriteLine(PlusMethod(1, 1.2));


//             // OOPs - Object Oriented Programming
//             // Program program = new Program();
//             // Console.WriteLine(program.color);

//             // constructor
//             // Car car = new Car("red", 5);
//             // Console.WriteLine(car.color);
//             // car.Start();

//             // access modifier
//             // public - access to all classes
//             // private - access within same class (by default)
//             // protect - access with same class and inheritance classes
//             // internal - access within assembly

//             // - private access modifier is used encapsulate data


//             // inheritence
//             // Console.WriteLine("What is your Cat name?");
//             // string animalName = Console.ReadLine();

//             // Console.WriteLine("What is your Cat LifeSpan?");
//             // int lifeSpan = Convert.ToInt32(Console.ReadLine());

//             // Cat cat = new Cat(4, animalName, lifeSpan);
//             // cat.Speak("meowing");
//             // cat.Information();
//             // cat.Run();

//             // interface execution
//             // TestMultipleInterface test = new TestMultipleInterface();
//             // test.firstMethod();
//             // test.secondMethod();


//             Level levelMeter = Level.medium;
//             Console.WriteLine(levelMeter);

//             int levelMeterInt = (int) Level.medium;
//             Console.WriteLine(levelMeterInt);


//         }





//         // static int PlusMethod(int x, int y){
//         //     return x + y;
//         // }
//         // static double PlusMethod(double x, double y){
//         //     Console.WriteLine("double");
//         //     return x + y;
//         // }



//     };

//     // Inheritence
//     //  abstract class Animal {
//     //     public int numberOfLegs;
//     //     protected string animalName;
//     //     public int lifeSpan;


//     //     public Animal(int nol, string an, int ls){
//     //         numberOfLegs = nol;
//     //         animalName = an;
//     //         lifeSpan = ls;
//     //     }

//     //     public abstract void Run(int speed);
//     //     public void Speak(string sound){
//     //         Console.WriteLine($"{animalName} speaks {sound}");
//     //     }

//     //     public void Information(){
//     //         Console.WriteLine($"{animalName} has {numberOfLegs} legs and can live upto {lifeSpan} yrs");
//     //     }

//     // }

//     // class Cat : Animal {
//     //     // private string animalName;
//     //     public Cat(int nol, string an, int ls) : base(nol, an, ls) {}

//     //     public override void Run(int speed = 10){
//     //         Console.WriteLine($"{animalName} run at speed: {speed}km/hr");
//     //     }
//     // }


//     // Interface - contain only abstract method and properties. No field.
//     // - Should be use instead of abstract class when there is no need of method with body and field.

//     // interface IFirstInterface {
//     //     public void firstMethod();
//     // }
//     // interface ISecondInterface {
//     //     public void secondMethod();
//     // }

//     // class TestMultipleInterface : IFirstInterface, ISecondInterface{
//     //     public void firstMethod(){
//     //         Console.WriteLine("First method!!");
//     //     }
//     //     public void secondMethod(){
//     //         Console.WriteLine("second method!!");
//     //     }
//     // }

//     // anum are constant with is unchangable and read-only
//     enum Level {
//         low,
//         medium,
//         high
//     }

// }









using System;

namespace AddNumber
{
    class Program
    {
        static double addToNumber(double x, double y)
        {
            return x + y;
        }

        static string ReverseString(string word)
        {
            char[] reverseWord = new char[word.Length];
            int j = 0;
            for (int i = (word.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(i);
                reverseWord[j] = word[i];
                j++;
            }

            return new string(reverseWord);
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Enter two number");
            // int x = Convert.ToInt32(Console.ReadLine());
            // int y = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(addToNumber(x, y));
            Console.WriteLine(ReverseString("Sumit"));
        }
    }
}
