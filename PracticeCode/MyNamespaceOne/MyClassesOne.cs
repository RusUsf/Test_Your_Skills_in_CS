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