using System;
using Builder.BuilderTests.ProductBuilderTests.Builders;
using Builder.BuilderTests.ProductBuilderTests.Models;
using NUnit.Framework;

namespace Builder.BuilderTests.ProductBuilderTests.Tests
{
    [TestFixture]
    public class Given_a_ProductBuilder
    {
        private ProductBuilder _sut = new ProductBuilder();

        [Test]
        public void Then_Builder_returns_null()
        {
            Assert.Null(_sut.Build());
        }

        [Test]
        public void Then_for_Product_returns_the_expected_Product()
        {
            var productA = ProductBuilder.ForProduct("A")
                .WithLeftComponent(new Component3())
                .WithRightComponent(new Component1())
                .Build();
            
            Assert.AreEqual("Product A",ProductBuilder.ForProduct("A").Build().Name);
            Assert.IsInstanceOf<Component3>(productA.LeftComponent);
            Assert.IsInstanceOf<Component1>(productA.RightComponent);
            
            var productB = ProductBuilder.ForProduct("B").Build();
            Assert.AreEqual("Product B",ProductBuilder.ForProduct("B").Build().Name);
            Assert.IsInstanceOf<Component2>(productB.LeftComponent);
            Assert.IsInstanceOf<Component3>(productB.RightComponent);
            
            Assert.Throws<ArgumentException>(() => ProductBuilder.ForProduct("C").Build());
        }
    }
}