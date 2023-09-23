using S = System;

public class O
{
    public static void U1() => S.Console.WriteLine(H.A());
    public static void U2() => S.Console.WriteLine(I.B());

    private class H
    {
        public static string A()
        {
            return S.Guid.NewGuid().ToString("N");
        }
    }

    private class I
    {
        public static string B()
        {
            return $"{S.Guid.NewGuid()}{H.A()}{J.C()}";
        }
    }

    private class J
    {
        public static string C()
        {
            return S.Guid.NewGuid().ToString("D");
        }
    }
}