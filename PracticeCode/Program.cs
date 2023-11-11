//using PracticeCode.MyNamespaceOne;
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

//// Array Fundamentals
//// 2.P14
//int row = 2, column = 3;
//int[,] elements = new int[row, column];
//elements[0, 0] = 2;
//elements[0, 1] = 5;
//elements[0, 2] = -16;
//elements[1, 0] = 6;
//elements[1, 2] = 19;

//Console.WriteLine("The rectangular array is a as follows:");
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < column; j++)
//    {
//        Console.Write(elements[i,j]+"\t");
//    }
//    Console.WriteLine();
//}

//// 2.P15 & 2.P16
//int[][] jaggedArray = new int[3][];
//jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
//jaggedArray[1] = new int[6] { 5, 6, 7, 8, 9, 10 };
//jaggedArray[2] = new int[2] { 11, 12 };
//Console.WriteLine($"Element at [0][1]={jaggedArray[0][1]}"); //2
//Console.WriteLine($"Element at [1][3]={jaggedArray[1][3]}"); //8
//Console.WriteLine($"Element at [2][1]={jaggedArray[2][1]}"); //12
//Console.WriteLine($"The last element's index of jaggedArray[1] is {jaggedArray[1].GetUpperBound(0)}"); //5
//Console.WriteLine($"The first element's index of jaggedArray[2] is {jaggedArray[2].GetLowerBound(0)}");//0
//// 2.P16
////Console.WriteLine($"The jaggedArray[2].GetUpperBound(1) is {jaggedArray[2].GetUpperBound(1)}"); // runtime error 

//// 2.P17
//int[,] recArray = new int[3, 4];
//Console.WriteLine($"The rectArray.Length = {recArray.Length}"); //12

//// 2.P18
//int[][] jaggedArray3 = new int[3][];
//jaggedArray3[0] = new int[4] { 1, 2, 3, 4 };
//jaggedArray3[1] = new int[5] { 5, 6, 7, 8, 9 };
//jaggedArray3[2] = new int[2] { -2, 7 };
//Console.WriteLine($"The jaggedArray3.Length = {jaggedArray3.Length}"); //3
//Console.WriteLine($"The jaggedArray3[1].Length = {jaggedArray3[1].Length}");//5

//// 2.P19
//double[] rates = new double[4] { 2.2, 3.3, 1.1, 5.5 };
//Console.Write("The original array:");
//Display(rates);
//Array.Sort(rates);
//Console.Write("\nThe sorted array:");
//Display(rates);
//Console.Write("\nThe reversed array:");
//Array.Reverse(rates);
//Display(rates);
//static void Display(Array rates)
//{
//    foreach (var rate in rates)
//    {
//        Console.Write(rate+"\t;");
//    }
//}

//// 2.P20
//int[] scores = new int[] { 1, 2, 3, 4, 5 };
//scores.SetValue(50, 4);
//Console.WriteLine($"scores[3]={scores[3]}");
//Console.WriteLine($"scores[4]={scores[4]}");

//// Chapter 3 Enumerations and Structure Types
////3.T1
//Console.WriteLine((int)ErrorTypes.CodeError);
//int errorType = (int)ErrorTypes.DeviceError;
//Console.WriteLine(errorType);
//enum ErrorTypes
//{
//    NetworkError,
//    CodeError,
//    DeviceError,
//};

////3.T5 Casting enumeration conversions
//Measurement position = (Measurement)Alignment.TowardRight;
//Console.WriteLine($"The current position is {position}");
//Console.WriteLine($"Its integral value is {(int)position}");
//public enum Measurement : int
//{
//    Left,
//    Middle,
//    Right
//}
//public enum Alignment : uint
//{
//    TowardLeft = 0,
//    TowardMiddle = 1,
//    TowardRight = 2,
//}

//// Structures in C#
//Employee myEmployee = new Employee(1, "Rus");
//Console.WriteLine($"Name: {myEmployee.Name}, ID: {myEmployee.Id}");

//Employee myEmployeeTwo = new();
//myEmployeeTwo.Name = "Jack";
//myEmployeeTwo.Id = 2;
//Console.WriteLine($"Name: {myEmployeeTwo.Name}, ID: {myEmployeeTwo.Id}");

//Employee myEmployeeThree;
//myEmployeeThree.Name = "Kate";
//myEmployeeThree.Id = 3;
//Console.WriteLine($"Name: {myEmployeeThree.Name}, ID: {myEmployeeThree.Id}");
//struct Employee
//{
//    public int Id;
//    public string Name;
//    public Employee(int id, string name)
//    {
//        this.Id = id;
//        this.Name = name;
//    }
//}

////3.P1
//Console.WriteLine($"Type1 = {(int)Codes.Type1}");
//Console.WriteLine($"Type2 = {Codes.Type2}");
//Console.WriteLine($"Type3 = {(int)Codes.Type3}");
//enum Codes
//{
//    Type1,
//    Type2,
//    Type3
//}

////3.P2
//Console.WriteLine($"Val4 = {(int)Values.Val4}");
//enum Values
//{
//    Val1=25,
//    Val2=52,
//    Val3=65,
//    Val4
//};

////3.P3
//TrafficLight light0 = TrafficLight.Red;
//Console.WriteLine($"The integral value of {light0} is {(int)light0}");
//var light1 = TrafficLight.Green;
//Console.WriteLine($"The light1 is {light1}");
//var light2 = (TrafficLight)2;
//Console.WriteLine($"The light2 is {light2}");
//var light3 = (TrafficLight)3;
//Console.WriteLine($"The light3 is {light3}");
//var light75 = (TrafficLight)75;
//Console.WriteLine($"The light75 is {light75}");
//enum TrafficLight : byte
//{
//    Red,
//    Green,
//    Yellow
//};

//// 3.P4
//Console.WriteLine($"Val2 = {(byte)Values.Val2}");
//enum Values : byte
//{
//    Val1,
//    Val2,
//    Val3
//}

////3.P5 Cannot use non-value types to define enumerations
////3.P6
//Console.WriteLine($"The members of BigNumbers are: {Enum.GetUnderlyingType(typeof(BigNumbers))}");
//Console.WriteLine($"The members of SmallNumbers are {Enum.GetUnderlyingType(typeof(SmallNubmers))}");
//enum BigNumbers
//{
//    Num1 = 1001,
//    Num2 = 7005,
//    Num3 = 3005
//};

//enum SmallNubmers : short
//{
//    Num1 = 10,
//    Num2 = 7,
//    Num3 = 21
//};

////3.P7

//foreach (Numbers num in Enum.GetValues(typeof(Numbers)))
//{
//    Console.WriteLine($"{num} has stored {(int)num}");
//}
//enum Numbers
//{
//    Num1 = 75,
//    Num2 = -17,
//    Num3,
//    Num4 = 0,
//    Num5 =95
//};

//// 3.P8
//using System.Globalization;
//foreach (Numbers num in Enum.GetValues(typeof(Numbers)))
//{
//    Console.WriteLine($"{num} is storing {(int)num}");
//}
//enum TrafficLight : byte
//{
//    Red,
//    Green = (byte)Numbers.Num3,
//    Yellow
//};

//enum Numbers
//{
//    Num1 = -12,
//    Num2 = TrafficLight.Red,
//    Num3,
//    Num4=100
//};

//// 3.P9 No Circular references
//// 3.P10 enum members must be constant
//using System.Reflection.Emit;

//Console.WriteLine($"The Code1 = {(int)Test.Codes.Code2}");
//Console.WriteLine($"The Code2 = {(Test.Codes)2}");
//public class Test
//{
//    const int flag = 2;
//    public enum Codes
//    {
//        Code1 = 1,
//        Code2 = flag,
//        Code3 = 3
//    };
//}

//// 3.P11
//Console.WriteLine($"Type0= {(int)Sample.ErrorTypes.NetworkError}");
//Console.WriteLine($"Type2= {(Sample.ErrorTypes)2}");

//class Sample
//{
//    public enum ErrorTypes
//    {
//        NetworkError,
//        CodeError,
//        DeviceError,
//    }
//}


//// 3.P13 Flags Enumeration
//Console.WriteLine(ErrorTypes.NetworkError & ErrorTypes.CodeError);
//Console.WriteLine(ErrorTypes.DeviceError | ErrorTypes.CodeError | ErrorTypes.NetworkError);

//[Flags]
//public enum ErrorTypes
//{
//    NoError=0,
//    NetworkError=1,
//    CodeError=2,
//    DeviceError=4,
//};

//// 3.P14 The struct Type Fundamentals
//Employee emp1 = new Employee("Ruslan");
//Console.WriteLine($"{emp1.Name} is a {emp1.Occupation()}");
//interface IPerson
//{
//    string Occupation();
//}

