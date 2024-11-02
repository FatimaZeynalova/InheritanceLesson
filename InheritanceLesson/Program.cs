using InheritanceLesson.Class;

class Program
{
    static void Main(string[] args)
    {
        Uçan qush = new Uçan("Şahin");
        Yürüyən it = new Yürüyən("Pitbull");

        Console.WriteLine(qush.SesCikar());  // "Quş ses çıxarır."
        Console.WriteLine(qush.Uç());         // "Şahin uçur."

        Console.WriteLine(it.SesCikar());     // "It ses çıxarır."
        Console.WriteLine(it.Yürüy());         // "Pitbull yürüyür."
    }
}
