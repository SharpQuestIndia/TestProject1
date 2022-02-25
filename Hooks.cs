using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using BoDi;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public sealed class Hooks : Drivers
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            DriverOptions caps = new AppiumOptions();
            caps.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            caps.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\Haresh\\AndroidStudioProjects\\MyApplication2\\app\\build\\outputs\\apk\\debug\\app-debug.apk");
            caps.AddAdditionalCapability("automationName", "UiAutomator2");
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumDriver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), caps);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