//struct Employee : IPerson
//{
//    public string Name;
//    public Employee(string name = null)
//    {
//        Name = name;
//    }
//    public string Occupation()
//    {
//        return "salaried person.";
//    }
//}

//// 3.P15 Structure type can't inherit from  other class or structure type
//// 3.P21
//// Testing the Default Value Expression
//using System.Drawing;

//Point point1 = new Point();
//Console.WriteLine($"Point_1:{point1}");

//Point point2 = default(Point);
//Console.WriteLine($"Point_2:{point2}");
//struct Point
//{
//    int _xCoordinate = 1;
//    int _yCoordinate;

//    public Point()
//    {
//        _yCoordinate = 2;
//    }
//    public override string ToString()
//    {
//        string temp ="("+_xCoordinate+","+_yCoordinate+")";
//        return temp;
//    }
//}

//// 3.P22 Testing a Nondestructive Mutations

//Employee emp1 = new Employee("Sam",1);
//Console.WriteLine(emp1);

//Employee emp2 = emp1 with { Id = 2 };
//Console.WriteLine(emp2);
//struct Employee
//{
//    public string Name;
//    public int Id;
//    public Employee(string name, int id)
//    {
//        Name = name;
//        Id = id;
//    }

//    public override string ToString()
//    {
//        string emp = Name + " has ID " + Id;
//        return emp;
//    }
//}

////Part II OBJECT-ORIENTED PROGRAMMING
//// Classes and Objects

////4T.2
//Console.WriteLine("***Class and Object Demo in C#.");
//// Creating an object of Sample
//Sample sample1 = new Sample(5);
//Sample sample2 = new(6);
//Console.WriteLine($"sample1._id = {sample1._id}");
//Console.WriteLine($"sample2._id = {sample2._id}");
//class Sample
//{
//    internal int _id;
//    public Sample(int id)
//    {
//        this._id = id;
//    }
//}

//// 4.T6 Constructor
//Sample sample = new Sample();
//Console.WriteLine($"The variable _flag is initialized with {sample._flag}");
//class Sample
//{
//    internal int _flag;
//    //internal Sample()
//    //{
//    //    this._flag = 10;
//    //}
//}

//// 4.T8 "this" keyword
//class Sample
//{
//    internal int id;
//    public Sample(int id)
//    {
//        this.id = id;  // this keyword helps compiler distinguish between instance and local variables
//    }
//}

//// 4.P1
//Sample sample = new();
//Console.WriteLine($"sample.i={sample.i}");
//Console.WriteLine($"sample.d={sample.d}");
//class Sample
//{
//    internal int i = 5;
//    internal double d;
//    internal Sample()
//    {
//        Console.WriteLine($"Current value of i is: {i}");
//        Console.WriteLine($"Current value of d is: {d}");

//        //Changing values
//        i += 2;
//        d++;
//    }
//}

//// 4.P2
//Sample sample = new(j:6,i:5);
//Console.WriteLine($"sample._i={sample._i}");
//Console.WriteLine($"sample._j={sample._j}");
//class Sample
//{
//    internal int _i;
//    internal int _j;
//    internal Sample(int i=0, int j=0)
//    {
//        this._i = i;
//        this._j = j;
//    }
//}

//// 4.P3
//Sample sample = new();
//Console.WriteLine($"sample._flag={sample._flag}");
//Console.WriteLine($"sample._number={sample._number}");
//class Sample
//{
//    internal int _flag;
//    internal double _number;
//    internal Sample() : this(5) { }
//    internal Sample(int i)
//    {
//        this._flag = i;
//        this._number = _flag * 2;
//    }
//}

////4.P4
//Employee emp1 = new();
//Employee emp2 = new("Bob");
//Employee emp3 = new("Sumit", 2);

//Console.WriteLine("Employee Details:");
//Console.WriteLine($"Name: {emp1.Name}, Id: {emp1.Id}");
//Console.WriteLine($"Name: {emp2.Name}, Id: {emp2.Id}");
//Console.WriteLine($"Name: {emp3.Name}, Id: {emp3.Id}");
//class Employee
//{
//    public string Name;
//    public int Id;

//    public Employee(string name = "Rus", int id = 0)
//    {
//        this.Name = name;
//        this.Id = id;
//    }
//}

////4.P5

//Employee emp1 = new() { Name = "Bob", Id = 1 };
//Employee emp2 = new("Kate") { Id = 3 };

//Console.WriteLine("Employee Details");
//Console.WriteLine($"Name: {emp1.Name}, Id: {emp1.Id}");
//Console.WriteLine($"Name: {emp2.Name}, Id: {emp2.Id}");
//class Employee
//{
//    public string Name;
//    public int Id;
//    public Employee() { }
//    public Employee(string name)
//    {
//        this.Name = name;
//    }
//}

////4.P6 in the Namespace default access modifier - internal

////4.P7
//Sample.NestedSample nested = new();
//Console.WriteLine($"Flag2 = {nested.Flag2}");
//class Sample
//{
//    public int Flag1;
//    public Sample()
//    {
//        Flag1 = 1;
//        Console.WriteLine("Sample is initialized.");
//    }

//    public class NestedSample
//    {
//        public int Flag2;
//        public NestedSample()
//        {
//            Flag2 = 2;
//            Console.WriteLine("NestedSample is initialized.");
//        }
//    }
//}

//// 4.P8 class memebers have private access by defaults

//// 4.P9

//Sample sample = new(7,7);
//var sample1 = sample;
//sample1.flag2 = 3;
//sample1._flag1 = 3;
//Console.WriteLine($"The value of sample1._flag1 = {sample1._flag1}");
//Console.WriteLine($"The value of sample1.flag2 = {sample1.flag2}");

//sample1.Increment();
//Console.WriteLine($"The value of flag1 after increment = {sample1._flag1}");
//Console.WriteLine($"The value of flag2 after increment = {sample1.flag2}");

//class Sample
//{
//    public int _flag1;
//    public int flag2;
//    public Sample(int i = 5, int j = 5)
//    {
//        this._flag1 = i;
//        this.flag2 = j;
//        Increment();
//    }
//    public void Increment()
//    {
//        _flag1++;
//        flag2++;
//        Console.WriteLine($"_flag1={_flag1}");
//        Console.WriteLine($"_flag2={flag2}");
//    }
//}

//// 4.P10
//Sample sample = new();
//sample.AddTwoNumbers(5, 10.7);
//class Sample
//{
//    public void AddTwoNumbers(int num1, double num2)
//    {
//        var number1 = num1;
//        var number2 = num2;
//        Console.WriteLine($"Result: {number1 + number2}");
//    }
//}

////4.P11
//Sample sample = new();
//sample.AddTwoNubmers();
//class Sample
//{
//    int _flag1 = 5;
//    int _flag2 = 7;

//    public void AddTwoNubmers()
//    {
//        var number1 = _flag1;
//        var number2 = _flag2;
//        Console.WriteLine(number1 + number2);
//    }
//}

//// 4.P12
//Sample sample = Sample.GetInstance();
//Console.WriteLine($"sample_flag = {sample._flag}");
//class Sample
//{
//    internal double _flag;
//    private Sample()
//    {
//        _flag = 5.75;
//    }

//    public static Sample GetInstance()
//    {
//        return new Sample();
//    }
//}

//// Chapter 5 Inheritence
//// 5.T2
//class Parent
//{
//    // Some Code
//}
//class Child : Parent  
//{
//    // Some Codes
//}

//class Chiled2 : Parent
//{
//    // Some Code
//}

//class Granchild : Child
//{
//    // Some Code
//}

//// Multiple inheritance demo

//interface IParent1
//{
//    // Some Code
//}

//interface IParent2
//{
//    // Some Code
//}

//class MyClass : IParent1, IParent2
//{
//    // Some Code
//}

//// 5T.5 Private members also inherited
//B obB = new B();
//Console.WriteLine(obB._flag1);
//class A
//{
//    private int _flag1;
//}
//class B : A
//{
//}

//// Fundamentals
//// 5.P1

//GrandChild grandChild = new GrandChild();
//class Parent
//{
//    public Parent()
//    {
//        Console.WriteLine("The parent class constructor is callled");
//    }
//}

//class Child : Parent
//{
//    public Child()
//    {
//        Console.WriteLine("The child class constructor is called");
//    }
//}

//class GrandChild : Child
//{
//    public GrandChild()
//    {
//        Console.WriteLine("The grandchild class constructor is called.");
//    }
//}

//// Re-writing in expression-body style

//GrandChild grandChild = new GrandChild();
//class Parent
//{
//    public Parent() => Console.WriteLine("The parent class constructor is called");
//}

//class Child : Parent
//{
//    public Child() => Console.WriteLine("The child class constructor is called");
//}

