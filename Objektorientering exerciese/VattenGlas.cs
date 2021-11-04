using System;

namespace Objektorientering_exerciese
{
    class VattenGlas
    {
        private bool isFilld=false;
        private bool isBroken=false;

        public void FillGlas()
        {
            if (isBroken)
            {
                Console.WriteLine("The glas cant be filled, its broken");
            }
            else
            {
                if (isFilld)
                {
                    Console.WriteLine("The glas is full");
                }
                else
                {                    
                Console.WriteLine("The glas is filling with watar");
                    isFilld = true;
                }                    
            }
        }

        public void EmbtyGlas()
        {
            if (isBroken && isFilld)
            {
                Console.WriteLine("The glas is broken and alrady embty and watar on floor!");
            }
            else if (isBroken && !isFilld)
            {
                Console.WriteLine("The glas is broken and alrady embty!");

            }
            else
            {
                if (isFilld)
                {
                    Console.WriteLine("The glas empted");
                    isFilld = false;
                }
                else
                {
                    Console.WriteLine("The glas is already embty");
                }
            }
        }

        public void BreakGlas() 
        {
            if (!isBroken)
            {
                Console.WriteLine("The glas is got broken! ");
                isBroken = true;
            }
        }
    }
}
