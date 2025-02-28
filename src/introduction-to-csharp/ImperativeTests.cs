namespace introduction_to_csharp;

public sealed class ImperativeTests
{
    [Test]
    public async Task When_Even_Numbers_Equal_Ten_And_Even_Numbers_Are_Totaled_Then_Result_Is_Ten()
    {
        List<int> numbers = [1, 2, 3, 4, 4, 5];

        int evenNumberTotal = 0;

        for (int n = 0; n < numbers.Count; n++)
        {
            int number = numbers[n];
            if (number % 2 == 0)
            {
                evenNumberTotal += number;
            }
        }

        await Assert.That(evenNumberTotal).IsEqualTo(10);
    }
}