//class GrandChild : Child
//{
//    public GrandChild() => Console.WriteLine("The grandchild class constructor is called");
//}

//// 5.P2
//B b = new B();
//Console.WriteLine(b.x);
//Console.WriteLine(b.y);
//class A
//{
//    public int x = 1;
//}

//class B : A
//{
//    public int y = 2;
//}

//// 5.P3

//Child child = new Child(1, 2);
//child.Display();
//class Parent
//{
//    protected int a;
//    public Parent() { }
//    public Parent(int a)
//    {
//        this.a = a;
//    }
//}

//class Child : Parent
//{
//    internal int b;
//    public Child(int a, int b) : base(a)
//    {
//        this.b = b;
//    }

//    public void Display()
//    {
//        Console.WriteLine("Initialized values are:");
//        Console.WriteLine($"a={a}");
//        Console.WriteLine($"b={b}");
//    }
//}

//// 5.P4
//Employee emp = new Employee() { name = "Ruslan",ssn="12345", id = "E002" };
//emp.DisplayInfo();
//class Person
//{
//    public string ssn = "123-45-6789";
//    public string name = "K. Peterson";

//    public Person(string name = "", string ssn = "")
//    {
//        this.name = name;
//        this.ssn = ssn;
//    }

//    protected void GetInfo()
//    {
//        Console.WriteLine($"Name: {name}");
//        Console.WriteLine($"SSN: {ssn}");
//    }
//}

//class Employee : Person
//{
//    public string id;

//    public Employee() => id = "E001";

//    public void DisplayInfo()
//    {
//        base.GetInfo();
//        Console.WriteLine($"ID:{id}");
//    }
//}


//// 5.P5 ChildClass cannot derive from sealed type 'Parent'

//// 5.P6
//Polygon polygon = new Square();
//class Polygon
//{
//    public Polygon() => Console.WriteLine("Polygon class constructor.");
//}
//sealed class Square : Polygon
//{
//    public Square() => Console.WriteLine("Square class constructor.");
//}


//// 5.P7 constructors are not inherited at all

//// 5.P8 Method Overloading

//Sample sample = new Sample();
//Console.WriteLine(sample.Add(2,3));
//Console.WriteLine(sample.Add("Ruslan","Rus"));
//class Sample
//{
//    public int Add(int x, int y) => x + y;
//    public string Add(string s1, string s2) => string.Concat(s1, ",", s2);
//}

//// 5.P9 return type not part of method signature for method overloading

//// 5.P10 Constructor Overloading
//Employee employee = new Employee();
//Employee employee3 = new Employee(2);
//Employee employee2 = new Employee("Rus", 3);
//class Employee
//{
//    public Employee() =>
//        Console.WriteLine("Employee name: Unknown, ID: Not Given");
//    public Employee(int id) =>
//        Console.WriteLine($"Employee name: Unknown, ID: {id}");
//    public Employee(string name, int id) =>
//        Console.WriteLine($"Employee name: {name}, ID: {id}");
//}

//// 5.P11
//Console.WriteLine("Overloading the Main() method.");
//Main(5);
//static void Main(int a)
//{

//    Console.WriteLine("I am inside Main(int a) now.");
//}

//// 5.P12
//Console.WriteLine("Overloading the Main() method");
//Main();
//static void Main() => Console.WriteLine("I am inside Main() now.");

//// 5.P13 memeber names cannot be the same as their enclosing type

////5.P14 Method Overriding
//Dervied dervied = new Dervied();
//dervied.DoNotChangeMe();
//dervied.ChangeMe();
//class Parent
//{
//    public virtual void ChangeMe()
//    {
//        Console.WriteLine("Initial version of the ChangeMe().");
//    }

//    public void DoNotChangeMe()
//    {
//        Console.WriteLine("Initial version of the DoNotChangeMe().");
//    }
//}

//class Dervied : Parent
//{
//    public override void ChangeMe()
//    {
//        Console.WriteLine("Updated version of the ChangeMe().");
//    }
//}

//// 5.P15 Cannot override inherited member when it is not marked virtual, abstract, or override

//// 5.P16 & 5.P17
//Derived derived = new Derived();
//derived.ShowMe();
//class Parent
//{
//    public virtual void ShowMe()=>
//        Console.WriteLine("The ShowMe() of Sample");
//}

//class Derived : Parent
//{
//    public override void ShowMe()=>
//        Console.WriteLine("The ShowMe() of Derived.");
//}

//// 5.P18 Method signatures must be the same for overriding to work!

////5.P19 Method overridng and overloading together

//Parent parent = new Parent();
//int value1 = parent.GetNumber(5);
//Console.WriteLine($"Value1:{value1}");

//Child child = new Child();
//int value2 = child.GetNumber(5);
//int value3 = child.GetNumber(5,7);
//Console.WriteLine($"Value2: {value2}");
//Console.WriteLine($"Value3: {value3}");

//class Parent
//{
//    public virtual int GetNumber(int i) => i;
//}

//class Child : Parent
//{
//    public override int GetNumber(int i) => i + 2;
//    public int GetNumber(int i, int j) => i + j;
//}


//// 5.P20, 5.P21 return type, method parameters and access specifiers of virtual and overridden methos must be the same

//// 5.P22 Method Hiding
//Console.WriteLine("Understanding the new Keyword in C#.");
//Parent parent = new Parent();
//Console.WriteLine(parent.GetNumber(5));
//Console.WriteLine(parent.GetNumber(5,7));

//Console.WriteLine("-----.");
//Child child = new Child();
//Console.WriteLine(child.GetNumber(5));
//Console.WriteLine(child.GetNumber(5,7));
//class Parent
//{
//    internal virtual int GetNumber(int i) => i;
//    public virtual int GetNumber(int i, int j) => i + j;
//}

//class Child : Parent
//{
//    internal override int GetNumber(int i) => i + 2;
//    internal new int GetNumber(int i, int j) => i + j + 15;
//}

//// 5.P23 Covariance and Contravariance
//Console.WriteLine("Experimenting covariance.");
//Parent parent = new Parent();
//Console.WriteLine($"The flag value in the parent class is:  {parent.GetFlag(5).Flag}");
//Child child = new Child();
//Console.WriteLine($"The flag value in the child class is: {child.GetFlag(5).Flag}");
//public class Parent
//{
//    public int Flag;

//    public virtual Parent GetFlag(int flag)
//    {
//        this.Flag = flag;
//        return this;
//    }
//}

//public class Child : Parent
//{
//    public override Child GetFlag(int flag)
//    {
//        this.Flag = flag * 2;
//        return this;
//    }
//}


//// Chapter 6 - Polymorphism
//Console.WriteLine("Polymorphic code example.");

//Animal animal = new Animal();
//animal.Sound();
//animal = new Tiger();
//animal.Sound();
//animal = new Dog();
//animal.Sound();

//class Animal
//{
//    public virtual void Sound()
//    {
//        Console.WriteLine("An animal can make sounds.");
//    }
//}

//class Tiger : Animal
//{
//    public override void Sound()
//    {
//        Console.WriteLine("Tiger roar.");
//    }
//}

//class Dog : Animal
//{
//    public override void Sound()
//    {
//        Console.WriteLine("Dog bark.");
//    }
//}

//// 6.T4
//Home home = new CompleteHome();
//home.ShowStatus();
//abstract class Home
//{
//    public abstract void ShowStatus();
//}
//class CompleteHome : Home
//{
//    public override void ShowStatus()
//    {
//        Console.WriteLine("The home construction is finished.");
//    }
//}

//// 6.T6 Interfaces
//Tiger tiger = new Tiger();
//tiger.Sound(); 
//interface IAnimal
//{
//    void Sound();
//}

//class Tiger : IAnimal
//{
//    public void Sound()
//    {
//        Console.WriteLine("Tiger roar.");
//    }
//}

//// Chapter 6 Programming Questions

//// 6.P1
//Console.WriteLine("Understanding the new Keyword in C#.");
//Parent parent = new Parent();
//Console.WriteLine(parent.GetNumber(5));
//Console.WriteLine(parent.GetNumber(5,7));

//Console.WriteLine("----");
//parent = new Child();
//Console.WriteLine(parent.GetNumber(5));
//Console.WriteLine(parent.GetNumber(5,7)); // still uses original method in Parent class

//Child child = new Child();
//Console.WriteLine(child.GetNumber(5,7)); // uses new method in the Child class
//class Parent
//{
//    internal virtual int GetNumber(int i) => i;
//    public virtual int GetNumber(int i, int j) => i + j;
//}

//class Child : Parent
//{
//    internal override int GetNumber(int i) => i + 2;
//    internal new int GetNumber(int i, int j) => i + j + 15;
//}

