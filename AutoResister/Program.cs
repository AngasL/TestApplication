using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoResister
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var option = new ChromeOptions();
            option.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

            var users = new List<User>
            {
                new User { Email="yueguang0@126.com",Password="Infy@123",ConfirmPassword="Infy@123"},
                new User { Email="yueguang1@126.com",Password="Infy@123",ConfirmPassword="Infy@123"},
                new User { Email="yueguang2@126.com",Password="Infy@123",ConfirmPassword="Infy@123"},
                new User { Email="yueguang3@126.com",Password="Infy@123",ConfirmPassword="Infy@123"},
                new User { Email="yueguang4@126.com",Password="Infy@123",ConfirmPassword="Infy@123"},
            };

            foreach (var user in users)
            {
                var driver = new ChromeDriver();
                driver.Url = "http://localhost:30808/Account/Register";

                driver.FindElementByName("Email").SendKeys(user.Email);
                driver.FindElementByName("Password").SendKeys(user.Password);
                driver.FindElementByName("ConfirmPassword").SendKeys(user.Password);
                driver.FindElementByCssSelector(".btn-default").Click();

                //driver.Dispose();
            }


            //driver.Dispose();


            //var httpRequest = WebRequest.Create("http://localhost:30808/Account/Register");
            //httpRequest.Method = "get";
            //var response = httpRequest.GetResponse();
            //using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            //{
            //    var responseString = reader.ReadToEnd();
            //    Console.WriteLine(responseString);
            //}



            //var httpPostRequest = WebRequest.Create("http://localhost:30808/Account/Register");
            //var token = string.Empty;
            //var encoding = Encoding.Default;
            //var postData = @"Email=yueguang0514@126.com&Password=Infy@123&ConfirmPassword=Infy@123" + "&__RequestVerificationToken=" + token;

            //httpPostRequest.Method = "post";
            ////httpRequest.Accept = "text/html, application/xhtml+xml, */*";
            //httpRequest.ContentType = "application/x-www-form-urlencoded";
            //byte[] buffer = encoding.GetBytes(postData);
            //httpPostRequest.ContentLength = buffer.Length;
            //httpPostRequest.GetRequestStream().Write(buffer, 0, buffer.Length);
            //var postResponse = (HttpWebResponse)httpPostRequest.GetResponse();
            //using (StreamReader reader = new StreamReader(postResponse.GetResponseStream()))
            //{
            //    Console.WriteLine(reader.ReadToEnd());

            //}


            // create a new HTTP Web Client that supports cookies
            var webClient = new WebClientWithCookies();

            var test = new List<string>();

            //download my contact page containing the Anti CRSF Token
            var downloadString = webClient.DownloadString("http://localhost:30808/Account/Register");
            //var test = webClient.ResponseHeaders["Set-Cookie"];

            var antiCrsfToken = new Regex("(?<=__RequestVerificationToke).*(value=\".*\")")
                      .Match(downloadString).Groups[1].Value.Split('"')[1];

            var pattern = @"(?:__RequestVerificationToken.*/>)";
            var testRegex = new Regex(pattern);
            //now the Spammer can drown me in spam-spam-spam
            // by scraping my Anti CRSF Token and posting it into my form
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            var response = webClient.UploadString("http://localhost:30808/Account/Register",
                                          "__RequestVerificationToken=" + antiCrsfToken + "&Email=\"yueguang0514@126.com\"" + "&Password=\"Infy@123\"" + "&ConfirmPassword=\"Infy@123\"");

            var readKey = string.Empty;
        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class WebClientWithCookies : WebClient
    {
        private CookieContainer _container = new CookieContainer();

        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;

            if (request != null)
            {
                request.CookieContainer = _container;
            }

            return request;
        }
    }
}
