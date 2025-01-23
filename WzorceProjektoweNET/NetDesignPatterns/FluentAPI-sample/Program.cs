using FluentAPI_sample;

Person person = new Person()
            .SetFirstName("John")
            .SetLastName("Doe")
            .SetAge(30);

Console.WriteLine(person);