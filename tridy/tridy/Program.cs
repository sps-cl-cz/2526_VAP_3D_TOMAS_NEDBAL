/*class Program {
    public static int cislo = 0;
    int cislo2 = 0;
    static void Main(string[] args)
    {
        Program program = new Program();
        Program program1 = new Program();
        cislo++;
        Program.cislo++;
        Console.WriteLine(cislo);
    }
}
*/
class Program
{
    public static int cislo = 0;
    int cislo2 = 0;
    static void Main(string[] args)
    {
        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }
    }
}