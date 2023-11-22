using Builder.BuilderTests.ProductBuilderTests.Builders;
using NUnit.Framework;

namespace Builder.BuilderTests.ProductBuilderTests.Tests
{
    [TestFixture]
    public class Given_a_ProductBuilder_for_Product_A
    {
        private ProductBuilder _sut = ProductBuilder.ForProductA();

        [Test]
        public void Then_Build_returns_Product_A()
        {
            Assert.AreEqual("Product A", _sut.Build().Name);
        }

    }
}