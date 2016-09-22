using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace FluentTest
{
    [TestClass]
    public class FluentAssertion
    {
        [TestMethod]
        public void ShouldBeEqualToTest()
        {
            // Arrage
            var nameList1 = new List<string>
            {
                "Sam", "Dorothy"
            };
            var nameList2 = new List<string>
            {
                "Dorothy","Sam"
            };

            // Action

            // Assert

            nameList1.ShouldBeEquivalentTo<List<string>>(nameList2);
            nameList1.ShouldAllBeEquivalentTo<string>(nameList2);
        }
    }
}
