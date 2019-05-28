using System;

namespace MyA1Web.Common
{
    public class ChromeConstants
    {
        //WebDriver
        public const string path = @"C:\AutomationTests\Drivers";

        //Credentials
        public const string UserName = "KaterinaHadjieva";
        public const string Password = "alberto";

        //loadingPage elements
        public const string testURL = "https://www.a1.bg/";
        public const string mainPageName = "Телевизия, интернет, мобилни планове и онлайн магазин - А1";

        ////MainPage - the pucture in the corner, clickin on it you back to the home page
        public const string A1ImageMain = "//*[@id=\"header\"]/div[1]/div[1]/div/div/a/span/img";
        public const string closeClassName = "close";

        ////MainPage - top links
        public const string privateClients = "//*[@id=\"top_menu\"]/ul[1]/li[1]/a";
        public const string businessClients = "//*[@id=\"top_menu\"]/ul[1]/li[2]/a";
        public const string A1Club = "//*[@id=\"top_menu\"]/ul[1]/li[3]/a";
        public const string A1Zone = "//*[@id=\"top_menu\"]/ul[1]/li[4]/a";
        public const string A1Blog = "//*[@id=\"top_menu\"]/ul[1]/li[5]/a";

        public const string mainPageBasket = "//*[@id=\"top_menu\"]/ul[2]/li[1]/a/span";
        public const string mainPageSearching = "//*[@id=\"top_menu\"]/ul[2]/li[2]/a/span";
        public const string mainPageHelp = "//*[@id=\"top_menu\"]/ul[2]/li[3]/a/span";
        public const string ChangeLang = "//*[@id=\"top_menu\"]/ul[2]/li[4]/a/span";
        public const string fieldSearchID = "goog_search_q";
        public const string btnGoogleSearchSubmitID = "goog_search_submit";
        public const string searchingResult = "//*[@id=\"page\"]/main/div/div/div/section/header/h2/em";

        public const string myA1link = "//*[@id=\"header\"]/div[1]/ul/li[2]/a";
        public const string mainPageToggleMenuID = "toggle-menu";

        ////MainPage - at the bottom links 
        public const string mainPageCurrentBill = "//*[@id=\"page\"]/div[2]/div/nav/a[1]";
        public const string mainPageContacts = "//*[@id=\"page\"]/div[2]/div/nav/a[2]";
        public const string mainPageObstiUslovia = "//*[@id=\"page\"]/div[2]/div/nav/a[3]";
        public const string mainPageGdpr = "//*[@id=\"page\"]/div[2]/div/nav/a[4]";
        public const string mainPageCoverMap = "//*[@id=\"page\"]/div[2]/div/nav/a[5]";


        ////MainPage - links under the Private clients
        public const string devicesForPrivate = "//*[@id=\"header\"]/div[1]/nav/ul/li[1]/a";
        public const string packagesForPrivate = "//*[@id=\"header\"]/div[1]/nav/ul/li[2]/a";
        public const string mobilniForPrivate = "//*[@id=\"header\"]/div[1]/nav/ul/li[3]/a";
        public const string homeServicesForPrivate = "//*[@id=\"header\"]/div[1]/nav/ul/li[4]/a";
        public const string digitalForPrivate = "//*[@id=\"header\"]/div[1]/nav/ul/li[5]/a";
        public const string maxSportForPrivate = "//*[@id=\"header\"]/div[1]/nav/ul/li[6]/a";

        ////MainPage - links under Business clients
        public const string devicesForBusiness = "//*[@id=\"header\"]/div[1]/nav/ul/li[1]/a";
        public const string servicesForBusiness = "//*[@id=\"header\"]/div[1]/nav/ul/li[2]/a";
        public const string solutionsForBusiness = "//*[@id=\"header\"]/div[1]/nav/ul/li[3]/a";
        public const string digitalForBusiness = "//*[@id=\"header\"]/div[1]/nav/ul/li[4]/a";
        public const string roamingForBusiness = "//*[@id=\"header\"]/div[1]/nav/ul/li[5]/a";

