using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PrilukovDA.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisorsCount = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                int divisorsCount = 0;
                for (int d = 1; d <= num; d++)
                {
                    if (num % d == 0)
                    {
                        divisorsCount++;
                    }
                }
                totalDivisorsCount += divisorsCount;
            }

            return totalDivisorsCount;
        }
    }
}
