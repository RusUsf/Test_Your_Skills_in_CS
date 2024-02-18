using PracticeCode.MyNamespaceOne;
using static PracticeCode.MyNamespaceOne.Sample;
using static PracticeCode.MyNamespaceTwo.MyClassOne;

namespace PracticeCode.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestSumUsingDelegate()
    {
        Func<int, int, int> del = Sample.Sum;
        var result = del(10, 5);
        result.Should().Be(15);
    }

    [Test]
    public void TestSumUsingAnonymousMethod()
    {
        Sample.Mydel del = delegate (int x, int y) { return x + y; };
        var result = del(10, 5);
        result.Should().Be(15);
    }

    [Test]
    public void TestSumUsingLambdaInSampleClass()
    {
        var result = Sample.UseLambdaForSum(10, 5);
        result.Should().Be(15);
    }

    [Test]
    public void ShouldTriggerEventWhenDataChanges()
    {
        var eventHandler = new GenericEventHandler<string>();
        var eventTriggred = false;
        var eventData = string.Empty;

        eventHandler.DataChanged += (sender, data) =>
        {
            eventTriggred = true;
            eventData = data;
        };

        eventHandler.OnDataChanged("Hello World");

        eventTriggred.Should().BeTrue();
        eventData.Should().Be("Hello World");
    }

    [Test]
    public void ShouldReturnTrueIfPositive()
    {
        var result = Sample.IsPositive(-5);
        result.Should().BeFalse();
    }

    [Test]
    public void ShouldReturnFalseIfNegativeLambda()
    {
        var result = Sample2.IsPositive(5);
        result.Should().BeTrue();
    }

    [Test]
    public void ShouldReturnHelloWorld()
    {
        // Arrange: 
        var expected = "Hello World!";

        // Act:
        string result = LambdaOne.NoParameterLambda();

        // Assert:
        result.Should().Be(expected);
    }

    [Test]
    public void ShouldReturnSquare()
    {
        // Arrange:
        var expected = 4;
        // Act:
        int result = LambdaOne.OneParameterLambda(2);
        // Assert:
        result.Should().Be(expected);
    }

    [Test]
    public void ShouldReturnSum1()
    {
        // Arrange:
        Test test = new();
        var expected = 15;
        // Act:
        int result = test.CalculateSum1(5, 10);
        // Assert:
        result.Should().Be(expected);
    }

    [Test]
    public void ShouldReturnSum2()
    {
        // Arrange:
        Test test = new();
        var expected = 125;
        // Act:
        int result = test.CalculateSum2(25, 100);
        // Assert:
        result.Should().Be(expected);
    }

    [Test]
    public void ShouldReturnEmployee()
    {
        // Ararnge:
        Employee emp = new(1);
        emp.Name = "Kevin Turner";
        var expectedName = "Kevin Turner";
        var expectedId = 1;
        var expectedCompanyName = "XYZ Company";
        // Act:
        var resultName = emp.Name;
        var resultId = emp.Id;
        var resultCompanyName = emp.Company;
        // Assert:
        resultName.Should().Be(expectedName);
        resultId.Should().Be(expectedId);
        resultCompanyName.Should().Be(expectedCompanyName);
    }

    [Test]
    public void DecimalCalculation_ShouldBePrecies()
    {
        // Arrange
        var b = 6;
        var expectedValue = (decimal)10.0 / b;

        // Act
        var actualValue = FinancialCalculations.DecimalCalculation(10.0m, b);

        // Assert
        actualValue.Should().Be(expectedValue);
    }

    [Test]
    public void DoubleCalculation_ShouldBeApproximate()
    {
        // Arrange
        var b = 6;
        var expectedValue = 10.0 / b;

        // Act
        var actualValue = FinancialCalculations.DoubleCalculation(10.0, b);

        // Assert
        actualValue.Should().BeApproximately(expectedValue, 0.0001);
    }

    [Test]
    public void FloatCalculation_ShouldBeApproximate()
    {
        //Arrange
        var b = 6;
        var expectedValue = (float)10.0 / b;

        // Act
        var actualValue = FinancialCalculations.FloatCalculation(10.0f, b);

        // Assert
        actualValue.Should().BeApproximately(expectedValue, 0.0001f);
    }

    [Test]
    public void ProcessPayment_WithPositiveAmount_ShouldReturnTrue()
    {
        // Arrange
        IPaymentProcessor paymentProcessor = new CreditCardProcessor();
        decimal paymentAmount = 100m;

        // Act
        bool result = paymentProcessor.ProceessPayment(paymentAmount);

        // Assert
        result.Should().BeTrue();
    }

    [Test]
    public void ProcessPayment_WithNegativeAmount_ShouldReturnFalse()
    {
        // Arrange
        IPaymentProcessor paymentProcessor = new CreditCardProcessor();
        decimal paymentAmount = -100m;

        // Act
        bool result = paymentProcessor.ProceessPayment(paymentAmount);

        // Assert
        result.Should().BeFalse();
    }
}


















