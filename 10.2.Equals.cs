namespace DexTraining
{
    class Person
    {
        string Name { get; set; }
        string Forname { get; set; }
        string Patronymic { get; set; }
        string PlaceOfBirth { get; set; }
        DateTime DateOfBirth { get; set; }
        string PassportNumber { get; set; }

        public Person(string name, string patronymic, string forname, string placeOfBirth, DateTime dateOfBirth, string passportNumber)
        {
            this.Name = name;
            this.Patronymic = patronymic;
            this.Forname = forname;
            this.PlaceOfBirth = placeOfBirth;
            this.DateOfBirth = dateOfBirth;
            this.PassportNumber = passportNumber;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person person && Name == person.Name && Patronymic == person.Patronymic && Forname == person.Forname
                    && PlaceOfBirth == person.PlaceOfBirth && DateOfBirth.Equals(person.DateOfBirth) && PassportNumber == person.PassportNumber)
            { return true; }
            else { return false; }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Patronymic, Forname, PlaceOfBirth, DateOfBirth, PassportNumber);
        }
    }
}
