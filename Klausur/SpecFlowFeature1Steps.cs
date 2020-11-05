using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Klausur
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double rd, result;

        [Given(@"the radian is Pi")]
        public void GivenTheRadianIsPi()
        {
            rd = Math.PI;
        }

        [When(@"the sine is clicked")]
        public void WhenTheSineIsClicked()
        {
            result = Math.Sin(rd);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            var expected = p0;
            var actual = result;
            Assert.Equal(expected, actual, 5);
        }

        [When(@"the cosine is clicked")]
        public void WhenTheCosineIsClicked()
        {
            result = Math.Cos(rd);
        }

        [When(@"the tangens is clicked")]
        public void WhenTheTangensIsClicked()
        {
            result = Math.Tan(rd);
        }
    }
}