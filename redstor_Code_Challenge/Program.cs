using System;


 public class Checkout
{
    // this is fields of the checkout class 
    public Dictionary<char, int> prices;
    public Dictionary<char, Tuple<int, int>> specialPrices;
    public Dictionary<char, int> itemCounts;

    // Methods 
    public Checkout(Dictionary<char,int> prices , Dictionary<char,Tuple<int,int>> specialPrices) 
    {
       this.prices = prices;
       this.specialPrices = specialPrices;
       this.itemCounts = new Dictionary<char, int>();
    
    }
    
    public void Scan(char item)
    {
        if(!prices.ContainsKey(item))
        {
            Console.WriteLine($"Item '{item}' not found in pricing rules. ");

            return; // to stop the program 
        }
        else if(!itemCounts.ContainsKey(item))
        {

            itemCounts[item] = 1;
         
        
        }else
        {
            itemCounts[item]++;
        }
       
    }
  
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

        Checkout checkout=new Checkout(prices, specialPrices);

        checkout.Scan('A');
       
    }
}