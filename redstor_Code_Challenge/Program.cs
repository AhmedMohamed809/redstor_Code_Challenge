using System;


 public class Checkout
{
    // this is fields of the checkout class 
    public Dictionary<char, int> prices;
    public Dictionary<char, Tuple<int, int>> specialPrices;
    public Dictionary<char, int> itemCounts;
    

}


class Program
{
    static void Main()
    {
      Dictionary<char,int> prices = new Dictionary<char, int>
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
    }
}