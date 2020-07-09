using NUnit.Framework;
using OpenQA.Selenium;
using Project_MARS.Specflow.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_MARS.Specflow.Pages
{ 
 class SignIn : Drivers
{
    public static void Login(String username, String password)
    {
        //Clicking SignIn button
        driver.FindElement(By.XPath("//a[@class='item']")).Click();

        //Enter Username
        driver.FindElement(By.XPath("//input[@placeholder='Email address']")).SendKeys(username);

        //Enter Password
        driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(password);

        //Clicking Login Button
        driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();

    }

    public static void LoginPageValidation()
    {
        WaitHelpers.waitClickableElement(driver, "XPath", "//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]");
        Assert.That(driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]")).Text, Is.EqualTo("Profile"));
        Assert.Pass();
    }
}
}
