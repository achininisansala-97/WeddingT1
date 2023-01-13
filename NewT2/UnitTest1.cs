using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace NewT2
{
    public class UnitTest1
    {
        private IWebDriver driver;
        String url = "https://ims4l-uat.i-wonder.co.uk/product-select";

        public UnitTest1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Fact]
        public void Wedding()
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(3000);

            IWebElement CookiesPopup = driver.FindElement(By.Id("accept-and-continue"));
            CookiesPopup.Click();

            //Ceremony

            //wedding product selection
            IWebElement Product = driver.FindElement(By.XPath("/html/body/app-root/div/div[1]/iw-product-select/div/div/div[13]/div/div[1]"));
            Product.Click();
            Thread.Sleep(3000);


            //What type of ceremony is it ?
            var ceremony = driver.FindElement(By.Id("select-input_ceremony_typeId"));
            var selectElement = new SelectElement(ceremony);
            selectElement.SelectByValue("1: 01");

            //What date is the ceremony ?
            IWebElement d = driver.FindElement(By.XPath("//input[@id='date-select_ceremony_ceremonyVenue_scheduledDate_day_input']"));
            d.SendKeys("20");

            IWebElement m = driver.FindElement(By.XPath("//input[@id='date-select_ceremony_ceremonyVenue_scheduledDate_month_input']"));
            m.SendKeys("01");

            IWebElement y = driver.FindElement(By.XPath("//input[@id='date-select_ceremony_ceremonyVenue_scheduledDate_year_input']"));
            y.SendKeys("2023");

            IWebElement popup2 = driver.FindElement(By.XPath("/html/body/app-root/div/div[1]/iw-wedding-ceremony/iw-modal[2]/div[2]/div[3]/div/div/button"));
            popup2.Click();
            Thread.Sleep(1000);


            //Will there be a reception?
            IWebElement CeremonyDateOk = driver.FindElement(By.XPath("//label[@id='bool-input_receptionQuestion_true_button']"));
            CeremonyDateOk.Click();
            Thread.Sleep(1000);


            //What is the total cost of your ceremony/reception?
            IWebElement tc = driver.FindElement(By.XPath("//input[@id='text-input_ceremony_totalCost']"));
            tc.SendKeys("2000");
            Thread.Sleep(1000);



            //Are the ceremony and reception being held on the same date?
            IWebElement crheld = driver.FindElement(By.Id("bool-input_ceremonyReceptionSameDate_true_button"));
            crheld.Click();
            Thread.Sleep(1000);


            //Is the ceremony and reception taking place in the UK?
            IWebElement place = driver.FindElement(By.Id("bool-input_ukCeremony_true_button"));
            place.Click();
            Thread.Sleep(1000);


            //Do you require Rearrangement cover ?
            IWebElement rearrangement = driver.FindElement(By.XPath("//label[@id='bool-input_cover_rearrangementCover_true_button']"));
            rearrangement.Click();
            Thread.Sleep(1000);


            //Would you like to add public liability cover?
            IWebElement liability = driver.FindElement(By.XPath("//label[@id='bool-input_publicLiabilityCover_true_button']"));
            liability.Click();

            //How many guests will be attending in total ?
            var attending = driver.FindElement(By.Id("select-input_cover_numberOfGuestsId"));
            var selectElement1 = new SelectElement(attending);
            selectElement1.SelectByValue("1: 01");
            Thread.Sleep(1000);


            //Would you like to add marquee cover?
            IWebElement marquee = driver.FindElement(By.XPath("//label[@id='bool-input_marqueeCover_true_button']"));
            marquee.Click();

            //How many days do you require cover for the marquee?
            IWebElement cmarquee = driver.FindElement(By.XPath("//input[@id='text-input_marqueeCoverDuration']"));
            cmarquee.SendKeys("2");

            //How much cover do you need?
            var hcover = driver.FindElement(By.Id("select-input_marqueeCoverAmount"));
            var selectElement2 = new SelectElement(hcover);
            selectElement2.SelectByValue("1: 01");

            //Would you like to add cover for ceremonial swords?
            IWebElement swords = driver.FindElement(By.XPath("//label[@id='bool-input_cover_ceremonialSwords_true_button']"));
            swords.Click();

            //nextpage1
            IWebElement nextpage1 = driver.FindElement(By.XPath("/html/body/app-root/div/div[1]/iw-wedding-ceremony/div/form/div[2]/div/button"));
            nextpage1.Click();

            //

            //Are you purchasing this policy for yourself or on behalf of the participants ?
            IWebElement participants = driver.FindElement(By.XPath("//button[@id='select-input_policyholder_button_false']"));
            participants.Click();

            //What is your first name?
            IWebElement fname = driver.FindElement(By.XPath("//input[@id='text-input_proposer_forename']"));
            fname.SendKeys("Achini");
            Thread.Sleep(1000);

            //What is your surname?
            IWebElement sname = driver.FindElement(By.XPath("//input[@id='text-input_proposer_surname']"));
            sname.SendKeys("Seneviratne");
            Thread.Sleep(1000);

            //What is your date of birth?
            IWebElement dobd = driver.FindElement(By.XPath("//input[@id='date-select_proposer_dateOfBirth_day_input']"));
            dobd.SendKeys("31");
            

            IWebElement dobm = driver.FindElement(By.XPath("//input[@id='date-select_proposer_dateOfBirth_month_input']"));
            dobm.SendKeys("08");
          

            IWebElement doby = driver.FindElement(By.XPath("//input[@id='date-select_proposer_dateOfBirth_year_input']"));
            doby.SendKeys("1997");
            Thread.Sleep(1000);

            //Are you a UK resident and registered with a GP?
            IWebElement GP = driver.FindElement(By.XPath("//label[@id='bool-input_proposer_ukResGPReg_true_button']"));
            GP.Click();

            //What is your partner's surname?
            IWebElement pfname = driver.FindElement(By.XPath("//input[@id='text-input_proposer_partnerForename']"));
            pfname.SendKeys("Pramu");
            Thread.Sleep(1000);

            //What is your partner's surname?
            IWebElement psname = driver.FindElement(By.XPath("//input[@id='text-input_proposer_partnerSurname']"));
            psname.SendKeys("Seneviratne");
            Thread.Sleep(1000);

            //What is your partner's date of birth?
            IWebElement pdobd = driver.FindElement(By.XPath("//input[@id='date-select_proposer_partnerDateOfBirth_day_input']"));
            pdobd.SendKeys("11");


            IWebElement pdobm = driver.FindElement(By.XPath("//input[@id='date-select_proposer_partnerDateOfBirth_month_input']"));
            pdobm.SendKeys("07");


            IWebElement pdoby = driver.FindElement(By.XPath("//input[@id='date-select_proposer_partnerDateOfBirth_year_input']"));
            pdoby.SendKeys("1997");
            Thread.Sleep(1000);

            //Are they a UK resident and registered with a GP?
            IWebElement president = driver.FindElement(By.XPath("//label[@id='bool-input_proposer_partnerUKResGPReg_true_button']"));
            president.Click();

            //I confirm that the statements above are correct
            IWebElement confirm = driver.FindElement(By.XPath("/html/body/app-root/div/div[1]/iw-wedding-policyholder/div/form/div/div[1]/div/p/input"));
            confirm.Click();

            //What is your house number/name (optional)?
            IWebElement HouseNo = driver.FindElement(By.XPath("//input[@id='text-input_houseSearch']"));
            HouseNo.SendKeys("3");

            //What is your postcode ?
            IWebElement Postcode = driver.FindElement(By.XPath("//input[@id='text-input_postCode']"));
            Postcode.SendKeys("SO21 3FL");

            IWebElement btnSearch = driver.FindElement(By.XPath("//button[text()='Search ']"));
            btnSearch.Click();
            Thread.Sleep(2000);

            IWebElement AddressSelection = driver.FindElement(By.XPath("//div[text()=' I-Wonder, 3 Warren Farm Barns, Andover Road, Micheldever Station, Winchester, SO21 3FL ']"));
            AddressSelection.Click();

            //What is your main telephone number (optional)?
            IWebElement telephone = driver.FindElement(By.XPath("//input[@id='text-input_proposer_telephones']"));
            telephone.SendKeys("0761187129");

            //Our insurance partners can help you get the right cover at the right price, the providers with the two cheapest quotes may wish to discuss your cover with you. Are you happy to be contacted?
            IWebElement help = driver.FindElement(By.XPath("//label[@id='bool-input_proposer_contactPreferences_allowMailings_true_button']"));
            help.Click();

            //What is your email address?
            IWebElement email = driver.FindElement(By.XPath("//input[@id='text-input_email']"));
            email.SendKeys("achiniiwonder@gmail.com");
            Thread.Sleep(2000);

            //Please enter a password
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\"text-input_password\"]"));
            password.SendKeys("AchiniS@97");
            Thread.Sleep(2000);

            IWebElement login = driver.FindElement(By.XPath("//*[@id=\"question_userRegistration\"]/iw-user-registration/div[1]/iw-question-wrapper/div/div[2]/iw-text-input/div/div[2]/button"));
            login.Click();
            Thread.Sleep(1000);


            IWebElement getQuote = driver.FindElement(By.XPath("/html/body/app-root/div/div[1]/iw-wedding-policyholder/div/form/div/div[2]/div/button"));
            getQuote.Click();
            Thread.Sleep(1000);

        }

    }
}