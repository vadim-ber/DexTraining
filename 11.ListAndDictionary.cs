
namespace DexTraining
{
    class PersonDirectory
    {
        Dictionary<PersonD, string> example = new();       

        public PersonDirectory() 
        {
            example.Add(new PersonD("Сергей", "Сергеевич", "Cидоров", "Москва", "2000.12.31", "1вуощ78765"), "Work1");
            example.Add(new PersonD("Василий", "Васильевич", "Васильев", "Казань", "1970.6.11", "f4454523"), "Work2");
            example.Add(new PersonD("Петр", "Петрович", "Петров", "Псков", "1995.1.4", "323124134"), "Work3");

            Console.WriteLine("Введите данные сотрудника:");
            string? Input = Console.ReadLine();

            if (Input != null ) 
            {
                string[] strings = Input.Split(' ', ',');
                if(strings.Length == 6 ) 
                {
                    PersonD p = new(strings[0], strings[1], strings[2], strings[3], strings[4], strings[5]);

                    foreach(var v in example)
                    {
                        if (p.Equals(v.Key))
                        {
                            Console.WriteLine(v.Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неправильный ввод.");
                }
            }
        }

    }

    class PersonD
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Patronymic { get; set; }
        private string PlaceOfBirth { get; set; }
        private string DateOfBirth { get; set; }
        private string PassportNumber { get; set; }

        public PersonD(string name, string patronymic, string surname, string placeOfBirth, string dateOfBirth, string passportNumber)
        {
            this.Name = name;
            this.Patronymic = patronymic;
            this.Surname = surname;
            this.PlaceOfBirth = placeOfBirth;
            this.DateOfBirth = dateOfBirth;
            this.PassportNumber = passportNumber;
        }

        public override bool Equals(object? obj)
        {
            if (obj is PersonD persond && Name == persond.Name && Patronymic == persond.Patronymic && Surname == persond.Surname
                    && PlaceOfBirth == persond.PlaceOfBirth && DateOfBirth.Equals(persond.DateOfBirth) && PassportNumber == persond.PassportNumber)
            { return true; }
            else { return false; }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Patronymic, Surname, PlaceOfBirth, DateOfBirth, PassportNumber);
        }

        public override string ToString()
        {
            return Name + " " + Patronymic + " " + Surname + " " + PlaceOfBirth + " " + DateOfBirth + " " + PassportNumber;
        }
    }
}
