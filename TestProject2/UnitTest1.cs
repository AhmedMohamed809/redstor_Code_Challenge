using Subermarket;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTotalPriceWithoutSpecialPricing()
        {
            Dictionary<char, int> prices = new Dictionary<char, int>
        {
            { 'A', 60 },
            { 'B', 30 },
            { 'C', 30 },
            { 'D', 25 }
        };

            Dictionary<char, Tuple<int, int>> specialPrices = new Dictionary<char, Tuple<int, int>>();

            Checkout checkout = new Checkout(prices, specialPrices);

            checkout.Scan('A');
            checkout.Scan('B');
            checkout.Scan('C');
            checkout.Scan('D');

            int totalPrice = checkout.Total();

            Assert.AreEqual(145, totalPrice); // Adjust the expected value based on your pricing logic
        }

        [TestMethod]
        public void TestTotalPriceWithSpecialPricing()
        {
            Dictionary<char, int> prices = new Dictionary<char, int>
        {
            { 'A', 60 },
            { 'B', 30 },
            { 'C', 30 },
            { 'D', 25 }
        };


            Dictionary<char, Tuple<int, int>> specialPrices = new Dictionary<char, Tuple<int, int>>
        {
            { 'A', Tuple.Create(3, 150) },
            { 'B', Tuple.Create(2, 45) }
        };


            Checkout checkout = new Checkout(prices, specialPrices);

            checkout.Scan('A');
            checkout.Scan('B');
            checkout.Scan('B');
            

            int totalPrice = checkout.Total();

            Assert.AreEqual(105, totalPrice); // Adjust the expected value based on your pricing logic
        }
    }
}