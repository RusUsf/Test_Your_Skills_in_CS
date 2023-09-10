using PracticeCode.MyNamespaceOne;
using PracticeCode.MyNamespaceTwo;


// 1.T13 Decimal vs double vs float in finances
var b = 6;
decimal flag1 = (decimal)10.0 / b;
double flag2 = 10.0 / b;
float flag3 = (float)10.0 / b;

Console.WriteLine(flag1);
Console.WriteLine(flag2);
Console.WriteLine(flag3);

var flag5 = false;
flag3 = flag3 + 3;
flag1 = flag1 + 6;

//1.T14 conditional operator is right-associative (evaluated from right to left)
var c = b == 6 ? (int)flag3 : flag5 ? (int)flag3 : (int)flag1;
Console.WriteLine(c);
var c1 = b > 6 ? (int)flag3 : (flag5 ? (int)flag3 : (int)flag1);
Console.WriteLine(c1);

// 1.T16 While and do-While loop
Console.WriteLine("Illustration: do-while loop");
int j = 1;
do
{
    Console.WriteLine($"Inside loop: j is now {j}");
    j++;
} while (j < 1);
Console.WriteLine($"Outside loop: j's value is {j}");

// 1.T17 What is a foreach loop?
string text = "hello";
Console.WriteLine($"The string \"hello\" contains the following characters: ");
foreach (var x in text) Console.WriteLine(x);

// For vs Foreach loop
List<int> list = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine("Executing the 'foreach' loop:");
foreach (var i in list)
{
    Console.WriteLine("\t" + i);
}

Console.WriteLine("Executing the 'for' loop:");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine("\t"+list[i]);
}


// 1.P1 Same names for the Class in the different namespaces
PracticeCode.MyNamespaceOne.MyClassOne myClassOne = new PracticeCode.MyNamespaceOne.MyClassOne(name:"Celebrate small accomplishments!",age:37);
PracticeCode.MyNamespaceTwo.MyClassOne myClassTwo = new PracticeCode.MyNamespaceTwo.MyClassOne(age:27,name:"Get over disappointments quickly!");
PracticeCode.MyNamespaceOne.MyClassOne.ShowInfo(myClassOne.Name, myClassOne.Age);
PracticeCode.MyNamespaceTwo.MyClassOne.ShowInfo(myClassTwo.Name, myClassTwo.Age);



















