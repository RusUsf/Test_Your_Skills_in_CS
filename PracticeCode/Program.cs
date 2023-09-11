//using PracticeCode.MyNamespaceOne;
//using PracticeCode.MyNamespaceTwo;


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
//foreach (var i in list)
//{
//    Console.WriteLine("\t" + i);
//}

//Console.WriteLine("Executing the 'for' loop:");
//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine("\t" + list[i]);
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
//flag9++;
//Console.WriteLine($"Post increment, the flag is: {flag9}"); // Overflow no exception by default can be enabled globally

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
//    i++ ;
//}

//for (int j = 0; j < 3; j++)
//{
//    Console.WriteLine($"The current value: {j}");
//}

//// 1.P18 Increment by 3
//for(int k=0; k < 8; k += 3)
//{
//    Console.WriteLine($"The curent value: {k}");
//}

// CAUTION: Infinite loop, not bool or null is not allowed in while() statement

//// goto statement
//int flag30 = 1;
//while(flag30 != 3)
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
//    if(myInt10 == 4)
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

//List<object> myList20 = new List<object> { myInt20, myInt21,myInt22,myInt23,myChar20,myString20 };
//foreach (var item in myList20)
//{
//    Console.Write(item.GetType()+", ");
//}
















































