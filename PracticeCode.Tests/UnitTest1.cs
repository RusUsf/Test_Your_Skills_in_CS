using PracticeCode.MyNamespaceOne;
using static PracticeCode.MyNamespaceOne.Sample;

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
}