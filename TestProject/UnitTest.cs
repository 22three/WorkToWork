using NUnit.Framework.Internal;
using Solution;
namespace TestProject1
{
    public class Tests
    {
        [TestFixture]
        internal class Sample_Test
        {
            [Test]
            public void SampleShaperTest()
            {
                Assert.That(ShaperTest.AreaResult(2, 2, 2), Is.EqualTo(1.7320508075688772d));
                Assert.That(ShaperTest.AreaResult(3), Is.EqualTo(28.274333882308138d));
            }
        }
    }
}