using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PrilukovDA.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            for (int i = 0, x = startValue; x <= stopValue; i++, x++)
            {
                double denominator = 4 * x - 0.5;

                if (Math.Abs(denominator) < 1e-12)
                {
                    result[i] = 0;
                }
                else
                {
                    double value = ((3 * Math.Cos(x)) / denominator) + Math.Sin(x) - 5 * x - 2;
                    result[i] = Math.Round(value, 2);
                }
            }

            return result;
        }
    }
}
