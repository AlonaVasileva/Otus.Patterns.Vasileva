using Otus.Patterns.Vasileva;

class Program
{
    static void Main(string[] args)
    {
        var freerideSkis = new Freeride("Salomon", 175, "off-piste", "medium");
        var racingSkis = new Racing("Atomic", 180, "race course", "camber");
        var freestyleSkis = new Freestyle("K2", 165, "park", "step-in");

        // Клонируем объекты
        var freerideSkisClone = freerideSkis.Clone();
        var racingSkisClone = racingSkis.Clone();
        var freestyleSkisClone = freestyleSkis.Clone();
        
        Console.WriteLine("Original Freeride Skis: " + freerideSkis);
        Console.WriteLine("Cloned Freeride Skis: " + freerideSkisClone);
        Console.WriteLine("Original Racing Skis: " + racingSkis);
        Console.WriteLine("Cloned Racing Skis: " + racingSkisClone);
        Console.WriteLine("Original Freestyle Skis: " + freestyleSkis);
        Console.WriteLine("Cloned Freestyle Skis: " + freestyleSkisClone);
        Console.ReadKey();
    }
}