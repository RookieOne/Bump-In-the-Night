using System;
using NUnit.Framework;
using BumpInTheNightLibrary.Extensions;

namespace BumpInTheNightLibrary.Tests
{
    public static class Should
    {
        public static void ThrowException<T>(Action action) where T:Exception
        {
            bool threwException = false;
            try
            {
                action();
            }
            catch(T t)
            {
                threwException = true;
            }
            catch(Exception e)
            {
                Assert.Fail("Threw wrong exception. Was expecting {0} but {1} was caught.".FormatWith(typeof(T), e.GetType()));
            }
            Assert.IsTrue(threwException);
        }
    }
}