namespace Builder.BuilderTests.ProductBuilderTests.Builders
{
    public abstract class Builder<T>
    {
         protected T Value { get; set; }
         public virtual T Build() => Value;
    }
}