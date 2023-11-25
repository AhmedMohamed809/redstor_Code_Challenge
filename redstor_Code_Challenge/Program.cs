using System;


 public class Checkout
{
    // this is fields of this checkout class 
    public Dictionary<char, int> prices;
    public Dictionary<char, Tuple<int, int>> specialPrices;
    public Dictionary<char, int> itemCounts;

}


class Program
{
static void Main(string[] args)
    {
        Console.WriteLine("Hi ");
    }
}