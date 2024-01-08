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