        //LoginPage
        public const string fieldUsernameID = "username";
        public const string fieldPasswordID = "password";
        public const string fieldEmailID = "email";
        public const string showPasswordClass = "view-password";
        public const string loginBtnName = "submit";
        public const string newRegistration = "/html/body/div/div[1]/div/div/div/div[2]/div/div[1]/form/div/div[4]/div/a";
        public const string passwordForgot = "/html/body/div/div[1]/div/div/div/div[2]/div/div[1]/form/div/div[3]/div[2]/a";
        public const string appStoreAndroidBtn = "/html/body/div/div[1]/div/div/div/div[2]/div/div[2]/div[2]/a[1]";
        public const string appStoreAppleBtn = "/html/body/div/div[1]/div/div/div/div[2]/div/div[2]/div[2]/a[2]";

        //Main page after login
        public const string btnSaveXPath = "//*[@id=\"root\"]/section[1]/div[2]/div[2]/div[1]/div/div/form/div[4]/div/button";
        public const string tableMainCurrentUsageXPath = "//*[@id=\"root\"]/section[1]/div/div[2]/div[1]/section/div/div/div[2]/h5"; //текущо потребление
        public const string tableCurrentDebtXPath = "//*[@id=\"root\"]/section[1]/div/div[2]/div[2]/div[1]/div/h2"; //задължения
        public const string menuMainPageXPath = "//*[@id=\"root\"]/header/section/div/nav/div/ul/li[1]/a"; //начало

        public const string mainPageServiceDetailOpen = "//*[@id=\"root\"]/section[1]/div/div[2]/div[1]/section/div/table/tbody/tr[1]/td[2]/div/div/div/i";
        public const string mainPageTableShortdetail = "//*[@id=\"root\"]/section[1]/div/div[2]/div[1]/section/div/table/tbody/tr[2]/td/div/div/div/div/div[1]/div[1]/div[1]/p"; //текущо потребление
        public const string mainPageTableCurrentBill = "//*[@id=\"root\"]/section[1]/div/div[2]/div[1]/section/div/table/tbody/tr[2]/td/div/div/div/div/div[2]/div/div[1]/h6"; //текуща сметка
        public const string btnPlanDetails = "//*[@id=\"root\"]/section[1]/div/div[2]/div[1]/section/div/table/tbody/tr[2]/td/div/div/div/div/div[2]/div/button";

        public const string topLinkSearch = "//*[@id=\"root\"]/header/div/div/div[1]/div/div[2]/span";


        //MyProfile section
        public const string myProfileXPath = "//*[@id=\"root\"]/header/section/div/nav/div/ul/li[5]/a";
        public const string myProfilePersonalDataXPath = "//*[@id=\"root\"]/section[1]/div[2]/div[1]/ul/li[1]/a";
        public const string myProfileAddressXPath = "//*[@id=\"root\"]/section[1]/div[2]/div[1]/ul/li[2]/a";
        public const string myProfilePassXPath = "//*[@id=\"root\"]/section[1]/div[2]/div[1]/ul/li[3]/a";
        public const string myProfileCodePath = "//*[@id=\"root\"]/section[1]/div[2]/div[1]/ul/li[4]/a";
        public const string myProfileHistoryPath = "//*[@id=\"root\"]/section[1]/div[2]/div[1]/ul/li[5]/a";

        //Personal Data
        public const string addressCityColumnXPath = "//*[@id=\"root\"]/section[1]/div[2]/div[2]/table/thead/tr/th[1]";
        public const string oldPasswordName = "oldPassword";
        public const string newPasswordName = "newPassword";
        public const string securityCodeColumnXPath = "//*[@id=\"root\"]/section[1]/div[2]/div[2]/table/thead/tr/th[1]";
        public const string historyDescriptionColumnXPath = "//*[@id=\"root\"]/section[1]/div[2]/div[2]/table/thead/tr/th[1]";

        //Smetki i fakturi after login 
        public const string billsInvoicesTabXPath = "//*[@id=\"root\"]/header/section/div/nav/div/ul/li[2]/a";
        public const string btnDetailsBillsInvoicesXPath = "//*[@id=\"page\"]/main/div/div[4]/div/div[1]/div[1]/div[2]/a";
        public const string btnSeeMoreInvoiceEmailXPath = "//*[@id=\"page\"]/main/div/div[5]/div/div/div[2]/section/ul/li[2]/a/figure/div";
        public const string invoiceToEmailPageXPath = "//*[@id=\"react-tabs-11\"]/div";