//// 6.P2
//Vehicle vehicle = new Vehicle();
//vehicle.ShowCommonFeature();
//Bus bus = new Bus();
//bus.ShowSpecialFeature();
//class Vehicle
//{
//    public virtual void ShowCommonFeature()
//    {
//        Console.WriteLine("Inside Vehicle.ShowCommonFeature");
//    }
//}

//class Bus : Vehicle
//{
//    public override void ShowCommonFeature()
//    {
//        Console.WriteLine("Inside Bus.ShowCommonFeature");
//    }

//    public void ShowSpecialFeature()
//    {
//        Console.WriteLine("Inside Bus.ShowSpecialFeature");
//    }
//}

//// 6.P3
//Vehicle vehicle = new Bus();
//vehicle.ShowCommonFeature();
//class Vehicle
//{
//    public virtual void ShowCommonFeature()
//    {
//        Console.WriteLine("The basic features are added.");
//    }
//}
//class Bus : Vehicle
//{
//    public override void ShowCommonFeature()
//    {
//        base.ShowCommonFeature();
//        Console.WriteLine("The bus-specific features are added.");
//    }
//}

//// 6.P4 Abstract Class Case Studies
//Home home = new CompleteHome();
//home.ShowStatus();
//abstract class Home
//{
//    public abstract void ShowStatus();
//}
//class CompleteHome : Home
//{
//    public override void ShowStatus() =>
//        Console.WriteLine("The home construction is finished.");
//}

//// 6.P5 Class needs to be abstract to have abstract members
//abstract class Shape
//{
//    public void About()
//    {
//        //Some code
//    }
//    public void ShowArea()
//    {
//        //Some code
//    }
//    public abstract void SpecialFetures();
//}


//// 6.P6 Cannot instantiate Shape, only the derived class
//abstract class Shape
//{
//    public void About()
//    {
//        // Some code
//    }
//    public void ShowArea()
//    {
//        // Some code
//    }
//}


//// 6.P7
////Shape shape = new Shape(); // Error CS0144
//abstract class Shape
//{
//    public void About()
//    {
//        // Some code
//    }
//    public void ShowArea()
//    {
//        // Some code
//    }
//    public abstract void SpecialFeatures();
//}

//// 6.P8
//Animal monkey = new Monkey("black");
//monkey.Run();
//monkey.Jump();
//abstract class Animal
//{
//    string? color;
//    public Animal(string color)
//    {
//        Console.WriteLine($"Instantiating an animal with {color} color.");
//    }

//    public void Run()=>
//        Console.WriteLine("It can run.");

//    public abstract void Jump();
//}

//class Monkey : Animal
//{
//    public Monkey(string color):base(color)=>
//        Console.WriteLine("It becomes a monkey.");

//    public override void Jump()=>
//        Console.WriteLine("It can jump.");
//}

//// 6.P9
//abstract class Shape
//{
//    public abstract void AboutMe();
//    public abstract void ShowArea();
//}
//class Polygon : Shape
//{
//    public override void AboutMe() =>
//        Console.WriteLine("Polygon");
//    public override void ShowArea() =>
//        Console.WriteLine("Area");
//}

// 6.P10 Abstract Class cannot be Sealed
// 6.P11 Cannot mark constructor with the abstract or sealed modifier

//// 6.P12 Interface Case Studies
//Console.WriteLine("Interface case studies.");
//IAnimal animal = new Tiger();
//animal.Sound();
//animal = new Dog();
//animal.Sound();

//interface IAnimal
//{
//    void Sound();
//}

//class Tiger : IAnimal
//{
//    public void Sound()
//    {
//        Console.WriteLine("Tiger roar.");
//    }
//}

//class Dog : IAnimal
//{
//    public void Sound()
//    {
//        Console.WriteLine("Dog bark.");
//    }
//}

//// 6.P13
//Console.WriteLine("Case study - 6.P13");
//IAnimal tiger = new CompletedTiger();
//tiger.Sound();
//tiger.Run();

//interface IAnimal
//{
//    void Sound();
//    void Run();
//}
//abstract class Tiger : IAnimal
//{
//    public abstract void Run();
//    public void Sound() => Console.WriteLine("Tiger roar.");
//}

//class CompletedTiger : Tiger
//{
//    public override void Run()
//    {
//        Console.WriteLine("Tiger runs.");
//    }
//}

//// 6.P14
//IAnimal tiger = new BengalTiger();
//tiger.Sound();
//tiger.Run();

//interface IAnimal
//{
//    void Sound();
//    void Run();
//}

//abstract class Tiger : IAnimal
//{
//    public abstract void Run();
//    public void Sound() => Console.WriteLine("Tiger roar.");
//}

//class BengalTiger : Tiger
//{
//    public override void Run() => Console.WriteLine("Bengal tiger run fast.");
//}

//// 6.P15
//IElectronicDevice laptop = new IdeaPad33OS();
//laptop.ShowConfiguration();
//laptop.DisplayStorage();
//interface IElectronicDevice
//{
//    void DisplayStorage();
//    void ShowConfiguration();
//}

//class Laptop
//{
//    public virtual void ShowConfiguration()
//    {
//        Console.WriteLine("A laptop must have an operating system and ram.");
//    }
//}
//class IdeaPad33OS : Laptop, IElectronicDevice
//{
//    public override void ShowConfiguration()
//    {
//        base.ShowConfiguration();
//        Console.WriteLine("An Ideapad33OS supports Windows OS, 4GB ram, and 1TB HDD storage.");
//    }
//    public void DisplayStorage() =>
//        Console.WriteLine("An Ideapad33OS has 1TB HDD storage.");
//}

// 6.P16 C# has positional notations, parent class positioned first, followed by interface names

//// 6.P17
//SuperCar car = new();
//Console.WriteLine("Car details:");
//Console.WriteLine($"Has an air conditioner? {car.AirConditioner()}");
//Console.WriteLine($"Number of wheels: {car.ShowNumberOfWheels()}");
//interface IWheels
//{
//    int ShowNumberOfWheels();
//}
//interface IACFacility
//{
//    bool AirConditioner();
//}
//class SuperCar : IACFacility, IWheels
//{
//    public bool AirConditioner() => true;
//    public int ShowNumberOfWheels() => 4;
//}

//// 6.P18 explicit interface implementation
//IVehicle car = new Car();
//car.Describe();
//interface IVehicle
//{
//    void Describe();
//}
//class Car : IVehicle
//{
//    void IVehicle.Describe()
//    {
//        Console.WriteLine("This is a car.");
//    }
//}

//// 6.P19
//XyzCar car = new();
//car.Describe();
//interface IVehicle
//{
//    void Describe();
//}
//interface ICompany
//{
//    void Describe();
//}

//class XyzCar : IVehicle, ICompany
//{
//    public void Describe() =>
//        Console.WriteLine("This is a car from XYZ company.");
//}

//// 6.P20

//Console.WriteLine("Experimenting with implicit and explicit interface implementations.");
//XyzCar car = new();
//car.Describe();
//((IVehicle)car).Describe();
//((ICompany)car).Describe();

//interface IVehicle
//{
//    void Describe();
//}
//interface ICompany
//{
//    void Describe();
//}
//class XyzCar : IVehicle, ICompany
//{
//    public void Describe() =>
//        Console.WriteLine("This is a car from XYZ company.");

//    void IVehicle.Describe() => Console.WriteLine("Implementing IVehicle.Describe().");

//    void ICompany.Describe() => Console.WriteLine("Implementing ICompany.Describe().");
//}

//// 6.P.21
//Console.WriteLine("Experimenting with a default inteface method");
//IVehicle vehicle = new Car();
//vehicle.Describe();
//interface IVehicle
//{
//    internal void Describe()=>
//        Console.WriteLine("The XYZ company makes this car.");
//}
//class Car : IVehicle
//{
//}

//// 6.P.22
//Car car = new();
//car.Describe();
//((IVehicle)car).Describe();
//interface IVehicle
//{
//    internal void Describe() =>
//        Console.WriteLine("The XYZ company makes this car");
//}
//class Car : IVehicle
//{
//    internal void Describe()
//    {
//        Console.WriteLine("Overriding the default interface method.");
//    }
//    void IVehicle.Describe()
//    {
//        Console.WriteLine("Explicitly overriding the default interface method.");
//    }
//}

// 6.P23 Interface cannot inherit from the class
// 6.P24 Interface cannot contain instance fields
//// 6.P25
//Console.WriteLine("Can a tag an interface method with the abstract keyword?");
//SomeClass myClass = new SomeClass();
//myClass.Show();
//((ISomeInteface)myClass).Show();
//interface ISomeInteface
//{
//    abstract void Show();
//}

