using S = System;

namespace JunkFile2
{
    public class Junker2
    {
        public double CalculateComplexJunk2()
        {
            return Math.Pow(100, 2) - 50.32;
        }

        public void JunkLogger2()
        {
            for (int i = 0; i < 100; i++)
            {
                S.Console.WriteLine($"Logging junk data: {i}");
            }
        }
    }
}
