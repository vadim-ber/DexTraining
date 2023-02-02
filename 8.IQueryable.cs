namespace DexTraining
{
    internal class IQueryableExampleTest
    {
        public static void TestStart()
        {
            Example[] examples = new Example[100];
            for (int i = 0; i < 100; i++)
            {
                examples[i] = new Example("Number" + i);
            }

            //Выборка по первой букве в string объекта Example c сортировкой по возрастанию            
            var selectedExamples1 = examples.Where(p => p.a.ToUpper().StartsWith("A")).OrderBy(p => p.a);
            foreach (Example e in selectedExamples1)
            {
                Console.WriteLine(e.Name + " " + e.a);
            }                          
            Console.WriteLine();

            //Группировка объектов по статусу bool
            var selectedExamples2 = examples.GroupBy(p => p.c);            
            foreach (var c in selectedExamples2)
            {
                Console.WriteLine(c.Key);

                foreach (var name in c)
                {
                   Console.WriteLine(name.Name);
                }
                Console.WriteLine();
            }

            

            //Проверка, равно ли значение int всех объектов 1
            var selectedExamples3 = examples.All(p => p.b == 1);
            Console.WriteLine("Значение int всех объектов равно 1: " + selectedExamples3);

            //Проверка, равно ли значение int хотя бы одного объекта 1
            var selectedExamples4 = examples.Any(p => p.b == 1);
            Console.WriteLine("Значение int хотя бы одного объекта равно 1: " + selectedExamples4);

            Console.WriteLine();

            //sum, min, max
            Console.WriteLine("Сумма всех int всех объектов: " + examples.Sum(p => p.b));
            Console.WriteLine("Min среди всех int всех объектов: " + examples.Min(p => p.b));
            Console.WriteLine("Max среди всех int всех объектов: " + examples.Max(p => p.b));
        }
    }

    public class Example
    {
        public string Name;
        public string a;
        public int b;
        public bool c;
        public DateTime d;

        public Example(string name)
        {
            Name = name;
            a = getRandomString();
            b = getRandomInt();
            c = getRandomBool();
            d = GetRandomDateTime();

        }

        protected static string getRandomString()
        {
            string result = "";
            Random rnd = new();
            int size = rnd.Next(2, 10);
            for (int i = 1; i < size; i++)
            {
                result += (char)rnd.Next(65, 90);
            }
            return result;
        }

        protected static int getRandomInt()
        {
            Random rnd = new();
            int result = rnd.Next(0, 99);
            return result;
        }

        protected static bool getRandomBool()
        {
            bool result;
            Random rnd = new();
            int temp = rnd.Next(0, 2);
            if (temp == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        protected static DateTime GetRandomDateTime()
        {
            Random rnd = new();
            DateTime start = new(2000, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}

