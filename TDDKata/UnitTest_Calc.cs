using TDDKataCalc;

namespace TDDKata
{
    public class UnitTest_Calc
    {
        private readonly Calc calculator = new();

        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            int sum = calculator.Add("");
            Assert.Equal(0, sum);
        }

        [Fact]
        public void Add_SingleNumberString_ReturnsNumber()
        {
            int sum = calculator.Add("1");
            Assert.Equal(1, sum);
        }

        [Fact]
        public void Add_TwoNumbersString_ReturnsSum()
        {
            int sum = calculator.Add("1,2");
            Assert.Equal(3, sum);
        }

        [Fact]
        public void Add_MultipleNumbersString_ReturnsSum()
        {
            int sum = calculator.Add("1,2,3,4,5");
            Assert.Equal(15, sum);
        }

        [Fact]
        public void Add_NegativeNumberString_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Add("-1"));
        }

        [Fact]
        public void Add_NegativeNumbersString_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Add("1,-2,3,-4,5"));
        }
    }
}