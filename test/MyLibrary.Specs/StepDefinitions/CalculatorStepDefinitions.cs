namespace MyLibrary.Specs.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _result;
        private Calculator _calculator = new Calculator();

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            _firstNumber = firstNumber;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            _secondNumber = secondNumber;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add(_firstNumber, _secondNumber);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}
