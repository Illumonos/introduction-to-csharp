namespace introduction_to_csharp;

public sealed class DeclarativeTests
{
    [Test]
    public async Task When_Even_Numbers_Equal_Ten_And_Even_Numbers_Are_Totaled_Then_Result_Is_Ten()
    {
        List<int> numbers = [1, 2, 3, 4, 4, 5];

        int evenNumberTotal = numbers
            .Where(number => number % 2 == 0)
            .Sum();

        await Assert.That(evenNumberTotal).IsEqualTo(10);
    }
}