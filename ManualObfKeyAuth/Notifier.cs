using S = System;

public class F1
{
    public static void R()
    {
        for (int i = 0; i < 100; i++)
        {
            S1();
            S.Console.WriteLine(L.O());
            S.Threading.Thread.Sleep(600);
        }
    }

    private class L
    {
        public static string O()
        {
            return $"{(char)(78)}{(char)(79)}";
        }
    }

    private static void S1() => S.Console.WriteLine(S.Guid.NewGuid().ToString());
}