//class SomeClass : ISomeInteface
//{
//    public void Show() => Console.WriteLine("Show method implemintation");
//    void ISomeInteface.Show() =>
//        Console.WriteLine("Implementing show method.");
//}

//// 6.P26
//Console.WriteLine("Can an interface contain a class?");
//public interface ISample
//{
//    public class SomeClass
//    {

//    }
//}

// Chapter 7 Encapsulation

//// 7.T5
//Console.WriteLine("Properties Demo - 1.");
//Game game = new();
////game._score = 10;
//game.Score = 70;
//Console.WriteLine($"Current score: {game.Score}");
//class Game
//{
//    private int _score;
//    public int Score
//    {
//        get { return _score; }
//        set { _score = value; }
//    }
//}

//// Alternative Code to Create a Property

//class Game
//{
//    private int _score;
//    public int Score
//    {
//        get => _score;
//        set => _score = value;
//    }
//}

//Game game = new Game(75);
//Game game1 = new Game();
//Game game2 = new Game(135);
//Console.WriteLine(game.Score);
//Console.WriteLine(game1.Score);
//class Game
//{
//    public int Score { get; set; } = 60; // default value
//    public Game(int score = 0)
//    {
//        Score = score;
//    }
//}

//// 7.T10 How can I create an indexer in C#?
//Console.WriteLine("***Indexer Demo***");
//Animals animals = new();
//Console.WriteLine("Here are the animals:");
//Console.WriteLine(animals[0]);
//Console.WriteLine(animals[1]);

//// Updating the animal type at index 0
//animals[0] = "Cat";

//Console.WriteLine("The updated list of the animals:");
//Console.WriteLine(animals[0]);
//Console.WriteLine(animals[1]);

//class Animals
//{
//    private string[] _names;
//    public Animals()
//    {
//        _names = new string[] { "Tiger", "Lion" };
//    }

//    public string this[int index]
//    {
//        get
//        {
//            string temp = String.Empty;
//            if (index >= 0 && index < _names.Length)
//            {
//                temp = _names[index];
//            }
//            else
//            {
//                // You can throw an error
//            }

//            return temp;
//        }
//        set
//        {
//            if (index >= 0 && index < _names.Length)
//            {
//                _names[index] = value;
//            }
//            else
//            {
//                // You can throw an error
//            }
//        }
//    }
//}

//// Chapter 7 Programming Skills
//// 7.P1
//Console.WriteLine("Experimenting properties in C#.");
//Game game = new();
//Console.WriteLine($"Current level: {game.Level}");
//game.Level = 2;
//Console.WriteLine($"Current level: {game.Level}");
//class Game
//{
//    private int _level;
//    public Game() { _level = 1; }
//    public int Level
//    {
//        get => _level;
//        set => _level = value;
//    }
//}

//// 7.P2
//Console.WriteLine("Experimenting properties in C#");
//Game game = new();
//game.Level = 2;
//class Game
//{
//    private int level;
//    public int Level
//    {
//        get => level;
//        set => level = value;
//    }
//}

//// 7.P3
//Game game = new();
//Console.WriteLine($"Current level: {game.Level}");
//game.Level = 2;
//Console.WriteLine($"Current level: {game.Level}");
//game.Level = 3;
//Console.WriteLine($"Current level: {game.Level}");
//class Game
//{
//    private int level = 1;
//    public int Level
//    {
//        get => level;
//        set
//        {
//            if (value < 0 || value > 2)
//            {
//                level = 0;
//            }
//            else { level = value; }
//        }
//    }
//}

////7.P4
//Game game = new();
//Console.WriteLine($"The current level: {game.Level}");
//game.Level = 3;
//Console.WriteLine($"The current level: {game.Level}");

//class Game
//{
//    public int Level
//    {
//        get; set;
//    } = 2;
//}

//// 7.P5 Virtual and Abstract Properties
//Console.WriteLine("Experimenting with a virtual property in C#");
//Shape shape = new();
//Console.WriteLine($"The area of the {shape} is {shape.Area} square units.");
//shape = new Circle(10);
//Console.WriteLine($"The area of the {shape} is {shape.Area} square units.");
//Circle circle = new Circle(10);
//Console.WriteLine($"The area of the {shape} is {circle.Area}");
//class Shape
//{
//    public virtual double Area
//    {
//        get => 0;
//    }
//    public override string ToString()
//    {
//        return "unknown shape";
//    }
//}
//class Circle : Shape
//{
//    readonly int _radius;
//    public Circle(int radius)
//    {
//        this._radius = radius;
//    }   
//    public int Radius
//    {
//        get => _radius;
//    }
//    public override double Area
//    {
//        get => 3.14 * _radius * _radius;
//    }
//    public override string ToString()
//    {
//        return "cirle";
//    }
//}

//// 7.P6
//Console.WriteLine("Experimenting with an abstract property in C#");
//Shape shape = new Rectangle();
//Console.WriteLine($"The area of the {shape} is {shape.Area} square units");
//abstract class Shape
//{
//    public abstract double Area { get; }
//    public override string ToString()
//    {
//        return "unknown shape";
//    }
//}
//class Rectangle : Shape
//{
//    public override double Area
//    {
//        get => 100;
//    }
//    public override string ToString()
//    {
//        return "rectangle";
//    }
//}

//// 7.P7 The Usage of the init Keyword
//Console.WriteLine("Experimenting with the 'init' keyword.");
//Game game = new() { Name="NewGame"};
////game.Name = "NewGame";
//Console.WriteLine($"Game name: {game.Name}");
//class Game
//{
//    private string _name;
//    public Game() { _name = "SuperGame"; }
//    public string Name
//    {
//        get => _name;

//        init => _name = value;
//    }
//}

//Game game = new Game("NewGame");
//Console.WriteLine($"The game name value is {game.Name}");
//game.Name = "Test";
//Console.WriteLine($"The new game value is {game.Name}");
//game = new Game();
//Console.WriteLine($"The new game value is {game.Name}");
//class Game
//{
//    public string Name { get; set; }

//    public Game(string name="Game")
//    {
//        Name = name;
//    }
//}


//// 7.P9
//Game game = new();
//Console.WriteLine($"The game name: {game.Name}");
//game = new() { Name = "Airplane Simulator" };
//Console.WriteLine($"The new game name: {game.Name}");
//class Game
//{
//    private string _name;
//    public Game() { _name = "Car Simulator"; }
//    public string Name
//    {
//        get => _name;
//        init => _name = value;
//    }
//}

//// 7.P10
//Game game = new();
//Console.WriteLine($"Game name: {game.Name}");
//class Game
//{
//    public string Name { get; init; } = "Super Game";
//}

//// 7.P11 Using Indexers
//Console.WriteLine("***Indexer Demo***");
//Animals animals = new();
//Console.WriteLine("Here are the animals:");
//Console.WriteLine(animals[0]);
//Console.WriteLine(animals[1]);
//class Animals
//{
//    private string[] _names;
//    public Animals()
//    {
//        _names = new string[] { "Tiger", "Lion" };
//    }
//    public string this[int index]
//    {
//        get => _names[index];
//        set => _names[index] = value;
//    }
//}

// 7.P12 When dealing with indexed values - use proper validations!!!

//// 7.P13 Properties and Indexers in Interfaces
//Console.WriteLine("Case studies with the interfaces.");
//IEmployee emp = new Employee("Sam", 1);
//Console.WriteLine($"Name: {emp.Name}, ID:{emp.Id}");

//interface IEmployee
//{
//    public string Name { get; set; }
//    public int Id { get; set; }
//}
//class Employee : IEmployee
//{
//    string _name;
//    int _id;
//    public Employee(string name, int Id)
//    {
//        this._name = name;
//        this._id = Id;
//    }
//    public string Name
//    {
//        get => _name;
//        set=> _name = value;
//    }
//    public int Id
//    {
//        get => _id;
//        set=>_id = value;
//    }
//}

//// 7.P14
//Console.WriteLine("Case studies with interfaces");
//IEmployee emp = new Employee("Kate", 2);
//Console.WriteLine($"Name: {emp.Name}, ID:{emp.Id}");
//interface IEmployee
//{
//    public string Name { get; set; }
//    public int Id { get; set; }
//}

//class Employee : IEmployee
//{
//    string _name;
//    int _id;
//    public Employee(string name, int Id)
//    {
//        this._name = name;
//        this._id = Id;
//    }

//    string IEmployee.Name
//    {
//        get => _name;
//        set=> _name = value;
//    }
//    int IEmployee.Id
//    {
//        get=> _id;
//        set=> _id = value;
//    }
//}

//// 7.P15
//Console.WriteLine("Case studies with the interfaces.");
//IEmployee emp = new EmployeeStore();

