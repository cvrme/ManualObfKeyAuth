class A
{

    private static string Combine(string part1, string part2)
    {
        return part1 + part2;
    }

    public static string C1()
    {
        return Combine("Enter ", "Key: ");
    }
}

class B
{
    public static string C2()
    {
        return F.C4() + G.C5();
    }
}

class D
{
    public static string C2()
    {
        return new string(new char[] { (char)(70 - 2), (char)(110) });
    }
}

class E
{
    private static string Combine(string part1, string part2)
    {
        return part1 + part2;
    }

    public static string C3()
    {
        return Combine("g", "o") + Combine("o", "d") + "!";
    }
}

class F
{
    public static string C4()
    {
        return new string(new char[] { (char)(104) });
    }
}

class G
{
    public static string C5()
    {
        return new string(new char[] { (char)(105) });
    }
}
