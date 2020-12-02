using NUnit.Framework;

namespace inherited_test_name
{
    public abstract class AbstractBaseClass
    {
        protected abstract string GetMessage();

        [Test]
        public void ShouldHaveDerivedClassesAsFullName()
        {
            Assert.Pass(GetMessage());
        }
    }

    public class DerivedClass : AbstractBaseClass
    {
        protected override string GetMessage()
        {
            return $"Ran from {nameof(DerivedClass)}";
        }
    }
}