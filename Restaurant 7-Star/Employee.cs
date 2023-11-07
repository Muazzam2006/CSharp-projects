using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee
    {
        public ChickenOrder chickenRequest;
        public EggOrder eggRequest;
        public bool isFoodPrepared;

        public Employee()
        {
            chickenRequest = null;
            eggRequest = null;
            isFoodPrepared = false;
        }

        public object NewRequest(int quantity, string menuItem)
        {
            if ((chickenRequest != null && chickenRequest.GetQuantity() % 3 == 0) ||
                (eggRequest != null && eggRequest.GetQuantity() % 3 == 0))
            {
                if (menuItem.Equals("Chicken"))
                {
                    eggRequest = new EggOrder(quantity);
                    return eggRequest;
                }
                else if (menuItem.Equals("Egg"))
                {
                    chickenRequest = new ChickenOrder(quantity);
                    return chickenRequest;
                }
            }

            if (menuItem.Equals("Chicken"))
            {
                chickenRequest = new ChickenOrder(quantity);
                return chickenRequest;
            }
            else if (menuItem.Equals("Egg"))
            {
                eggRequest = new EggOrder(quantity);
                return eggRequest;
            }

            return null;
        }

        public object CopyRequest()
        {
            if (chickenRequest == null && eggRequest == null)
            {
                throw new Exception("No request to copy.");
            }

            if (chickenRequest != null)
            {
                return new ChickenOrder(chickenRequest.GetQuantity());
            }
            else if (eggRequest != null)
            {
                return new EggOrder(eggRequest.GetQuantity());
            }

            return null;
        }

        public string Inspect(object Newrequest)
        {
            if (Newrequest is ChickenOrder)
            {
                return "No inspection is required.";
            }
            else if (Newrequest is EggOrder)
            {
                var eggOrder = (EggOrder)Newrequest;
                int? quality = eggOrder.GetQuality();
                return quality.HasValue ? quality.Value.ToString() : "Unknown";
            }

            return "Invalid request.";
        }

        public string PrepareFood(object request)
        {
            if (isFoodPrepared)
            {
                throw new Exception("Food has already been prepared.");
            }

            isFoodPrepared = true;

            if (request is ChickenOrder)
            {
                var chickenOrder = (ChickenOrder)request;
                int quantity = chickenOrder.GetQuantity();

                for (int i = 0; i < quantity; i++)
                {
                    chickenOrder.CutUp();
                }

                chickenOrder.Cook();

                return "Chicken preparation completed.";
            }
            else if (request is EggOrder)
            {
                var eggOrder = (EggOrder)request;
                int quantity = eggOrder.GetQuantity();
                int rottenEggs = 0;

                try
                {
                    for (int i = 0; i < quantity; i++)
                    {
                        eggOrder.Crack();
                        eggOrder.DiscardShell();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Rotten egg! Cannot crack.")
                    {
                        rottenEggs++;
                    }
                }

                eggOrder.Cook();

                return $"Egg preparation completed. Rotten eggs found: {rottenEggs}";
            }

            return "Invalid request.";
        }
    }
}