//// Picking the employee name from the ID
//Console.WriteLine($"The name of the emp[0] is {emp[0]}");
//Console.WriteLine($"The name of the emp[1] is {emp[1]}");
//Console.WriteLine($"The name of the emp[2] is {emp[2]}");

//Console.WriteLine("******************");

//// Picking the employee ID from the name
//Console.WriteLine($"The ID of Sam is {emp["Sam"]}");
//Console.WriteLine($"The ID of Kate is {emp["Kate"]}");
//Console.WriteLine($"The ID of Jack is {emp["Jack"]}");

//class Employee
//{
//    string _name;
//    int _id;
//    public Employee(string name, int Id)
//    {
//        this._name = name;
//        this._id = Id;
//    }

//    public int EmployeeId
//    {
//        get => _id;
//    }

//    public string Name
//    {
//        get => _name;
//    }
//}

//interface IEmployee
//{
//    public string this[int id] { get; }
//    public int this[string name] { get; }
//}

//class EmployeeStore : IEmployee
//{
//    Employee[] employees;
//    public EmployeeStore()
//    {
//        employees = new Employee[]
//        {
//            new Employee("Sam",1),
//            new Employee("Kate",2),
//            new Employee("Jack",3),
//        };
//    }

//    public string this[int id]
//    {
//        get => employees[id].Name;
//    }
//    public int this[string name]
//    {
//        get
//        {
//            int temp = 0;
//            if (name.Equals("Sam")) temp = employees[0].EmployeeId;
//            if (name.Equals("Kate")) temp = employees[1].EmployeeId;
//            if (name.Equals("Jack")) temp = employees[2].EmployeeId;
//            return temp;
//        }
//    }
//}

//// 7.P15 Simplified and experimenting with handling special values strategies
// 1.Set accesors are not mandatory
// 2. indexers can be int or string or any custom type
// 3. indexers can be overloaded
// 4. not-high quality - suseptable to IndexOutOfRangeException
// */

//Console.WriteLine("Case studies with the interfaces.");
//IEmployee emp = new EmployeeStore();

//// Picking the employee name from the ID
//Console.WriteLine($"The name of the emp[0] is {emp[0]}");
//Console.WriteLine($"The name of the emp[1] is {emp[1]}");
//Console.WriteLine($"The name of the emp[2] is {emp[3]}");

//Console.WriteLine("******************");

//// Picking the employee ID from the name
//Console.WriteLine($"The ID of Sam is {emp["Sam"]}");
//Console.WriteLine($"The ID of Kate is {emp["Kate"]}");
//Console.WriteLine($"The ID of Jack is {emp["Jackk"]}");

//class Employee
//{
//    public int EmployeeId;
//    public string Name;
//    public Employee(string name, int id)
//    {
//        EmployeeId = id;
//        Name = name;
//    }
//}
//interface IEmployee
//{
//    public string this[int id] { get; }
//    public int this[string name] { get; }
//}
//class EmployeeStore : IEmployee
//{
//    Employee[] employees;
//    public EmployeeStore()
//    {
//        employees = new Employee[]
//        {
//            new Employee("Sam",1),
//            new Employee("Kate",2),
//            new Employee("Jack",3),
//        };
//    }
//    public string this[int id]
//    {
//        get
//        {
//            if (id >= 0 && id < employees.Length)
//                return employees[id].Name;
//            else
//                return null;
//        }
//    }
//    public int this[string name]
//    {
//        get
//        {
//            foreach (var e in employees)
//            {
//                if (e.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
//                    return e.EmployeeId;
//            }
//            return -1;
//        }
//    }
//}

//// 7.P16 Bonus - Indexer with multiple parameters

//Console.WriteLine("***Indexers with multiple parameters.***");
//IEmployee emp = new EmployeeStore();

//// Picking the employee ID from the name
//Console.WriteLine($"Does the employee Sam with ID 1 exist? {emp["Sam",1]}");
//Console.WriteLine($"Does the employee Kate with ID 2 exist? {emp["Kate",2]}");
//Console.WriteLine($"Does the employee Jack with ID 3 exist? {emp["Jack",3]}");
//class Employee
//{
//    string _name;
//    int _id;
//    public Employee(string name, int Id)
//    {
//        this._name = name;
//        this._id = Id;
//    }
//}
//interface IEmployee
//{
//    public bool this[string name, int id] { get; }
//}
//class EmployeeStore : IEmployee
//{
//    Employee[] employees;
//    public EmployeeStore()
//    {
//        employees = new Employee[]
//        {
//            new Employee("Sam",1),
//            new Employee("Kate",2),
//            new Employee("Jack",3)
//        };
//    }

//    public bool this[string name, int id]
//    {
//        get
//        {
//            bool temp = false;
//            if (name.Equals("Sam") && id == 1) temp = true;
//            if (name.Equals("Kate") && id == 2) temp = true;
//            if (name.Equals("Jack") && id == 3) temp = true;
//            return temp;
//        }
//    }
//}

//// 7.P17
//Rectangle rect = new(5.5, 10);
//Console.WriteLine($"The area of the rectangle is {rect.Area}");
//class Rectangle
//{
//    double length, breadth;
//    public Rectangle(double length, double breadth)
//    {
//        this.length = length;
//        this.breadth = breadth;
//    }
//    public double Area
//    {
//        get => length * breadth;
//    }
//}

// Chapter 8 Handling Exceptions

//// Multiple catch blocks 
//Console.WriteLine("***Case study with multiple catch blocks***");

//try
//{
//    // Some Code
//    throw new IndexOutOfRangeException("Index is out of range.");
//}
//catch (DivideByZeroException ex)
//{
//    // Some Code
//}
//catch (ArithmeticException ex)
//{
//    // Some Code
//}
//catch (Exception ex) when (ex.Message.Contains("Timeout"))
//{
//    Console.WriteLine($"Caught:" +ex.Message);
//    // Some Code
//}
//finally
//{
//    Console.WriteLine("Codign Pro-Tip: Read, Do, Read, Do, Read, Do!");
//    // Some Code
//}

//// Exception Filters
//using System.Net;
/////*
//try
//{
//   // Some code that can raise a WebException
//}
//catch(WebException ex) when(ex.Status == WebExceptionStatus.Timeout)
//{
//    // some code
//}
//catch(WebException ex) when(ex.Status == WebExceptionStatus.ProtocolError)
//{
//    // some code
//}

//// 8.T10 Custom Exception
//Console.WriteLine("***Custom Exception Example***");
//int a = 10, b = 2, result;
//try
//{
//    b--;
//    if (b == 1)
//    {
//        throw new SmallDivisorException($"The divisor becomes {b}");

//        //throw new SmallDivisorException();
//    }
//    result = a / b;
//    Console.WriteLine($"The result of {a} / {b} = {result}");
//}
//catch (SmallDivisorException ex)
//{
//    Console.WriteLine($"Cautght the custom exception: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("\nThank you!");
//}

//class SmallDivisorException : Exception
//{
//    public SmallDivisorException() { }
//    public SmallDivisorException(string msg) : base(msg) { }
//    public SmallDivisorException(string msg, Exception inner) : base(msg, inner) { }
//}

////8.P1
//Console.WriteLine("***Case study on exception handling.***");
//int a = 10, b = 0;
//try
//{
//    int c = a / b;
//    Console.WriteLine($"The a=10,b=0. So, a/b is: {c}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Encoutnered: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Inside the finally block: you cannot skip me!");
//}

//// 8.P2
//Console.WriteLine("***Case study multiple catch blocks.***");
//try
//{
//    Console.WriteLine("Enter an integer:");
//    string input = Console.ReadLine();
//    int number = Convert.ToInt32(input);
//    Console.WriteLine($"You have entered the number: {number}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("You need to enter an integer.");
//    Console.WriteLine($"The exception detail: {ex.StackTrace}");
//}
//catch(OverflowException ex)
//{
//    Console.WriteLine("You need to provide smaller number");
//    Console.WriteLine($"The exception detail: {ex.StackTrace}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Encountered an unkown error.");
//    Console.WriteLine($"The exception detail: {ex.StackTrace}");
//}
//finally
//{
//    Console.WriteLine("Thank you for testing this scenario.");
//}

//// 8.P3
//Console.WriteLine("***Case study with multiple catch blocks***");
//int a = 100, b = 0;
//try
//{
//    Console.WriteLine($"The result of a/b is: {a/b}");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Encountered the DivideByZeroException");
//}
//catch (ArithmeticException ex)
//{
//    Console.WriteLine("Encountered the ArithmeticException");
//}
//finally
//{
//    Console.WriteLine("Foster sence of curiosity!");
//}

//// 8.P4 General Catch Block
//int a = 100, b = 0;
//try
//{
//    Console.WriteLine($"The result of a/b is: {a / b}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"The exception caught: {ex.Message}");
//}
//catch
//{
//    Console.WriteLine("Caught a non-CLS exceptions.");
//}

