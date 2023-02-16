namespace SpecFlowSessionExample.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _scenarioContext.Add("firstNumber", number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _scenarioContext.Add("secondNumber", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _scenarioContext.Add("expression", "+");
        }

        [When(@"the second is subtracted from first")]
        public void WhenTheSecondIsSubtractedFromFirst()
        {
            _scenarioContext.Add("expression", "-");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            switch (_scenarioContext.Get<string>("expression"))
            {
                case "+":
                    Assert.Equal(result, _scenarioContext.Get<int>("firstNumber") + _scenarioContext.Get<int>("secondNumber"));
                    break;

                case "-":
                    Assert.Equal(result, _scenarioContext.Get<int>("firstNumber") - _scenarioContext.Get<int>("secondNumber"));
                    break;

                case "*":
                    Assert.Equal(result, _scenarioContext.Get<int>("firstNumber") * _scenarioContext.Get<int>("secondNumber"));
                    break;

                case "/":
                    Assert.Equal(result, _scenarioContext.Get<int>("firstNumber") / _scenarioContext.Get<int>("secondNumber"));
                    break;

                default:
                    throw new InvalidOperationException("Invalid Expression");
            }
        }
    }
}