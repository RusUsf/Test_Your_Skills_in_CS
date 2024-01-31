namespace PracticeCode.MyNamespaceOne;
public class MyClassOne
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public MyClassOne(string name = null, int age = 0)
    {
        Name = name;
        Age = age;
    }

    public static void ShowInfo(string name = null, int age = 0)
    {
        Console.WriteLine($"Name of MyClassOne is :{name} and age:{age}");
    }


}
public class Sample
{
    public static int UseLambdaForSum(int x, int y)
    {
        Func<int, int, int> sumLambda = (a, b) => a + b;
        return sumLambda(x, y);
    }

    public delegate int Mydel(int x, int y);
    public static int Sum(int x, int y)
    {
        return x + y;
    }

    public static bool IsPositive(int x) => x > 0;

}
public class GenericEventHandler<T>
{
    public delegate void DataChangedDelegate(object sender, T data);
    public event DataChangedDelegate DataChanged;

    public void OnDataChanged(T data)
    {
        DataChanged?.Invoke(this, data);
    }
}

public class Sample2
{
    public static bool IsPositive(int x) => x > 0;
}

public class LambdaOne
{

    public static string NoParameterLambda() => "Hello World!";
    public static int OneParameterLambda(int x) => x * x;
    public static void MultpipleExpressionLambda(int x, int y)
    {
        Action<int, int> del3 = (int x, int y) =>
            {
                int sum = x + y;
                Console.WriteLine($"The sum of {x} and {y} is {sum}");
            };

        del3(x, y);
    }
}

public class Test
{
    public int CalculateSum1(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    public int CalculateSum2(int a, int b) => a + b;
}

public class Employee
{
    readonly int empId = 0;
    readonly string company = "XYZ Company";
    string name = string.Empty;
    public Employee(int id) => empId = id;
    public string Company => company;
    public string Name
    {
        get => name;
        set => name = value;
    }
    public int Id
    {
        get => empId;
    }
}

public class SampleClass
{
    internal delegate Tuple<int,double> DoubleMaker(Tuple<int,double> input);
    static internal Tuple<int, double> MakeDouble(Tuple<int, double> input)
    {
        return Tuple.Create(input.Item1 * 2, input.Item2 * 2);
    }
}