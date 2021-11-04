using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering_exerciese
{
    internal class OneToOneHundred
    {
        private static int number;

        public static int OneTo100
        {
            get
            {
                return number;
            }
            set
            {
                //number = Math.Clamp(value, 0, 100);
                number = value < 0 ? 0 : (value > 100 ? 100 : value);
            }
        }
    }
}
