using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace TestProject1.Steps.Web
{
    [Binding]
    public class NewbeWeb
    {
        private readonly TestData _testData;
        private readonly IWebDriver _driver;

        public NewbeWeb(
            TestData testData,
            MyWebDriver driver)
        {
            _testData = testData;
            _driver = driver;
        }

        [Given("打开必应首页 \"(.*)\"")]
        public void Hehe1(string url)
        {
            _testData.BaseUrl = url;
            _driver.Url = url;
        }

        [When("搜索框输入内容 \"(.*)\"")]
        public void Hehe2(string keyword)
        {
            _driver.FindElement(By.Id("sb_form_q")).SendKeys(keyword);
        }

        [When("点击搜索按钮")]
        public void Hehe3()
        {
            _driver.FindElement(By.Id("sb_form_go")).Click();
        }

        [Then("出现在必应搜索第一条的标题是 \"(.*)\"")]
        public void Hehe4(string title)
        {
            var titleEl = _driver.FindElements(By.CssSelector(("li.b_algo")))[0].FindElement(By.TagName("h2"));
            titleEl.Text.Should().Be(title);
        }
    }

    public class TestData
    {
        public string BaseUrl { get; set; }
        public string Keyword { get; set; }
        public string Title { get; set; }
    }

    public class MyWebDriver : ChromeDriver
    {
        public MyWebDriver()
        {
        }
    }
}