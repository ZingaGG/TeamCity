using NUnit.Framework;


[TestFixture]
public class ProgramTests
{
    [Test]
    public void TestIsPrimeWithPrimeNumber()
    {
        int primeNumber = 7;

        bool result = Program.IsPrime(primeNumber);

        Assert.IsTrue(result);
    }

    [Test]
    public void TestIsPrimeWithNonPrimeNumber()
    {
        int nonPrimeNumber = 6;

        bool result = Program.IsPrime(nonPrimeNumber);

        Assert.IsFalse(result);
    }

    [Test]
    public void TestIsPrimeWithZero()
    {
        int zero = 0;

        bool result = Program.IsPrime(zero);

        Assert.IsFalse(result);
    }

    [Test]
    public void TestIsPrimeWithNegativeNumber()
    {
        int negativeNumber = -5;

        bool result = Program.IsPrime(negativeNumber);

        Assert.IsFalse(result);
    }

    [Test]
    public void TestIsPrimeWithTwo()
    {
        int two = 2;

        bool result = Program.IsPrime(two);

        Assert.IsTrue(result);
    }
}
