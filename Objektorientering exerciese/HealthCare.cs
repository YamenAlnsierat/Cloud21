namespace Objektorientering_exerciese
{
    partial class Program
    {
        class HealthCare
        {
            private int step = 0;

            public int steps 
            {
                get
                {
                    return step;
                } 
            }

            public void Step()
            {
                step++;
            }
            public void ResetSteps()
            {
                step = 0;
            }
        }

    }
}
