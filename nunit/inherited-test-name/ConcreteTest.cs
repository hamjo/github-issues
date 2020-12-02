using NUnit.Framework;

namespace inherited_test_name
{
    public class ConcreteBaseClass
    {
        protected virtual string GetMessage()
        {
            return $"Ran from {nameof(ConcreteBaseClass)}";
        }

        [Test]
        public void ShouldHaveCurrentClassName()
        {
            Assert.Pass(GetMessage());
        }
    }

    public class DerivedConcreteClass : ConcreteBaseClass
    {
        protected override string GetMessage()
        {
            return $"Ran from {nameof(DerivedConcreteClass)}";
        }
    }
}