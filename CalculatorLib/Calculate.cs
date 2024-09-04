namespace Sparky
{
    public class Calculate
    {

        public List<int> NumberRange = new();
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }

        public double Divide(double x, double y) {
            double z =0.0;
            try
            {
                 z = x / y;
            }
            catch (Exception e)
            {
               
            }
            return z; 
        }
        public double multiply(double x, double y) 
        { 
            return x * y;
        }

        public List<int> GetOddRange(int min, int max)
        {
            NumberRange.Clear();
            for (int i = min; i <= max; i++)
            {
                if(i % 2 != 0)
                {
                    NumberRange.Add(i);
                }
                
            }
            return NumberRange;

        }

    }
}
