using S = System;

public class C
{
    public static bool Q1(string m)
    {
        return M.L1(m) && M.L2(m) && M.L3(m) && M.L4(m);
    }
}

public class M
{
    private static S.String Combine(S.String part1, S.String part2, S.String part3)
    {
        return part1 + part2 + part3;
    }

    public static bool L2(string m)
    {
        return m != CombineChars(49, 50, 51, 52); // "1234"
    }

    public static bool L1(S.String input)
    {
        return input.Equals(L3());
    }

    private static S.String L3()
    {
        return Combine("1", "2", "3");
    }

    public static bool L3(string m)
    {
        return m != CombineChars(51, 50, 49); // "321"
    }

    public static bool L4(string m)
    {
        return m != CombineChars(49, 49, 49); // "111"
    }

    public static void P1() => S.Console.WriteLine(K.N());

    private class K
    {
        public static string N()
        {
            return S.Guid.NewGuid().ToString();
        }
    }

    private static string CombineChars(params int[] values)
    {
        char[] result = new char[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            result[i] = (char)values[i];
        }
        return new string(result);
    }
}
