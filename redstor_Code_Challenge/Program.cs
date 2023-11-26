using System;

namespace Subermarket
{
    public class Checkout
    {
        // this is fields of the checkout class 
        public Dictionary<char, int> prices;
        public Dictionary<char, Tuple<int, int>> specialPrices;
        public Dictionary<char, int> itemCounts;

        // Methods 
        public Checkout(Dictionary<char, int> prices, Dictionary<char, Tuple<int, int>> specialPrices)
        {
            this.prices = prices;
            this.specialPrices = specialPrices;
            this.itemCounts = new Dictionary<char, int>();

        }

        public void Scan(char item)
        {
            if (!prices.ContainsKey(item))
            {
                Console.WriteLine($"Item '{item}' not found in pricing rules. ");

                return; // to stop the program 
            }
            //If the item is not in the dictionary 
            else if (!itemCounts.ContainsKey(item))
            {
                //count is set to 1.
                itemCounts[item] = 1;


            }
            else
            {
                // If the item is already in the dictionary, meaning it has been scanned before, the count for that item is incremented by 1
                itemCounts[item]++;
            }

        }
        public int Total()
        {
            int total = 0;
            foreach (var item in itemCounts.Keys)
            {
                /*
                 *                 Condition 1 
                 *  checks if there is a special pricing rule defined for the current item (item). 
                 * 
                 *                  Condition 2
                 *  checks if the quantity of the current item scanned (itemCounts[item]) is greater than or equal
                 *  to the minimum quantity required for the special pricing rule (specialPrices[item].Item1).
                 */
                if (specialPrices.ContainsKey(item) && itemCounts[item] >= specialPrices[item].Item1)
                {
                    //calculates how many times the minimum quantity for a special set can fit into the total quantity of the item scanned.

                    int specialSets = itemCounts[item] / specialPrices[item].Item1;
                    total += specialSets * specialPrices[item].Item2;

                    // gives the remainder of the division 
                    int remainingItem = itemCounts[item] % specialPrices[item].Item1;
                    total += remainingItem * prices[item];

                }
                else
                {
                    total += itemCounts[item] * prices[item];
                }
            }


            return total;
        }

    }


    class Program
    {
        static void Main()
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

            checkout.Scan('B');
            checkout.Scan('C');
            checkout.Scan('B');







            int total = checkout.Total();

            Console.WriteLine($"Total Price: {total}"); // total price is 75

        }
    }
}