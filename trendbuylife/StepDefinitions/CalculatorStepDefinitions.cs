using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using trendbuylife.ComponentHelper;
using trendbuylife.Drivers;

namespace trendbuylife.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        static public IWebDriver Driver;
        static public EdgeDriver driver = new EdgeDriver();
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            NavigationHelper.NavigateToUrl();

        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            
        }
    }
}