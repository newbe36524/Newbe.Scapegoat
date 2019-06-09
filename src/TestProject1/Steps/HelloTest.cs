using FluentAssertions;
using TechTalk.SpecFlow;
using Xunit;

namespace TestProject1.Steps
{
    [Binding]
    public class HelloTest
    {
        private readonly CalculatorData _calculatorData;

        public HelloTest(
            CalculatorData calculatorData)
        {
            _calculatorData = calculatorData;
        }

        [Given("I have entered (.*) into the calculator")]
        public void Hehe1(int p0)
        {
            _calculatorData.A = p0;
        }

        [Given("I have also entered (.*) into the calculator")]
        public void Hehe2(int p0)
        {
            _calculatorData.B = p0;
        }

        [When("I press add")]
        public void Hehe3()
        {
            _calculatorData.Result = _calculatorData.A + _calculatorData.B;
        }

        [Then("the result should be (.*) on the screen")]
        public void Hehe4(int p0)
        {
            _calculatorData.Result.Should().Be(_calculatorData.A + _calculatorData.B);
        }
    }

    public class CalculatorData
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Result { get; set; }
    }
}