﻿//using PracticeCode.MyNamespaceOne;
//using PracticeCode.MyNamespaceTwo;

//// Chapter One

//// 1.T13 Decimal vs double vs float in finances
//var b = 6;
//decimal flag1 = (decimal)10.0 / b;
//double flag2 = 10.0 / b;
//float flag3 = (float)10.0 / b;

//Console.WriteLine(flag1);
//Console.WriteLine(flag2);
//Console.WriteLine(flag3);

//var flag5 = false;
//flag3 = flag3 + 3;
//flag1 = flag1 + 6;

////1.T14 conditional operator is right-associative (evaluated from right to left)
//var c = b == 6 ? (int)flag3 : flag5 ? (int)flag3 : (int)flag1;
//Console.WriteLine(c);
//var c1 = b > 6 ? (int)flag3 : (flag5 ? (int)flag3 : (int)flag1);
//Console.WriteLine(c1);

//// 1.T16 While and do-While loop
//Console.WriteLine("Illustration: do-while loop");
//int j = 1;
//do
//{
//    Console.WriteLine($"Inside loop: j is now {j}");
//    j++;
//} while (j < 1);
//Console.WriteLine($"Outside loop: j's value is {j}");

//// 1.T17 What is a foreach loop?
//string text = "hello";
//Console.WriteLine($"The string \"hello\" contains the following characters: ");
//foreach (var x in text) Console.WriteLine(x);

//// For vs Foreach loop
//List<int> list = new List<int> { 1, 2, 3, 4, 5 };

//Console.WriteLine("Executing the 'foreach' loop:");
//foreach (var myItem in list)
//{
//    Console.WriteLine("\t" + myItem);
//}

//Console.WriteLine("Executing the 'for' loop:");
//for (int myItem2 = 0; myItem2 < list.Count; myItem2++)
//{
//    Console.WriteLine("\t" + list[myItem2]);
//}


//// 1.P1 Same names for the Class in the different namespaces
//PracticeCode.MyNamespaceOne.MyClassOne myClassOne = new PracticeCode.MyNamespaceOne.MyClassOne(name: "Celebrate small accomplishments!", age: 37);
//PracticeCode.MyNamespaceTwo.MyClassOne myClassTwo = new PracticeCode.MyNamespaceTwo.MyClassOne(age: 27, name: "Get over disappointments quickly!");
//PracticeCode.MyNamespaceOne.MyClassOne.ShowInfo(myClassOne.Name, myClassOne.Age);
//PracticeCode.MyNamespaceTwo.MyClassOne.ShowInfo(myClassTwo.Name, myClassTwo.Age);

////1.P2 prefix and postfix increment
//int flag7 = 1, flag8 = 1;
//Console.WriteLine($"Currently, the flag7 is {flag7++}");
//Console.WriteLine($"Currently, the flag8 is {++flag8}");

////1.P3 Max and Min value of int and postfix increment
//Console.WriteLine($"The max value of an int is: {int.MaxValue}");
//Console.WriteLine($"The min value of an int is: {int.MinValue}");
//int flag9 = int.MaxValue;
//Console.WriteLine($"Currently, the flag is {flag9}");

////flag9++;
////Console.WriteLine($"Post increment, the flag is: {flag9}"); // Overflow no exception by default can be enabled globally

////Adding Check in place
////int flag10 = int.MaxValue;
////Console.WriteLine($"Currenlty, the flag is {flag10}");
////checked
////{
////    flag10++;                       // OverflowException
////    Console.WriteLine($"Post increment, the flag is: {flag10}");
////}

////1.P5
//byte flag11 = 1;
//byte flag12 = 2;
//byte flag13 = (byte)(flag11 + flag12); // explicit conversion
//Console.WriteLine(flag13);

//// 1.P6
//Console.WriteLine($"5.25/0.0={5.25 / 0.0}");
//Console.WriteLine($"1.27/-0={1.27 / -0}");
//Console.WriteLine($"0/-2.5={0 / -2.5}");
//Console.WriteLine($"0.0/0.0={0.0 / 0.0}");
//Console.WriteLine($"0/5={0 / 5}");
//Console.WriteLine($"-0.0={-0.0}");
//Console.WriteLine($"-0.0f={-0.0f}");
//Console.WriteLine($"double.PositiveInfinity={double.PositiveInfinity}");
//Console.WriteLine($"-5*PositiveInfinity={-5 * double.PositiveInfinity}");
//Console.WriteLine($"float.PositiveInfinity={float.PositiveInfinity}");

////1.P9 Selection Statements
//Console.WriteLine("Use of an if-else chain.");
//int input = 77;
//if (input % 2 == 0)
//{
//    Console.WriteLine($"{input} is an even number");
//}
//else
//{
//    Console.WriteLine($"{input} is an odd number");
//}

