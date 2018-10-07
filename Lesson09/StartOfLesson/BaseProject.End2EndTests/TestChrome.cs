using System.IO;
using System.Reflection;
using BaseProject.Models;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace BaseProject.End2EndTests
{
    public class TestChrome
    {
        [Fact]
        public void PageLoads()
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"https://localhost:5000");
                var link = driver.FindElementByXPath("//body/nav/div/div/a");
                Assert.Contains("E2E", link.Text);
            }
        }

        [Fact]
        public void CreatingNewIssueSavesCorrectly()
        {
            var data = new
            {
                Title = "Issue",
                Description = "Fix all the bugs",
                Status = IssueStatus.Done

            };

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"https://localhost:5000");
                var CreateNewLink = driver.FindElementByLinkText("Create New");
                Assert.Contains("Create New", CreateNewLink.Text);
                CreateNewLink.Click();
                Assert.Equal(@"https://localhost:5000/Issue/Create", driver.Url);
                var titleInput = driver.FindElementById("Title");
                titleInput.SendKeys(data.Title);   
                var descriptionInput = driver.FindElementById("Description");
                descriptionInput.SendKeys(data.Description);
                var statusSelect = driver.FindElementById("Status");
                var selectElement = new SelectElement(statusSelect);
                selectElement.SelectByValue($"{(int)data.Status}");
                var createButton = driver.FindElementByCssSelector("input.btn.btn-default");
                Assert.Equal("Create", createButton.GetAttribute("value"));
                createButton.Click();
                Assert.Equal(@"https://localhost:5000/Issue", driver.Url);
                var savedtitleInput = driver.FindElementById("Title");
                savedtitleInput.SendKeys(data.Title);

            }
        }
    }
}
