namespace MyA1Web.Tests
{
    using System;
    using Xunit;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using MyA1Web.Common;
    using OpenQA.Selenium.Interactions;
    public class ChromeTests : IDisposable
    {
        ////WebDriver
        private static IWebDriver chromeDriver;

        public ChromeTests()
        {
            chromeDriver = new ChromeDriver(ChromeConstants.path);
            //chromeDriver = new ChromeDriver();
        }

        public void Dispose()
        {
            chromeDriver.Close();
            chromeDriver.Quit();
        }

        [Fact]
        public void SearchOntheMainPage()
        {
            NavigateToURL();

            ClickByClassName(ChromeConstants.closeClassName);

            WaitSpecificTimeoutMethod(ChromeConstants.smallTimeout);
            ClickByXPath(ChromeConstants.mainPageSearching);

            chromeDriver.FindElement(By.Id(ChromeConstants.fieldSearchID)).SendKeys("Huawei P10 Lite");

            ClickByID(ChromeConstants.btnGoogleSearchSubmitID);

            WaitElementXPathMethod(ChromeConstants.searchingResult, ChromeConstants.smallMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.searchingResult)).Text == ChromeConstants.searchingResultExpected ? "Current searching page loaded successfully!" : "Current searching page not loaded successfully!";
            Assert.Equal("Current searching page loaded successfully!", actual);
        }

        [Fact]
        public void LoadBillsAndInvoicesPage()
        {
            LoginByClickingOnMyA1();
            ClickByXPath(ChromeConstants.billsInvoicesTabXPath);

            string actual = WaitElementXPathMethod(ChromeConstants.btnDetailsBillsInvoicesXPath, ChromeConstants.bigTimeout) ? "My invoice page loaded successfully!" : "My invoice page not loaded successfully!";
            Assert.Equal("My invoice page loaded successfully!", actual);
        }