////1.P10 Example of Switch statement and careful use of >= in situations when default and other case could be the same, default always evaluates last 
//CheckNumber(25.5);
//CheckNumber(125.5);
//CheckNumber(10.000);
//void CheckNumber(double number)
//{
//    switch (number)
//    {
//        case double.NaN:
//            Console.WriteLine($"{number} is not a number");
//            break;
//        case < 10.0:
//            Console.WriteLine($"{number} is less than 10.0");
//            break;
//        case > 10.0:
//            Console.WriteLine($"{number} is greater than 10.0");
//            break;
//        default:
//            Console.WriteLine($"{number} is equal to 10.0");
//            break;
//    }
//}

//// 1.P11 Example of guard in switch statement
//CheckNumbers(5, 23);
//CheckNumbers(15, 5 + 7);
//CheckNumbers(-7, 239);
//void CheckNumbers(int num1, int num2)
//{
//    switch (num1, num2)
//    {
//        case ( > 0, > 0) when num1 != num2:
//            Console.WriteLine($"{num1} and {num2} are the same positive numbers");
//            break;
//        default:
//            Console.WriteLine($"At least one of {num1} or {num2} is 0 or negative");
//            break;
//    }
//}

//// 1.P13 multiple case statements
//ShowNumber(5);
//ShowNumber(125);
//ShowNumber(-2);

//void ShowNumber(int num)
//{
//    switch (num)
//    {
//        case < 5:
//        case < 50:
//        case < 100:
//            Console.WriteLine($"{num} is less than 100.");
//            break;
//        default:
//            Console.WriteLine($"{num} is greater than or equal to 100.");
//            break;

//    }
//}

//// Ternary Operator
//// 1.P14
//int flag20 = 7;
//string output = flag20 < 3 ? "less than 3" : "greater than 3";
//Console.WriteLine($"{flag20} is {output}");

//// Iteration Statementss
//// 1.P15
//int i = 0;
//while (i < 3)
//{
//    Console.WriteLine($"The current value: {i}");
//    i++;
//}

//for (int myJ = 0; myJ < 3; myJ++)
//{
//    Console.WriteLine($"The current value: {myJ}");
//}

//// 1.P18 Increment by 3
//for (int k = 0; k < 8; k += 3)
//{
//    Console.WriteLine($"The curent value: {k}");
//}

//// CAUTION: Infinite loop, not bool or null is not allowed in while() statement

//// goto statement
//int flag30 = 1;
//while (flag30 != 3)
//{
//    Console.WriteLine($"flag is now {flag30}");
//    flag30++;
//    if (flag30 == 2)
//        goto level_1;
//}
//flag30 = 50;
//Console.WriteLine($"flag is now {flag30}");

//level_1:
//flag30 = 100;
//Console.WriteLine($"flag is now {flag30}");



//// Jump Statements
//// 1.P25 Break vs Continue

//Console.WriteLine("Illustration: break vs continue");
//int myInt10 = 1;
//while (myInt10 != 5)
//{
//    Console.WriteLine($"Now, myInt10 = {myInt10}");
//    myInt10++;
//    if (myInt10 == 4)
//    {
//        Console.WriteLine("Entered inside if loop");
//        //break;
//        continue;
//    }
//}

//// Use of the var Keyword
//// 1.P26
//var myInt20 = 25;
//var myInt21 = 25.5f;
//var myInt22 = 25.5;
//var myInt23 = 25.5M;
//var myChar20 = 'c';
//var myString20 = "Alternate between difficult and simple concepts!";

//List<object> myList20 = new List<object> { myInt20, myInt21, myInt22, myInt23, myChar20, myString20 };
//foreach (var item in myList20)
//{
//    Console.Write(item.GetType() + ", ");
//}

//// Chapter Two - String and Arrays

////2T1
//string name = "Ruslan";

//double balance = 250.56;


//// Using formatting
//Console.WriteLine("Hi {0}, you have ${1} left.", name, balance);

//// Using String.Format
//string str = String.Format("Hi {0}, you have ${1} left.", name, balance);
//Console.WriteLine(str);

//// Using string concatenation
//Console.WriteLine("Hi " + name + " ,you have $" + balance + " left.");

//// Using string interpolation
//Console.WriteLine($"Hi {name}, you have ${balance} left.");

//// 2.T5 String.Join() and String.Concat()
//string[] animalStore = { "Tigers", "Lions", "Elephants" };
//string animals = string.Concat(animalStore);
//Console.WriteLine($"The circus has {animals}");

