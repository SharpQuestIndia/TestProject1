using System;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public class Test1Steps : Drivers
    {
        [Given(@"app is open")]
        public void GivenAppIsOpen()
        {
            NUnit.Framework.Assert.Pass();
        }
        
        [Then(@"I should see the first segment")]
        public void ThenIShouldSeeTheFirstSegment()
        {
            if (appiumDriver.FindElementById("com.example.myapplication:id/textview_first").Displayed)
            {
                NUnit.Framework.Assert.Pass();
            }
            else
            {
                NUnit.Framework.Assert.Fail();
            }
        }
    }
}
