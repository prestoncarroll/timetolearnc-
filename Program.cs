﻿using System;
//add } at bottom to resume
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------------------------------------METHODS
            SayHi("mike", 22);
            SayHi("tim", 14);
            SayHi("john", 55);
            Console.ReadLine();
        }


        static void SayHi(string name , int age)
        {
            Console.WriteLine("hello " + name + " you are " + age);



        }


        //------------------------------------------------------------ARRAYS
        // int[] luckyNumbers = { 4, 8, 15, 77, 99, 5 };
        // string[] names = { "jane", "julia", "james" };

        // string[] friends = new string[5];
        // friends[0] = "tom";
        // friends[1] = "john";
        // friends[2] = "bill";
        // friends[3] = "woop";
        // friends[4] = "coolio";


        // // returns the whole array to the console
        // Console.WriteLine("[{0}]", string.Join(", ", friends));

        // Console.WriteLine(string.Join("\n", friends));

        // luckyNumbers[1] = 900;

        // Console.WriteLine(luckyNumbers[2] + names[1]); //15julia

        // Console.WriteLine(luckyNumbers.Length);//6
        // Console.WriteLine(luckyNumbers[2]); //15

        // Console.WriteLine(luckyNumbers[2] + luckyNumbers[3]);//92


        // Console.ReadLine();




        //---------------------------------------------------------------
        // string color, pluralNoun, celebrity;

        // Console.Write("enter a color: ");
        // color = Console.ReadLine();

        // Console.Write("enter a plural noun ");
        // pluralNoun = Console.ReadLine();

        // Console.Write("enter a celebrity: ");
        // celebrity = Console.ReadLine();


        // Console.WriteLine("roses are " + color);
        // Console.WriteLine(pluralNoun + " are blue");
        // Console.WriteLine("i love " + celebrity);





        // -------------------------------------------------------------
        // Console.Write("enter a number:");

        // double num1 = Convert.ToDouble(Console.ReadLine());

        // Console.Write("enter a number:");

        // double num2 = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine(num1 + num2);


        // Console.ReadLine();



        //--------------------------converting string to a number
        // int num = Convert.ToInt32("45");
        // Console.WriteLine(num + 6);


        // Console.ReadLine();






        // ------------------------------------------------------USER INPUT
        // Console.Write("Enter your name: ");
        // string name = Console.ReadLine();
        // Console.Write("Enter your age: ");
        // string age = Console.ReadLine();

        // Console.WriteLine("hello " + name + " you are " + age);






        // Console.ReadLine();







        //---------------------------------------------------------------
        // string phrase = "my academy";
        // int num = 23;
        // num++;



        // Console.WriteLine(num);
        // Console.WriteLine(phrase.Length);
        // Console.WriteLine(phrase.ToUpper());
        // Console.WriteLine(phrase.Contains("academy")); //outputs true
        // Console.WriteLine(phrase[0]); //outputs m
        // Console.WriteLine(phrase.IndexOf("academy")); //outputs 3

        // Console.ReadLine();

        //----------------------------------DECLARING VARIABLES
        // String name = "john";
        // int age = 23;
        // Console.WriteLine(name + " is " + age);



        //----------------------------------------------------------------
        // string name = "john";
        // char grade = 'A'; //ONLY ONE CHARACTER
        // int age = 23;
        // double gpa = 3.3; //DECIMAL
        // bool isMale = true;

        // if (isMale == true)
        // {
        //     Console.WriteLine(name + " got an " + grade + " in the class." + " he is " + age + " and his gpa is " + gpa );
        // }


        // Console.ReadLine();





    }
}