// 8.P5 Cannot place General Catch block before other specific Catch blocks

//// 8.P6 Throwing and Rethrowing an Exception
//Console.WriteLine("***The case study on the throw statement.***");

//try
//{
//    // Some Code before
//    throw new IndexOutOfRangeException("Index is out of range.");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"The exception caught: {ex.Message}");
//}

//// 8.P7
//Console.WriteLine("***The case study on the trow statement.***");
//NumberMaker numberMaker = new();
//try
//{
//    Console.WriteLine($"numbers[0] = {numberMaker.GetNumber(0)}");
//    Console.WriteLine($"numbers[3] = {numberMaker.GetNumber(3)}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"\nThe Main() caught: {ex.Message}");
//    Console.WriteLine($"\tStacktrace: {ex.StackTrace}");
//}
//class NumberMaker
//{
//    int[] _numbers = { 1, 2, 3 };

//    internal int GetNumber(int index)
//    {
//        try
//        {
//            if (index < 0 || index >= _numbers.Length)
//            {
//                throw new IndexOutOfRangeException("Index is out of range.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"\nThe GetNumber(...) caught:{ex.Message}");
//            Console.WriteLine($"\tStacktrace: {ex.Message}");
//            throw;
//        }
//        return _numbers[index];
//    }
//}

//// 8.P8 Throw Ex
//Console.WriteLine("***The case study on the trow statement.***");
//NumberMaker numberMaker = new();
//try
//{
//    Console.WriteLine($"numbers[0] = {numberMaker.GetNumber(0)}");
//    Console.WriteLine($"numbers[3] = {numberMaker.GetNumber(3)}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"\nThe Main() caught: {ex.Message}");
//    Console.WriteLine($"\tStacktrace: {ex.StackTrace}");
//}
//class NumberMaker
//{
//    int[] _numbers = { 1, 2, 3 };

//    internal int GetNumber(int index)
//    {
//        try
//        {
//            if (index < 0 || index >= _numbers.Length)
//            {
//                throw new IndexOutOfRangeException("Index is out of range.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"\nThe GetNumber(...) caught:{ex.Message}");
//            Console.WriteLine($"\tStacktrace: {ex.Message}");
//            throw ex;
//        }
//        return _numbers[index];
//    }
//}

//// 8.P9
//Console.WriteLine("***The case study on the throw expression.***");
//try
//{
//    int a = 10;
//    // Returns a random number between 0 (inclusive) and 2 (exclusive)
//    int b = new Random().Next(0, 2);
//    Console.WriteLine($"b = {b}");
//    int c = b > 0 ? (a / b) :
//        throw new DivideByZeroException("b becomes 0");
//    Console.WriteLine("Thank you.");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"Caught:"+ex.Message );
//}

//// 8.P10
//using System.Net;
//Console.WriteLine("***A case study on exception filters.***");
//try
//{
//    int a = 10;
//    // Returns a random number between 0 (inclusive) and 2 (exclusive)
//    int b = new Random().Next(0, 2);
//    Console.WriteLine($"b = {b}");
//    int c = b > 0 ? throw new WebException("Timeout error") :
//        throw new WebException("Protocol error");
//    Console.WriteLine("Thank you.");
//}
//catch (Exception ex) when (ex.Message.Contains("Timeout"))
//{
//    Console.WriteLine($"Caught:" + ex.Message);
//}
//catch (Exception ex) when (ex.Message.Contains("Protocol"))
//{
//    Console.WriteLine($"Cought:" + ex.Message);
//}

//// Chapter 9 - Usefull Concepts
//// 9.T1
//int a = 1;
//double b = a;

//// 9.T3
//// static class Rectangle

//Rectangle.CalculateArea();
//static class Rectangle
//{
//    readonly static int _flag = 20;
//    public static void CalculateArea()
//    {
//        Console.WriteLine("The area is shown.");
//    }
//}

//// 9.T5
//double flag = -625.0;
//Console.WriteLine(Math.Abs(flag));
//Console.WriteLine(Math.Sqrt(-flag));

//// 9.T15
//Console.WriteLine(new Sample()._flag2);
//Console.WriteLine(new Sample()._flag2);
//class Sample
//{
//    public readonly int _flag2 = new Random().Next(500);
//}


//// 9.P1 Programming Skills
//using System.Drawing;

//double length = 15.5;
//double breadth = 7;
//double area = Rectangle.GetArea(length, breadth);

//Console.WriteLine($"The rectangle's area is {area} square units");

//class Rectangle
//{
//    public static double GetArea(double len, double bre)
//    {
//        return len * bre;
//    }
//}

// 9.P2 Cannot instantiate a static class
//Console cons = new Console();

//// 9.P3
//Rectangle.CalculateArea();

//Rectangle flag1 = new();
//flag1.DisplaySomehtingElse();
//class Rectangle
//{
//    public static void CalculateArea()
//    {
//        Console.WriteLine("The area is shown.");
//    }
//    public void DisplaySomehtingElse()
//    {
//        Console.WriteLine("Display something (except area).");
//    }
//}

//// 9.P4 
//class Rectangle
//{
//    static readonly int _flag = 20;

//    public static void DisplayFlag()
//    {
//        Console.WriteLine($"Flag1 is {_flag}");
//    }
//}


//// 9.P5 Using Extension Methods
//using Extensions;

//int flag1 = 15;
//int flag2 = flag1.IncrementByFive();
//Console.WriteLine($"flag2 is {flag2}");

//namespace Extensions
//{
//    public static class IntExtension
//    {
//        public static int IncrementByFive(this int i) => i + 5;
//    }
//}

//// 9.P6
//using Extensitioins;
//Sample sample = new();
//sample.DisplayNumber();
//sample.DisplayString();


//public class Sample
//{
//    public int _flag = 10;
//    public void DisplayNumber()
//    {
//        Console.WriteLine(_flag);
//    }
//}

//namespace Extensitioins
//{
//    public static class SampleExtension
//    {
//        public static void DisplayString(this Sample s)
//        {
//            Console.WriteLine(s.ToString());
//            Console.WriteLine(s._flag);
//        }
//    }
//}

//// 9.P8
//using Extensions;
//Sample sample = new();
//sample.Display();
//public class Sample
//{
//    public void Display()
//    {
//        Console.WriteLine("The instance method is called.");
//    }
//}

//namespace Extensions
//{
//    public static class SampleExtension
//    {
//        public static void Display(this Sample s)
//        {

//            Console.WriteLine("The extension method is called");
//        }
//    }
//}

//// 9.P9 Passing by Value-Type by Value
//Console.WriteLine("Passing a value type by value.");
//int flag = 50;
//Sample.Change(flag);
//Console.WriteLine($"The final value is {flag}");
//class Sample
//{
//    internal static void Change(int x)
//    {
//        x *= 2;
//        Console.WriteLine($"Inside Change(), the value is {x}");
//    }
//}

//// 9.P10 Passing the Value-Type by Reference
//int flag = 50;
//Sample.Change(ref flag);
//Console.WriteLine($"The final value is {flag}");

//class Sample
//{
//    internal static void Change(ref int x)
//    {
//        x *= 2;
//        Console.WriteLine($"Inside Change(),the value is {x}");
//    }
//}

//// 9.P11
//int flag;
//Sample.Change(out flag);
//Console.WriteLine($"The final value is {flag}");
//class Sample
//{
//    internal static void Change(out int x)
//    {
//        x = 100;
//        Console.WriteLine($"Inside the Change(), the value is {x}");
//    }
//}

//// 9.P12 Using the is Operator
//Circle circle = new();
//Rectangle rectangle = new();
//Console.WriteLine($"Is the circle a special type of shape?{circle is Shape}");
//Console.WriteLine($"Is the cirle a special type of rectangle?{circle is Rectangle}");

//class Shape { }
//class Circle :Shape { }
//class Rectangle : Shape { }

//// 9.P13
//double i = 60.5;
//object iBoxed = i;
//double? jNullable = 40.2;
//if(iBoxed is double a &&  jNullable is double b)
//{
//    Console.WriteLine($"Result is {a+b}");
//}

//// 9.P14 Using as Operator
//Shape shape = new();
//Circle circle = new();
//Shape? convertedShape = circle as Shape;
//Console.WriteLine($"The conversion 'circle as Shape' proudces {convertedShape}");
//Circle? convertedCircle = shape as Circle;
//if (convertedCircle == null)
//{
//    Console.WriteLine($"The conversion 'shape as Circle' produces null.");
//}
//else
//{
//    Console.WriteLine($"The conversion 'shape as Circle' produces {convertedCircle}");
//}
//class Shape { }
//class Circle :Shape { }

