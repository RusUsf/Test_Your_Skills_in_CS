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


