using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ChickenOrder
    {
        private int quantity;

        public ChickenOrder(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void CutUp()
        {
            Console.WriteLine("Cutting up the chicken.");
        }

        public void Cook()
        {
            Console.WriteLine("Cooking the chicken.");
        }
    }
}
