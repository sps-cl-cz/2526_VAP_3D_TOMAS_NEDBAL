/*double ObsahTrojuhelniku(double vyska, double zakladna)
{
    return 0.5 * zakladna * vyska;
}
*/
/*string FormatujCislo(double cislo)
{
    string text = cislo.ToString();
    string[] casti = text.Split(',');
    string celaCast = text.Split(',')[0]sdadad;
    string desetinnaCast = text .Split(",")[1];
*/
/*
int CountDifferences(string a, string b)
{
    int diff = 0;
    int max = Math.Max(a.Length, b.Length);

    for (int i = 0; i < max; i++)
    {
        char charA = i < a.Length ? a[i] : '\0';

        char charB = i < b.Length ? b[i] : '\0';

        if (charA != charB)
            diff++;
    }

    return diff;
}
*/
/*
string ProhozeniSlov(string text)
{
    string[] slova = text.Split(' ');
    string prvniSlovo = text;
    string druheSlovo = text;
    return druheSlovo + " " + prvniSlovo;
}
string vysledek = ProhozeniSlov("ahoj svete");*/
/*int CifernySoucet(int cislo)
{
    string num = cislo.ToString();
    foreach(char c in num)
    {

    }
}
*/
/*
bool Palindrom(string slovo)
{
    string s = slovo.ToLower().Replace(" ", "");

    char[] chars = s.ToCharArray();
    Array.Reverse(chars);
    string obracene = new string(chars);

    return s == obracene;
}

Console.WriteLine(Palindrom("kajak"));
Console.WriteLine(Palindrom("auto"));

List<double> GetPositiveValues(double[] cisla)
{
    List<double> positives = new List<double>();
    for (int i = 0; i < cisla.Length; i++)
    {
        if (cisla[i] > 0)
        {
            positives.Add(cisla[i]);
        }
    }
    return positives;
}

T Vetsi<T>(T jedna, T dva)
{
    if (jedna.CompareTo(dva) > 0)
        return dva;
    return jedna;
}

string vetsiText = Vetsi("123", "456");
int vetsiCislo = Vetsi(123, 456);

Action<string> a = (text) =>
{
    Console.WriteLine(text);
};

a("Ahoj");
a?.Invoke("Ahoj");

Func<int, string> f = (text) =>
{
    return text.Length;
};

Stack<int> ObracenyZasobnik(Stack<int> vstup);
{
    Stack <int> vystup = new Stack<int>();
    foreach(int hodnota in vystup)
    {
        vystup.Push(hodnota);
    }
    return vystup;
}
*/
/*
static HashSet<string> Prunik(HashSet<string> a, HashSet<string> b)
{
    HashSet<string> vysledek = new HashSet<string>();

    foreach (var item in a)
    {
        if (b.Contains(item))
            vysledek.Add(item);
    }

    return vysledek;
}
*/

Dictionary<string, int> CountWords(Stack<string> inputStack)
{
    Dictionary<string, int> wordCounts = new Dictionary<string, int>();

    while (inputStack.Count > 0)
    {
        string word = inputStack.Pop();

        if (wordCounts.ContainsKey(word))
            wordCounts[word]++;
        else
            wordCounts[word] = 1;
    }

    return wordCounts;
}

List<int> cisla = new List<int>()
{
    0, 1, 2, 3, 4, 5, 6,
};
List<int> cisla_delitelna_tremi = cisla.Where(x => x % 3 == 0).ToList();
int delitelnePeti = cisla.First(x => x % 5 == 0);

List<int> mocniny = cisla.Select(x => x * x).ToList();
int soucet = cisla.Aggregate((acc, cur) => acc + cur);
int soucet2 = cisla.Sum(x => x);