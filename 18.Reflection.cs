namespace DexTraining
{
    public class TriangleExample
    {
        public double Area;
        double sideA;
        private double sideB;
        protected double sideC;
    }


    public class TestObjectCreator
    {
        public TestObjectCreator(string typename)
        {
            ObjectCreator(typename);
        }

        public static dynamic ObjectCreator(string typename)
        {
            var type = typename.GetType();
            return Activator.CreateInstance(type)!;
        }

        public static void GetAllInfo(Type type)
        {
            Console.WriteLine(type.GetFields());
            Console.WriteLine(type.GetProperties());
            Console.WriteLine(type.GetConstructors());
            Console.WriteLine(type.GetMethods());
        }
    }
}