//animals = string.Join(", ", animalStore);
//Console.WriteLine($"the circus has {animals}");

//Console.WriteLine("\nEnter [A] to continue...");
//Console.Read();

//List<object> myList = new List<object> { 3, "Ruslan", false };
//string myListOne = string.Join(", ", myList);
//Console.WriteLine(myListOne);

//foreach (object o in myList)
//    Console.Write($"{o}, ");

//Console.WriteLine("\nPress [enter] to continue...");
//Console.Read();

//// 2.T6
//string str1 = "Hello reader!";
//string str2 = "Hello reader!";
//Console.WriteLine(object.ReferenceEquals(str1, str2)); // True

//string str3 = "reder!";
//string str4 = "Hello" + str3;
//Console.WriteLine(object.ReferenceEquals(str1, str2)); // True
//Console.WriteLine(object.ReferenceEquals(str1, str4)); // False


//// Arrays
//// 2.T8
//int[] myNumbers20 = new int[3];
//myNumbers20[0] = 5;
//myNumbers20[1] = 12;
//myNumbers20[2] = 7;

//for (int myCounter = 0; myCounter < 3; myCounter++)
//    Console.WriteLine(myNumbers20[myCounter]);

//// Using Length
//for (int myCounterI = 0; myCounterI < myNumbers20.Length; myCounterI++)
//    Console.WriteLine(myNumbers20[myCounterI]);

//// Alternative ways to create an Array
//int[] myNumbers201 = new int[] { 5, 12, 7 };
//int[] myNumbers202 = { 5, 12, 7 };
//var myNumbers2023 = new int[] { 5, 12, 7 };

//// 2.T10 Rectangular array
//int[,] rectArray = { { 10, 20, 30 },
//                     { 40, 50, 60 }, };

//Console.WriteLine("The rectangular array is as follows:");
//for (int myCounter_i = 0; myCounter_i < 2; myCounter_i++)
//{
//    for (int myCounter_j = 0; myCounter_j < 3; myCounter_j++)
//    {
//        Console.WriteLine(rectArray[myCounter_i, myCounter_j] + "\t");
//    }
//    Console.WriteLine();
//}

////2.T11 Jagged Array
//int[][] jaggedArray = new int[][]
//{
//    new int []{0,1 },
//    new int []{2,3,4},
//};

//// using 'for' loop
//Console.WriteLine("The jagged array is as follow:");
//for (int i = 0; i < jaggedArray.Length; i++)
//{
//    for (int j = 0; j < jaggedArray[i].Length; j++)
//    {
//        Console.Write(jaggedArray[i][j]+"\t");
//    }
//    Console.WriteLine();
//}

//// using 'foreach' loop 
//foreach (int[] rows in jaggedArray)
//{
//    foreach (int item in rows)
//    {
//        Console.Write(item + "\t");
//    }
//    Console.WriteLine();
//}

//// Chapter Two - Programming Skills
//// String Fundamentals 
//// 2.P1
//string text1 = string.Concat("Hello", "World!");
//Console.WriteLine("The text is:"+text1);
//Console.WriteLine($"The text is:{text1}");

//// 2.P2
//string text2 = "test";
//Console.Write($"The length of 'text2' is {text2.Length}");

//// Using for loop
//for (int i = 0; i < text2.Length; i++)
//{
//    Console.Write($"\nThe text2 [{i}] contains: {text2[i]}"); // Counter does not repeate same letter index
//}

////Using foreach loop
//Console.WriteLine("\nUsing foreach loop:");
//foreach (char c in text2)
//    Console.Write($"\nThe text2 [{text2.IndexOf(c)}] contains: {c}"); //Note same letters have same index

//// 2.P3 $@ can be used to string iterpolate and not use escape character '\' for file paths example
//string text3 = @"Do not expect immediate results! Celebrate ""small"" accomplishments!";
//Console.WriteLine(text3);
//Console.WriteLine(text3.ToUpper());
//Console.WriteLine(text3.ToLower());

//// 2.P4 How can you print a URL such as http//google.com?
//// User of verbatim identifier (@)
//string url = @"https:\\google.com";
//Console.WriteLine(url);

//// 2.P5 Trim() method
//string text5 = " Retrieve from memory! ";
//Console.WriteLine($"Original line: '{text5}'");
//Console.WriteLine($"Trimmed line: '{text5.Trim()}'");

//// 2.P6 
//char[] trimChars = { 'A', 'b', '!', '-' };
//string text6 = "Adopt Growth Mindset - belief in the ability to learn and grow!";
//Console.WriteLine($"Original line: '{text6}'");
//Console.WriteLine($"Trimmed line: '{text6.Trim(trimChars)}");
//Console.WriteLine($"New trimmed line: '{text6.TrimEnd(trimChars)}'");

