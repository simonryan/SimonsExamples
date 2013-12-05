using NUnit.Framework;

namespace EasyKatas.Tests
{
    [TestFixture]
    public class FindTheSmallestNumber
    {
        [Test]
        public void V1_pass_null_returns_null()
        {
            var result = EasyKatas.FindTheSmallestNumber.GetSmallestValueV1(null);
            Assert.That(result, Is.Null);
        }

        /*[Test]
        public void V1_pass_empty_array_returns_null()
        {
            var result = EasyKatas.FindTheSmallestNumber.GetSmallestValueV1(new float[0]);
            Assert.That(result, Is.Null);
        }*/

        [Test]
        public void V1_returns_smallest()
        {
            var nums = new float[] {1.3f, 2.5f, 5.2f, 0.01f};
            var result = EasyKatas.FindTheSmallestNumber.GetSmallestValueV1(nums);
            Assert.That(result, Is.EqualTo(0.01f));
        }

    }

}
