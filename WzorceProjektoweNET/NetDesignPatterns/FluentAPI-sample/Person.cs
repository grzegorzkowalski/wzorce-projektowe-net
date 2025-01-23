namespace FluentAPI_sample
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person SetFirstName(string firstName)
        {
            FirstName = firstName;
            return this; // Zwracamy bieżący obiekt
        }

        public Person SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public Person SetAge(int age)
        {
            Age = age;
            return this;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}
