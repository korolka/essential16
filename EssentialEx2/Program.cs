//Завдання 2

//Створіть клас Block із 4 полями сторін, перевизначте в ньому методи:
//    Equals - здатний порівнювати блоки між собою, ToString - повертає інформацію про поля блоку.
namespace Essential16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(2, 22, 333, 4444);
            Block block2 = new Block(2, 22, 333, 4444);
            Block block3 = new Block(1, 2125, 2, 4444);
            Console.WriteLine("{0} is equal {1}: {2}",block1.GetHashCode(),block2.GetHashCode(),block1.Equals(block2));
            Console.WriteLine("{0} is equal {1}: {2}", block1.GetHashCode(), block3.GetHashCode(), block1.Equals(block3));
            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2.ToString());
            Console.WriteLine(block3.ToString());
            }
    }
}