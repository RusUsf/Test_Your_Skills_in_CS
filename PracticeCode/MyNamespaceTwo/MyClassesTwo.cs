namespace PracticeCode.MyNamespaceTwo;
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

    public class FinancialCalculations
    {
        public static decimal DecimalCalculation(decimal amount, int divisor)
        {
            return amount / divisor;
        }

        public static double DoubleCalculation(double amount, int divsor)
        {
            return amount / divsor;
        }

        public static float FloatCalculation(float amount, int divsor)
        {
            return amount / divsor  ;
        }
    }

    public interface IPaymentProcessor
    {
        bool ProceessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public bool ProceessPayment(decimal amount)
        {
            return amount > 0;
        }
    }
}

