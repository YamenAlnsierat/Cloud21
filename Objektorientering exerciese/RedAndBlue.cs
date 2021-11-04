using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering_exerciese
{
    public class RedAndBlue
    {
        private float red;

        public float Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }
        public float Blue
        {
            get
            {
                return 100 - red;
            }
            set
            {
                red = 100 - value;
            }
        }
    }
}
