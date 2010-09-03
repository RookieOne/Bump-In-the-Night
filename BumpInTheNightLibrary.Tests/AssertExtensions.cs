using NUnit.Framework;

namespace BumpInTheNightLibrary.Tests
{
    public static class AssertExtensions
    {
        public static void ShouldBe<T>(this T actual, T expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}