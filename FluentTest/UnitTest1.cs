using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAutomation;

namespace FluentAutoTest
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    [TestInitialize]
    //    public void Init()
    //    {
    //        SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
    //    }

    //    [TestMethod]
    //    public void TestMethod1()
    //    {
    //        new BingSearchPage(this)
    //        .Go()
    //        .Search("FluentAutomation")
    //        .FindResultUrl("http://fluent.stirno.com/blog/FluentAutomation-scriptcs/");
    //    }
    //}

    //public class BingSearchPage : PageObject<BingSearchPage>
    //{
    //    public BingSearchPage(FluentTest test)
    //        : base(test)
    //    {
    //        Url = "http://bing.com/";
    //        At = () => I.Expect.Exists(SearchInput);
    //    }

    //    public BingSearchResultsPage Search(string searchText)
    //    {
    //        I.Enter(searchText).In(SearchInput);
    //        I.Press("{ENTER}");
    //        return this.Switch<BingSearchResultsPage>();
    //    }

    //    private const string SearchInput = "input[title='Enter your search term']";
    //}

    //public class BingSearchResultsPage : PageObject<BingSearchResultsPage>
    //{
    //    public BingSearchResultsPage(FluentTest test)
    //        : base(test)
    //    {
    //        At = () => I.Expect.Exists(SearchResultsContainer);
    //    }

    //    public BingSearchResultsPage FindResultUrl(string url)
    //    {
    //        I.Expect.Exists(string.Format(ResultUrlLink, url));
    //        return this;
    //    }

    //    private const string SearchResultsContainer = "#b_results";
    //    private const string ResultUrlLink = "a[href='{0}']";
    //}

}
