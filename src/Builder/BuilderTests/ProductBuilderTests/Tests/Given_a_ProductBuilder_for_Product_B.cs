using Builder.BuilderTests.ProductBuilderTests.Builders;
using NUnit.Framework;

namespace Builder.BuilderTests.ProductBuilderTests.Tests
{
    [TestFixture]
    public class Given_a_ProductBuilder_for_Product_B
    {
        private ProductBuilder _sut = ProductBuilder.ForProductB();

        [Test]
        public void Then_Build_returns_Product_A()
        {
            Assert.AreEqual("Product B", _sut.Build().Name);
        }
    }
}