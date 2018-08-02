using BaseProject.Intrastructure;
using FluentAssertions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Linq;

namespace BaseProject.Test.TagHelpers
{
    public class MyMockedB : IDateTimeProvider
    {
        public DateTime Now { get; set; }
    }
    public class TestForBold
    {
        [Fact]
        public void TagHelper_ShouldShowBoldCurrnetDayOfWeek()
        {
            var now = DateTime.Now;
            foreach (var day in Enumerable.Range(0, 6).Select(i => now.AddDays(i)))
            {
                // Assemble
                //Start on current day
                var mockDateTimeProvider = new MyMockedDateTimeProvider();
                mockDateTimeProvider.Now = day;

                TagHelper myTagHelper = new DayOfTheWeekTagHelper(mockDateTimeProvider);
                TagHelperContext context = null;
                TagHelperOutput output = new TagHelperOutput(
                "day-of-week",
                new TagHelperAttributeList(),
                (useCachedResult, encoder) =>
                {
                    var tagHelperContent = new DefaultTagHelperContent();
                    tagHelperContent.SetContent(string.Empty);
                    return Task.FromResult<TagHelperContent>(tagHelperContent);
                }
                );


                // Act
                myTagHelper.Process(context, output);

                // Assert
                //show current day
                var content = output.Content.GetContent();
                System.Diagnostics.Debug.WriteLine("test this out");
                Assert.Equal("b",output.TagName);
            }
        }
    }
}
