//Завдання 6

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Створіть структуру, яка описує точку у тривимірній системі координат.
//    Організуйте можливість складання двох точок через використання навантаження оператора +.
namespace EssentialEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 2, 3);
            Point point2 = new Point(6, 2, 8);
            Point point3 = new Point(8, 1, 3);

            Console.WriteLine(point1+point2+ point3);  

        }
    }
}