        [Fact]
        public void LoadBillsAndInvoicesSentToEmailPage()
        {
            LoginByClickingOnMyA1();
            ClickByXPath(ChromeConstants.billsInvoicesTabXPath);

            ClickByXPath(ChromeConstants.btnSeeMoreInvoiceEmailXPath);

            WaitElementXPathMethod(ChromeConstants.invoiceToEmailPageXPath, ChromeConstants.smallMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.invoiceToEmailPageXPath)).Text == ChromeConstants.pageInvoiceToEmailExpected ? "Current InvoiceToEmail page loaded successfully!" : "Current InvoiceToEmail page not loaded successfully!";
            Assert.Equal("Current InvoiceToEmail page loaded successfully!", actual);

        }

        [Fact]
        public void SearchOntheMainPageAfterLogin()
        {
            LoginByClickingOnMyA1();

            WaitSpecificTimeoutMethod(ChromeConstants.smallTimeout);
            ClickByXPath(ChromeConstants.topLinkSearch);

            chromeDriver.FindElement(By.Id(ChromeConstants.fieldSearchID)).SendKeys("Huawei P10 Lite");

            ClickByID(ChromeConstants.btnGoogleSearchSubmitID);

            WaitElementXPathMethod(ChromeConstants.searchingResult, ChromeConstants.smallMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.searchingResult)).Text == ChromeConstants.searchingResultExpected ? "Current searching page loaded successfully!" : "Current searching page not loaded successfully!";
            Assert.Equal("Current searching page loaded successfully!", actual);
        }

        [Fact]
        public void MainPageLoadTableCurrentUsage()
        {
            LoginByClickingOnMyA1();

            WaitElementXPathMethod(ChromeConstants.tableMainCurrentUsageXPath, ChromeConstants.smallMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.tableMainCurrentUsageXPath)).Text == ChromeConstants.currentUsageExpected ? "Current usage main page loaded successfully!" : "Current usage main page not loaded successfully!";
            Assert.Equal("Current usage main page loaded successfully!", actual);
        }

        [Fact]
        public void MainPageLoadTableCurrentDebt()  //da hvanem po ЛВ, Ne po  задължения!!!
        {
            LoginByClickingOnMyA1();

            WaitElementXPathMethod(ChromeConstants.tableCurrentDebtXPath, ChromeConstants.smallMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.tableCurrentDebtXPath)).Text == ChromeConstants.currentDebtExpected ? "Current bill page loaded successfully!" : "Current bill page not loaded successfully!";
            Assert.Equal("Current bill page loaded successfully!", actual);
        }

        [Fact]
        public void MainPageLoadShortServiceDetail()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.mainPageServiceDetailOpen);

            WaitElementXPathMethod(ChromeConstants.mainPageTableShortdetail, ChromeConstants.smallMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.mainPageTableShortdetail)).Text == ChromeConstants.mobileDataMaxSpeedExpected ? "Current usage page loaded successfully!" : "Current usage page not loaded successfully!";
            Assert.Equal("Current usage page loaded successfully!", actual);
        }

        [Fact]
        public void MainPageLoadServiceDetailCurrentBill()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.mainPageServiceDetailOpen);

            WaitElementXPathMethod(ChromeConstants.mainPageTableCurrentBill, ChromeConstants.smallMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.mainPageTableCurrentBill)).Text == ChromeConstants.currentBillTableExpected ? "Current bill page loaded successfully!" : "Current bill page not loaded successfully!";
            Assert.Equal("Current bill page loaded successfully!", actual);
        }

        [Fact]
        public void LoadDetailPlanCheckTablePlan()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.mainPageServiceDetailOpen);
            ClickByXPath(ChromeConstants.btnPlanDetails);

            WaitElementXPathMethod(ChromeConstants.serviceDetailTablePlan, ChromeConstants.bigMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.serviceDetailTablePlan)).Text == ChromeConstants.detailPlanExpected ? "My plan page loaded successfully!" : "My plan page not loaded successfully!";
            Assert.Equal("My plan page loaded successfully!", actual);

        }

        [Fact]
        public void LoadDetailPlanCheckTableOtherServices()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.mainPageServiceDetailOpen);
            ClickByXPath(ChromeConstants.btnPlanDetails);

            WaitElementXPathMethod(ChromeConstants.serviceDetailTableOtherServices, ChromeConstants.bigMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.serviceDetailTableOtherServices)).Text == ChromeConstants.detailPlanFavoriteNumberExpected ? "My other services page loaded successfully!" : "My other services page not loaded successfully!";
            Assert.Equal("My other services page loaded successfully!", actual);

        }

        [Fact]
        public void LoadDetailPlanCheckTableRoaming()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.mainPageServiceDetailOpen);
            ClickByXPath(ChromeConstants.btnPlanDetails);

            WaitElementXPathMethod(ChromeConstants.serviceDetailTableRoaming, ChromeConstants.bigMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.serviceDetailTableRoaming)).Text == ChromeConstants.detailPlanRoamingExpected ? "My roaming page loaded successfully!" : "My roaming page not loaded successfully!";
            Assert.Equal("My roaming page loaded successfully!", actual);

        }

        [Fact]
        public void LoadSimSettings()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.mainPageServiceDetailOpen);
            ClickByXPath(ChromeConstants.btnPlanDetails);
            ClickByXPath(ChromeConstants.btnSimSettings);

            WaitElementXPathMethod(ChromeConstants.simSettingtableCLIR, ChromeConstants.bigMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.simSettingtableCLIR)).Text == ChromeConstants.detailsSimSettingsExpected ? "My SIM settings page loaded successfully!" : "My SIM settings page not loaded successfully!";
            Assert.Equal("My SIM settings page loaded successfully!", actual);
        }

        [Fact]
        public void LoadServiceExtras()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.mainPageServiceDetailOpen);
            ClickByXPath(ChromeConstants.btnPlanDetails);
            ClickByXPath(ChromeConstants.btnManageExtras);

            WaitElementXPathMethod(ChromeConstants.manageExtrasPage, ChromeConstants.bigMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.manageExtrasPage)).Text == ChromeConstants.detailsExtraPageExpected ? "My service extras page loaded successfully!" : "My service extras page not loaded successfully!";
            Assert.Equal("My service extras page loaded successfully!", actual);
        }

        [Fact]
        public void LoadServiceRoaming()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.mainPageServiceDetailOpen);
            ClickByXPath(ChromeConstants.btnPlanDetails);

            ClickByXPath(ChromeConstants.btnServiceRoaming);

            WaitElementXPathMethod(ChromeConstants.slideTableRoamingXPath, ChromeConstants.bigTimeout);
            SlideByXPath(ChromeConstants.slideTableRoamingXPath, ChromeConstants.right);

            WaitElementXPathMethod(ChromeConstants.tableRoamingDetails, ChromeConstants.bigTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.tableRoamingDetails)).Text == ChromeConstants.detailsRoamingInfoExpected ? "My service roaming page loaded successfully!" : "My service roaming page not loaded successfully!";
            Assert.Equal("My service roaming page loaded successfully!", actual);

            WaitElementXPathMethod(ChromeConstants.slideTableRoamingXPath, ChromeConstants.bigTimeout);
            SlideByXPath(ChromeConstants.slideTableRoamingXPath, ChromeConstants.left);

            string actualBack = !WaitElementXPathMethod(ChromeConstants.tableRoamingDetails, ChromeConstants.bigTimeout) ? "My service roaming page loaded successfully!" : "My service roaming page not loaded successfully!";
            Assert.Equal("My service roaming page not loaded successfully!", actualBack);


        }

        [Fact]
        public void LoadPageMyServices()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.menuMyServicesXPath);
            ClickByXPath(ChromeConstants.myServiceDetailsOpenXPath);

            WaitElementXPathMethod(ChromeConstants.myServiceDetailsListedStatusXPath, ChromeConstants.bigMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.myServiceDetailsListedStatusXPath)).Text == ChromeConstants.activeExpected ? "My services page loaded successfully!" : "My services page not loaded successfully!";
            Assert.Equal("My services page loaded successfully!", actual);

        }

        [Fact]
        public void LoadPageMyServicesContracts()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.menuMyServicesXPath);
            ClickByXPath(ChromeConstants.menuContractXPath);

            WaitElementXPathMethod(ChromeConstants.menuContractTableXPath, ChromeConstants.bigMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.menuContractTableXPath)).Text == ChromeConstants.tableContractExpeted ? "My services page loaded successfully!" : "My services page not loaded successfully!";
            Assert.Equal("My services page loaded successfully!", actual);

        }

        [Fact]
        public void LoadIncreaseMyCreditLimit()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.menuMyServicesXPath);

            ClickByXPath(ChromeConstants.myServiceDetailsOpenXPath);

            ClickByXPath(ChromeConstants.manageCreditLimitXPath);

            WaitElementXPathMethod(ChromeConstants.increaseCreditLimitPageXPath, ChromeConstants.bigMediumTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.increaseCreditLimitPageXPath)).Text == ChromeConstants.increaseCreditLimitExpected ? "Increase credit limit page loaded successfully!" : "Increase credit limit page not loaded successfully!";
            Assert.Equal("Increase credit limit page loaded successfully!", actual);

        }

        [Fact]
        public void LoadMainPage()
        {
            NavigateToURL();

            ClickByClassName(ChromeConstants.closeClassName);

            WaitElementXPathMethod(ChromeConstants.privateClients, ChromeConstants.smallTimeout);
            string actual = chromeDriver.FindElement(By.XPath(ChromeConstants.privateClients)).Text == ChromeConstants.privateExpected ? "Main page loaded successfully!" : "Main page not loaded successfully!";
            Assert.Equal("Main page loaded successfully!", actual);
        }

        [Fact]
        public void MyProfilePersonalData()
        {
            LoginByClickingOnMyA1();

            ClickByXPath(ChromeConstants.myProfileXPath);
            ClickByXPath(ChromeConstants.myProfilePersonalDataXPath);

            bool usernameFieldPresent = WaitElementIDMethod(ChromeConstants.fieldUsernameID, ChromeConstants.biggerTimeout);
            bool emailFieldPresent = WaitElementIDMethod(ChromeConstants.fieldEmailID, ChromeConstants.biggerTimeout);

            string actual = usernameFieldPresent && emailFieldPresent ? "Personal data page loaded successfully!" : "Personal data page not loaded successfully!";

            Assert.Equal("Personal data page loaded successfully!", actual);
        }
        [Fact]
        public void MyProfileMyAddresses()
        {
            LoginByClickingOnMyA1();
            ClickByXPath(ChromeConstants.myProfileXPath);
            ClickByXPath(ChromeConstants.myProfileAddressXPath);

            bool cityColumnPresent = WaitElementXPathMethod(ChromeConstants.addressCityColumnXPath, ChromeConstants.biggerTimeout);
            string columnText = chromeDriver.FindElement(By.XPath(ChromeConstants.addressCityColumnXPath)).Text;

            string actual = cityColumnPresent && columnText == ChromeConstants.locationExpected ? "Addresses info page loaded successfully!" : "Addresses info page not loaded successfully!";

            Assert.Equal("Addresses info page loaded successfully!", actual);
        }

        [Fact]
        public void MyProfileChangePassword()
        {
            LoginByClickingOnMyA1();
            ClickByXPath(ChromeConstants.myProfileXPath);
            ClickByXPath(ChromeConstants.myProfilePassXPath);

            bool oldPassFieldPresent = WaitElementNameMethod(ChromeConstants.oldPasswordName, ChromeConstants.biggerTimeout);
            bool newPassFieldPresent = WaitElementNameMethod(ChromeConstants.newPasswordName, ChromeConstants.biggerTimeout);

            string actual = oldPassFieldPresent && newPassFieldPresent ? "Password change page loaded successfully!" : "Password change page not loaded successfully!";

            Assert.Equal("Password change page loaded successfully!", actual);
        }

        [Fact]
        public void MyProfileSecurityCode()
        {
            LoginByClickingOnMyA1();
            ClickByXPath(ChromeConstants.myProfileXPath);
            ClickByXPath(ChromeConstants.myProfileCodePath);

            bool usernameFieldPresent = WaitElementXPathMethod(ChromeConstants.securityCodeColumnXPath, ChromeConstants.biggerTimeout);

            string columnText = chromeDriver.FindElement(By.XPath(ChromeConstants.securityCodeColumnXPath)).Text;

            string actual = usernameFieldPresent && columnText == ChromeConstants.companyOrNameExpected ? "Generate security code page loaded successfully!" : "Generate security code page not loaded successfully!";

            Assert.Equal("Generate security code page loaded successfully!", actual);
        }

        [Fact]
        public void MyProfileOrdersHistory()
        {
            LoginByClickingOnMyA1();
            ClickByXPath(ChromeConstants.myProfileXPath);
            ClickByXPath(ChromeConstants.myProfileHistoryPath);

            bool usernameFieldPresent = WaitElementXPathMethod(ChromeConstants.historyDescriptionColumnXPath, ChromeConstants.biggerTimeout);

            string columnText = chromeDriver.FindElement(By.XPath(ChromeConstants.historyDescriptionColumnXPath)).Text;

            string actual = usernameFieldPresent && columnText == ChromeConstants.descriptionExpected ? "Order history page loaded successfully!" : "Order history page not loaded successfully!";

            Assert.Equal("Order history page loaded successfully!", actual);
        }


        //LoginMethods
        private void LoginByClickingOnMyA1()
        {
            NavigateToURL();
            ClickByClassName(ChromeConstants.closeClassName);

            ClickByXPath(ChromeConstants.myA1link);

            WaitElementIDMethod(ChromeConstants.fieldUsernameID, ChromeConstants.smallMediumTimeout);
            chromeDriver.FindElement(By.Id(ChromeConstants.fieldUsernameID)).SendKeys(ChromeConstants.UserName);
            chromeDriver.FindElement(By.Id(ChromeConstants.fieldPasswordID)).SendKeys(ChromeConstants.Password);
            ClickByName(ChromeConstants.loginBtnName);
        }



        private void LoginByClickingOnMyBill()
        {
            NavigateToURL();

            ClickByClassName(ChromeConstants.closeClassName);

            ClickByXPath(ChromeConstants.mainPageCurrentBill);

            WaitElementIDMethod(ChromeConstants.fieldUsernameID, ChromeConstants.biggerTimeout);
            chromeDriver.FindElement(By.Id(ChromeConstants.fieldUsernameID)).SendKeys(ChromeConstants.UserName);
            chromeDriver.FindElement(By.Id(ChromeConstants.fieldPasswordID)).SendKeys(ChromeConstants.Password);
            ClickByName(ChromeConstants.loginBtnName);
        }
        //Wait methods - ID, Xpath and specific timeout
        private void ClickByXPath(string xpath)
        {
            WaitElementXPathMethod(xpath, ChromeConstants.bigTimeout);
            chromeDriver.FindElement(By.XPath(xpath)).Click();
        }
        private void ClickByID(string id)
        {
            WaitElementIDMethod(id, ChromeConstants.bigTimeout);
            chromeDriver.FindElement(By.Id(id)).Click();
        }
        private void ClickByClassName(string className)
        {
            WaitElementClassNameMethod(className, ChromeConstants.bigTimeout);
            chromeDriver.FindElement(By.ClassName(className)).Click();
        }
        private void ClickByName(string name)
        {
            WaitElementNameMethod(name, ChromeConstants.bigTimeout);
            chromeDriver.FindElement(By.Name(name)).Click();
        }
        private bool WaitElementIDMethod(string elementId, int timeToWait)
        {
            DateTime currentTime = DateTime.UtcNow;
            DateTime targetTime = currentTime.AddSeconds(timeToWait);

            while (true)
            {
                try
                {
                    chromeDriver.FindElement(By.Id(elementId));
                    WaitSpecificTimeoutMethod(ChromeConstants.ultraSmallTimeout);
                    return true;
                }
                catch (Exception)
                {
                    if (DateTime.UtcNow >= targetTime)
                    {
                        return false;
                    }
                }
            }
        }
        private bool WaitElementClassNameMethod(string className, int timeToWait)
        {
            DateTime currentTime = DateTime.UtcNow;
            DateTime targetTime = currentTime.AddSeconds(timeToWait);

            while (true)
            {
                try
                {
                    chromeDriver.FindElement(By.ClassName(className));
                    WaitSpecificTimeoutMethod(ChromeConstants.ultraSmallTimeout);
                    return true;
                }
                catch (Exception)
                {
                    if (DateTime.UtcNow >= targetTime)
                    {
                        return false;
                    }
                }
            }
        }
        private bool WaitElementNameMethod(string elementName, int timeToWait)
        {
            DateTime currentTime = DateTime.UtcNow;
            DateTime targetTime = currentTime.AddSeconds(timeToWait);

            while (true)
            {
                try
                {
                    chromeDriver.FindElement(By.Name(elementName));
                    WaitSpecificTimeoutMethod(ChromeConstants.ultraSmallTimeout);
                    return true;
                }
                catch (Exception)
                {
                    if (DateTime.UtcNow >= targetTime)
                    {
                        return false;
                    }
                }
            }
        }
        private bool WaitElementXPathMethod(string xPathElement, int timeToWait)
        {
            DateTime currentTime = DateTime.UtcNow;
            DateTime targetTime = currentTime.AddSeconds(timeToWait);

            while (true)
            {
                try
                {
                    chromeDriver.FindElement(By.XPath(xPathElement));
                    WaitSpecificTimeoutMethod(ChromeConstants.ultraSmallTimeout);
                    return true;
                }
                catch (Exception)
                {
                    if (DateTime.UtcNow >= targetTime)
                    {
                        return false;
                    }
                }
            }
        }
        private void WaitSpecificTimeoutMethod(int timeToWait)
        {
            DateTime currentTime = DateTime.UtcNow;
            DateTime targetTime = currentTime.AddSeconds(timeToWait);

            while (true)
            {
                if (DateTime.UtcNow >= targetTime)
                {
                    return;
                }
            }
        }

        private void ClickByXPathImmediately(string xpath)
        {
            chromeDriver.FindElement(By.XPath(xpath)).Click();
        }
        private void ClickByIDImmediately(string id)
        {
            chromeDriver.FindElement(By.Id(id)).Click();
        }
        private static void NavigateToURL()
        {
            chromeDriver.Navigate().GoToUrl(ChromeConstants.testURL);
            chromeDriver.Manage().Window.Maximize();
        }

        //Helper methods
        private void SlideByXPath(string sliderXPath, string direction)
        {
            int horizontalOffset = 10;
            int verticalOffset = 5;
            IWebElement slider = chromeDriver.FindElement(By.XPath(sliderXPath));
            int width = slider.Size.Width;
            int height = slider.Size.Height;
            Actions move = new Actions(chromeDriver);

            switch (direction)
            {
                case ChromeConstants.up:
                    move.MoveToElement(slider, 0, ((height * verticalOffset) / 100)).Click();
                    move.Build().Perform();
                    break;
                case ChromeConstants.down:
                    move.MoveToElement(slider, 0, height / 2).Click();
                    move.Build().Perform();
                    break;
                case ChromeConstants.left:
                    move.MoveToElement(slider, (((width / 2) * horizontalOffset) / 100), 0).Click();
                    move.Build().Perform();
                    break;
                case ChromeConstants.right:
                    move.MoveToElement(slider, ((width * horizontalOffset) / 100), 0).Click();
                    move.Build().Perform();
                    break;
                default:
                    break;
            }
        }
    }
}
