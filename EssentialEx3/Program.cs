//Завдання 3

//Створіть клас House з двома полями та властивостями. 
//Створіть два методи Clone() та DeepClone(), які виконують поверхневе 
//    та глибоке копіювання відповідно. Реалізуйте найпростіший спосіб перевірки.
namespace EssentialEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House("Trostanetcka", 50000);
            //House house2 = new House("Verbutskogo", 45000);

            House clone = house.Clone() as House;

            House deepClone = house.DeepClone() as House;


            Console.WriteLine($"Check getHashCode of Cost: {house.Cost.GetHashCode() == deepClone.Cost.GetHashCode()}");
            Console.WriteLine(deepClone.Cost.CostVariable);
            deepClone.Cost.CostVariable = 100000;
            Console.WriteLine(house.Cost.CostVariable);
            Console.WriteLine(deepClone.Cost.CostVariable);

            Console.WriteLine($"Check getHashCode of Cost: {house.Cost.GetHashCode() == clone.Cost.GetHashCode()}");
            Console.WriteLine(clone.Cost.CostVariable);
            clone.Cost.CostVariable = 60000;
            Console.WriteLine(house.Cost.CostVariable);
            Console.WriteLine(clone.Cost.CostVariable);



        }
    }
}