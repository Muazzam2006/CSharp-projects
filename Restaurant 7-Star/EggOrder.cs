using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EggOrder
    {
        private int quantity;
        private int? quality;

        public EggOrder(int quantity)
        {
            this.quantity = quantity;
            this.quality = GetQuality();
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public int? GetQuality()
        {
            Random rand = new Random();
            quality = rand.Next(1, 101);
            return quality;
        }

        public void Crack()
        {
            if (quality < 25)
            {
                throw new Exception("Rotten egg found!");
            }
            Console.WriteLine("Cracking the egg.");
        }

        public void DiscardShell()
        {
            Console.WriteLine("Discarding the egg shell.");
        }

        public void Cook()
        {
            Console.WriteLine("Cooking the eggs.");
        }
    }
}
