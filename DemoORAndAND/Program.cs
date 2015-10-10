using System;

namespace DemoORAndAND
{
    class DemoORAndAND
    {
        static void Main(string[] args)
        {

            const int ZONE1 = 1, ZONE2 = 2;
            const int LOWQUANTITY = 10;
            String inputString;
            int quantity;
            int deleveryZone;


            Console.WriteLine("Delevery is free for zone {0} or zone {1}", ZONE1, ZONE2);
            Console.WriteLine("when the number of boxes is less than {0}", LOWQUANTITY);

            Console.WriteLine("Enter delevery zone ");
            inputString = Console.ReadLine();
            deleveryZone = Convert.ToInt32(inputString);

            Console.WriteLine("Enter the number of boxes in the shipment");
            inputString = Console.ReadLine();
            quantity = Convert.ToInt32(inputString);

            if ((deleveryZone == ZONE1 || deleveryZone == ZONE2) && quantity < LOWQUANTITY)
            {
                Console.WriteLine("Delivery is free");
            }
            else
            {
                Console.WriteLine("A delivery charge applies");
            }

        }
    }
}