//// 9.P16 A Method That Returns Multiple Values
//Console.WriteLine("Testing a method that returns multiple values");
//double radius = 10.0;
//double area, perimeter;
//string description = string.Empty;
//Sample.UpdateDetails(radius, out area, out perimeter, out description);
//Console.WriteLine($"The area of the circle is {area} sq.units.");
//Console.WriteLine($"The perimeter of the circle is {perimeter} units.");
//Console.WriteLine($"Description: it is a {description}");

//class Sample
//{
//    public static void UpdateDetails(double x, out double area, out double peri, out string desc)
//    {
//        area = 3.14 * x * x;
//        peri = 2 * 3.14 * x;
//        desc = "filled";
//    }
//}

//// 9.P17 Comparing the const and readonly Keywords
//new Sample().Display();
//class Sample
//{
//    private static readonly int s_flag = 1;
//    static Sample()
//    {
//        s_flag = 25;
//    }
//    public void Display()
//    {
//        Console.WriteLine($"Flag is {s_flag}");
//    }

//}

// Chapter 10 - Delegates
//// 10.T1
//using Program_10_T1;

//int a = 25, b = 75;
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// Case -1
//Console.WriteLine("Called the Sum method without using a delegate.");
//Console.WriteLine($"a+b = {Sum(a,b)}");

//// Case -2
//Program_10_T1.Calculate del = new Program_10_T1.Calculate(Sum);

////Program_10_T1.Calculate del = new(Sum);
////Program_10_T1.Calculate del = Sum;

//Console.WriteLine("Called the Sum method using a delegate.");
//Console.WriteLine($"a+b = {del(a,b)}");

//// del(a, b) is shorthand for del.Invoke(a,b)
//Console.WriteLine("Called the Sum method using a delegate.  Used the Invoke method directly");
//Console.WriteLine($"a+b = {del.Invoke(a,b)}");

//Calculate delegateExample = new Calculate(Sum); // Using full syntax
//Calculate delegateExample2 = new(Sum);          // Using simplified new expression
//Calculate calculateExample3 = Sum;              // Condensed Syntax


//namespace Program_10_T1
//{
//    public delegate int Calculate(int x, int y);
//}

//// 10.T2 - Multicast Delegate

//Program_10_T2.MultiDel del = Program_10_T2.Sample.DisplaySum;
//del += Program_10_T2.Sample.DisplayDifference;
//del += Program_10_T2.Sample.DisplayProduct;
//del(90, 10);

//namespace Program_10_T2
//{
//    public delegate void MultiDel(int x, int y);
//    class Sample
//    {
//        public static void DisplaySum(int a, int b) =>
//            Console.WriteLine($"Sum = {a + b}");

//        public static void DisplayDifference(int a, int b) =>
//            Console.WriteLine($"Difference = {a - b}");

//        public static void DisplayProduct(int a, int b) =>
//            Console.WriteLine($"Product = {a*b}");
//    }
//}


//// 10.T9 Func & Action Delegates
//Func<double, double, int> del = Sample.ApproximateTotal;
//Console.WriteLine($"Approximate, the sum of {10.5} and {20.7} is :{del(10.5,20.7)}");
//class Sample
//{
//    public static int ApproximateTotal(double a, double b)
//    {
//        double temp = a + b;
//        return (int)temp;
//    }
//}

//// 10.T14
//Predicate<int> isGreater = Sample.TestGreaterThan50;
//Console.WriteLine($"51 is greater than 50?{isGreater(51)}");
//Console.WriteLine($"49 is greater than 50?{isGreater(49)}");
//class Sample
//{
//    public static bool TestGreaterThan50(int input)
//    {
//        return input > 50;
//    }
//}

//// Chapter 10 Programming Skills 
//int a = 25, b = 35;
//Sample sample = new();
//CustomDelegates.MyDel1 del1 = Sample.AddFive;
//Console.WriteLine($"{a}+5+{del1(a)}");

//CustomDelegates.MyDel2 del2 = sample.AddFive;
//Console.WriteLine($"{a}+{b}+5={del2(a,b)}");

//namespace CustomDelegates
//{
//    public delegate int MyDel1(int x);
//    public delegate int MyDel2(int x, int y);
//}

//class Sample
//{
//    public static int AddFive(int a) { return a + 5; }
//    public int AddFive(int a, int b) { return a + b + 5; }
//}

//// 10.P2
//using System.Runtime.InteropServices;
//CustomDelegate.MyDel del = Sample.Sum;
//Console.WriteLine($"The sum of {10} and {20} is: {del(10,20)}");
//namespace CustomDelegate
//{
//    public delegate int MyDel(int x, int y);
//}
//class Sample
//{
//    public static int Sum(int a, int b)
//    {
//        Console.WriteLine("The Sum method of the Sample class is invoked.");
//        return a + b;
//    }
//}

//// 10.P3 Class cannot inherit from a delegate

//// 10.P4 Multicast Delegates
//Program_10_P4.MultiDel multiDel = Program_10_P4.Sample.Show1;
//multiDel += Program_10_P4.Sample.Show2;
//multiDel += Program_10_P4.Sample.Show3;
//multiDel();
//namespace Program_10_P4
//{
//    public delegate void MultiDel();
//    class Sample
//    {
//        public static void Show1()
//        {
//            Console.WriteLine("Show1() is called.");
//        }
//        public static void Show2()
//        {
//            Console.WriteLine("Show2() is called.");
//        }
//        public static void Show3()
//        {
//            Console.WriteLine($"Show3() is called.");
//        }
//    }
//}

//// 10.P5
//Action multiDel = Program_10_P5.Sample.Show1;
//multiDel += Program_10_P5.Sample.Show2;
//multiDel += Program_10_P5.Sample.Show3;
//multiDel(); 
//namespace Program_10_P5
//{
//    public delegate void MultiDel();
//    class Sample
//    {
//        public static void Show1()
//        {
//            Console.WriteLine("Show1() is called");
//        }
//        public static void Show2()
//        {
//            Console.WriteLine("Show2() is called");
//        }
//        public static void Show3()
//        {
//            Console.WriteLine("Show3() is called");
//        }
//    }
//}

//// 10.P6 Generic Delegates
//Func<double, double, int> del = Sample.Sum;
//Console.WriteLine($"Approximately, the sum of {10.5} and {20.7} is: {del(10.5,20.7)}");
//class Sample
//{
//    public static int Sum(double a, double b)
//    {
//        Console.WriteLine("The Sum method of the Sample class is invoked.");
//        double temp = a + b;
//        return (int)temp;
//    }
//}

//// 10.P7
//Func<int, int, int> del = Program_10_P7.Sample.Sum;
//del += Program_10_P7.Sample.Difference;
//int finalValue = del(10, 5);
//Console.WriteLine($"The final value is {finalValue}");

//namespace Program_10_P7
//{
//    class Sample
//    {
//        public static int Sum(int a, int b)
//        {
//            return a + b;
//        }
//        public static int Difference(int a, int b)
//        {
//            return a - b;
//        }
//    }
//}

//// 10.P8 Variance in Delegates
//Prog_10_P8.Vehicle vehicleOb = new();
//Prog_10_P8.Bus busOb = new();
//Func<Prog_10_P8.Vehicle> del = vehicleOb.CreateVehicle;
//del();
//del = busOb.CreateBus;
//del();

//namespace Prog_10_P8
//{
//    class Vehicle
//    {
//        Vehicle? vehicle;
//        public Vehicle CreateVehicle()
//        {
//            vehicle = new Vehicle();
//            Console.WriteLine("One vehicle is created.");
//            return vehicle;
//        }
//    }
//    class Bus : Vehicle
//    {
//        Bus? bus;
//        public Bus CreateBus()
//        {
//            bus = new Bus();
//            Console.WriteLine("One bus is created.");
//            return bus;
//        }
//    }
//}

//// 10.P9
//Prog_10_P9.Vehicle myVehicle = new();
//Prog_10_P9.Bus myBus = new();
//// Normal case
//Action<Prog_10_P9.Bus> del = Prog_10_P9.Bus.ShowBus;
//del(myBus);
//// Testing Contravariance
//del = Prog_10_P9.Vehicle.ShowVehicle;
//del(myBus);

//namespace Prog_10_P9
//{
//    class Vehicle
//    {
//        public static void ShowVehicle(Vehicle myVehicle)
//        {
//            Console.WriteLine("Show Vehicle is called.");
//            Console.WriteLine("This is a generic vehicle.\n");
//        }
//    }
//    class Bus : Vehicle
//    {
//        public static void ShowBus(Bus myBus)
//        {
//            Console.WriteLine("ShowBus is called");
//            Console.WriteLine("This is a bus.\n");
//        }
//    }
//}





























