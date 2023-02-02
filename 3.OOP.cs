namespace DexTraining
{
    //Реализовать несколько классов, с глубиной иерархии 2-3, с применением всех принципов ООП
       
        public abstract class Animal
        {
            protected string? Kind { get; set; }
            protected double Size { get; set; }
            protected string? Colour { get; set; }

            public virtual void Move()
            {
                
            }
        }

        public class Wolf : Animal
        {
            public Wolf()
            {
                Kind = "Wolf";
                Size = 1.0;
                Colour = "Gray";
            }
            public override void Move()
            {
            Run();
            }

        static void Run()
            {
                
            }
        }

        public class Dog : Wolf
        {
            public Dog()
            {
                Kind = "Dog";
                Size = 0.8;
                Colour = "Brown";
            }

        }

        public class SeaTurtle : Animal
        {
            public SeaTurtle()
            {
                Kind = "Sea turtle";
                Size = 0.5;
                Colour = "Green";
            }
            public override void Move()
            {
                Swim();
            }
            void Swim()
            {
                
            }
        }    
}