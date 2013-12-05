using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Fixtures;

namespace EasyKatas.Tests
{
    [TestFixture]
    class TitleCaseTests
    {
        [Test]
        public void Example1()
        {
            var before = "i lOve to write Or deBug code";
            var after = "I Love to Write or Debug Code";

            var result = EasyKatas.TitleCase.TitleCaseSentence(before);

            Assert.That(result, Is.EqualTo(after));
        }
    }
}
