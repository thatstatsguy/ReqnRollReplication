using Xunit;

namespace ReqnrollQuickstart.Specs;

[Binding]
public class TestStep
{
    [Then(@"the basket price should be \$(.*)")]
    public void ThenTheBasketPriceShouldBe(decimal p0)
    {
        Assert.Equal(1, 2);
    }
}