        //Myservices page
        public const string menuMyServicesXPath = "//*[@id=\"root\"]/header/section/div/nav/div/ul/li[3]/a"; //changed on 20.05
        public const string myServiceDetailsOpenXPath = "//*[@id=\"tr-359882203821\"]/td[6]/div/div/div/i";
        public const string myServiceDetailsListedStatusXPath = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[1]/table/tbody/tr[2]/td/div/div/div/div/div[2]/div[2]/section/table/tbody/tr/td[3]/div/div/span";
        public const string manageCreditLimitXPath = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[1]/table/tbody/tr[2]/td/div/div/div/div/div[3]/div[2]/table/tbody/tr[4]/td[2]/div/button";
        public const string increaseCreditLimitPageXPath = "//*[@id=\"root\"]/section[1]/div/div[1]/h2";
        public const string menuContractXPath = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/ul/li[2]/a";
        public const string menuContractTableXPath = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[2]";

        //Details for the plan page -- same as details from my service, but now entering from the main page
        public const string serviceDetailTablePlan = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[1]/table/tbody/tr[2]/td/div/div/div/div/div[2]/div[2]/section/ul/li[3]/div/span[1]";
        public const string serviceDetailTableOtherServices = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[1]/table/tbody/tr[2]/td/div/div/div/div/div[3]/div[2]/table/tbody/tr[2]/td[1]/div/h6";
        public const string serviceDetailTableRoaming = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[1]/table/tbody/tr[2]/td/div/div/div/div/div[4]/div[1]/h5";
        public const string btnSimSettings = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[1]/table/tbody/tr[2]/td/div/div/div/div/div[1]/div[2]/div[1]/button[2]";
        public const string simSettingtableCLIR = "//*[@id=\"root\"]/section[1]/div/div[2]/table/tbody/tr[6]/td[1]/div/div/div";
        public const string btnManageExtras = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[1]/table/tbody/tr[2]/td/div/div/div/div/div[1]/div[2]/div[1]/button[1]";
        public const string manageExtrasPage = "//*[@id=\"root\"]/section[1]/div/div[2]/h3";
        public const string btnServiceRoaming = "//*[@id=\"root\"]/section[1]/div/div[2]/div/div/div/div[1]/table/tbody/tr[2]/td/div/div/div/div/div[1]/div[2]/div[2]/button[3]";
        public const string tableRoamingDetails = "//*[@id=\"root\"]/section[1]/div/div[2]/div[2]/div[2]/li/div/div/div[1]/div[1]";

        public const string slideTableRoamingXPath = "//*[@id=\"root\"]/section[1]/div/div[2]/div[2]/div[1]/label/span";


        //Expected value
        public const string PhoneNumberExpected = "888787887";
        public const string privateExpected = "Частни";
        public const string increaseCreditLimitExpected = "Увеличаване на кредитен лимит";
        public const string activeExpected = "Активен";
        public const string currentDebtExpected = "0.00 лв.";
        public const string currentUsageExpected = "Текущо потребление";
        public const string locationExpected = "Населено място";
        public const string companyOrNameExpected = "Име / Фирма";
        public const string descriptionExpected = "Описание";
        public const string mobileDataMaxSpeedExpected = "Мобилен интернет на максимална скорост";
        public const string currentBillTableExpected = "Текуща сметка";
        public const string detailPlanExpected = "Разговори към А1 (мобилни)";
        public const string detailPlanFavoriteNumberExpected = "Любим номер";
        public const string detailPlanRoamingExpected = "Роуминг";
        public const string detailsSimSettingsExpected = "CLIR";
        public const string tableContractExpeted = "Нямате добавени договори";
        public const string detailsExtraPageExpected = "Мой служебен 0882203821";
        public const string detailsRoamingInfoExpected = "Лимит за пренос на данни в роуминг";
        public const string searchingResultExpected = "“Huawei P10 Lite”";
        public const string pageInvoiceToEmailExpected = "Няма неактивни абонаменти";


        //Timeouts
        public const int ultraSmallTimeout = 2;
        public const int smallTimeout = 7;
        public const int smallMediumTimeout = 10;
        public const int mediumTimeout = 20;
        public const int bigMediumTimeout = 30;
        public const int bigTimeout = 60;
        public const int biggerTimeout = 300;


        //Slider Directions
        public const string up = "up";
        public const string down = "down";
        public const string right = "right";
        public const string left = "left";
    }
}