//// 2.P7
//string emptyString = string.Empty;
//string? nullString = null;
//Console.WriteLine("Length of the emptyString is {0}", emptyString.Length);
////Console.WriteLine("Length of the nullSTring is {0}", nullString.Length);    // NullReferenceException

//// IsNullOrEmpty()
//Console.WriteLine(string.IsNullOrEmpty(emptyString));    // True
//Console.WriteLine(string.IsNullOrEmpty(nullString));     // True

//// 2.P8
//string text8 = "Reviewing the concepts of C#.";
//string welcome1 = text8.PadLeft(text8.Length + 2, '*');
//string welcome2 = welcome1.PadRight(welcome1.Length + 3, '#');
//Console.WriteLine($"Original line:'{text8}'");
//Console.WriteLine($"Updated line:'{welcome2}");

//// 2.P9
//Console.WriteLine("\n---2.P9---");
//Console.WriteLine("Enter the string:");
//string? inputStr = Console.ReadLine();
//string? reverseStr = ReverseString(inputStr);
//Validate(inputStr, reverseStr);

//// Reversing a string
//static string ReverseString(string str)
//{
//    char[] tempArray = str.ToCharArray();
//    // Reverses the sequence of the elements
//    Array.Reverse(tempArray);
//    // Change the reversed array to a string
//    string reverseStr = new(tempArray);
//    // Return this string
//    return reverseStr;
//}

//// Check for the palindrome string

//static void Validate(string str1, string str2)
//{
//    if (str1.Equals(str2))
//    {
//        Console.WriteLine($"The string: '{str1}' is a palindrome string");
//    }
//    else
//    {
//        Console.WriteLine($"The string '{str1}' is a not palindrome string");
//    }
//}


//// 2.P10 String vs StringBuilder
//using System.Runtime.Serialization;
//using System.Text;

//Console.WriteLine("***String vs StringBuilder***");
//ObjectIDGenerator iDGenerator = new();
//bool firstTime = false;

//Console.WriteLine("\nWorking with a String instance");
//string text = "Hello";
//Console.WriteLine($"The instance id of {text} is {iDGenerator.GetId(text, out firstTime)}");

//// Creates a new instance ID
//text += ", John!";
//Console.WriteLine($"The instance id of {text} is {iDGenerator.GetId(text, out firstTime)}");

//Console.WriteLine("\nWorking with a StringBuilder instance");
//StringBuilder text2 = new("Hello, John!");
//Console.WriteLine($"The instance id of {text2} is {iDGenerator.GetId(text2, out firstTime)}");

//// The following does not create a new instance ID
//text2 = text2.Replace("Hello", "Welcome");
//Console.WriteLine($"The instance id of {text2} is {iDGenerator.GetId(text2, out firstTime)}");

//// 2.P11 
//string strInput = "12";
//Console.WriteLine(strInput+5);
//int intInput =int.Parse(strInput);
//Console.WriteLine(intInput+5);

//// 2.P12
//if(int.TryParse("123", out int input2))
//{
//    Console.WriteLine("Successfully parsed the string");
//    Console.WriteLine($"The result is: {input2+5}");
//}
//else
//{
//    Console.WriteLine("Couldn't parse the given string.");
//}

//// 2.P13
//string hello = "Welcome reader!";
//int firstIndex = hello.IndexOf('e');
//int secondIndex = hello.IndexOf('e', firstIndex + 1);
//int thirdIndex = hello.IndexOf('e', secondIndex + 1);
//Console.WriteLine($"The given string: {hello}");
//Console.WriteLine($"The 1st index of 'e' is at location: {firstIndex}");
//Console.WriteLine($"The 2nd index of 'e' is at location: {secondIndex}");
//Console.WriteLine($"The 3rd index of 'e' is at location: {thirdIndex}");

//// Using For Loop
//int occuranceCount = 0;
//int index = -1;
//for (int i = 0; i < hello.Length && occuranceCount < 3; i++)
//{
//    index = hello.IndexOf('e', index + 1);
//    if (index != -1)
//    {
//        occuranceCount++;
//        Console.WriteLine($"The {occuranceCount} index of 'e' is at location {index}");
//    }
//    else
//    {
//        break;
//    }
//}

// Array Fundamentals
// 2.P14
int row = 2, column = 3;
int[,] elements = new int[row, column];
elements[0, 0] = 2;
elements[0, 2] = -16;
elements[1, 0] = 6;
elements[1, 2] = 19;

Console.WriteLine("The rectangular array is a as follows:");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(elements[i,j]+"\t");
    }
    Console.WriteLine();
}























































