using System.Collections;

namespace DexTraining
{
    class EnumerableExample
    {
        static void TestExample()
        {
            Year year = new Year();
            Console.WriteLine("Перебор с помощью интерфейса IEnumerable: ");
            foreach (var month in year)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine();
            Console.WriteLine("Перебор с помощью IEnumerator: ");
            IEnumerator monthsEnum = year.months.GetEnumerator();
            while (monthsEnum.MoveNext())
            {
                string month = (string)monthsEnum.Current;
                Console.WriteLine(month);
            }
        }
    }

    class Year : IEnumerable
    {
        public string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public IEnumerator GetEnumerator() => months.GetEnumerator();
    }
}
