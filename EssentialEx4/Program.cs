//Завдання 4

//Створіть клас, який містить інформацію про дату (день, місяць, рік). 
//    За допомогою механізму перевантаження операторів визначте операцію
//    різниці двох дат (результат у вигляді кількості днів між датами),
//    а також операцію збільшення дати на певне кількість днів. 
namespace EssentialEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(new DateTime(2001, 02, 08));
            Date date2 = new Date(new DateTime(1999, 04, 11));

            Console.WriteLine((date1-date2).Days);   

            Console.WriteLine((date2+669));
        }
    }
}