namespace DexTraining
{
    class CircleComparableTest    {
        

        public static void CircleComparableTestStart()
        {
            Circle[] circles = new Circle[10];
            for (int i = 0; i < 10; i++)
            {
                circles[i] = new Circle("Number" + i);
            }
            Array.Sort(circles);
            Array.Reverse(circles);

        }
    }

    class Circle : IComparable<Circle>
    {
        public string Name;
        public int radius;
        public double area;

        public Circle(string name)
        {
            Name = name;
            radius = GetRandomRadius();
            area = Convert.ToDouble(3.14 * Math.Pow(radius, 2));
        }

        private static int GetRandomRadius()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 100);
            return result;
        }

        public int CompareTo(Circle? other)
        {
            if (other != null)
            {
                return area.CompareTo(other.area);
            }            
            else return -1;
        }
    }
}
