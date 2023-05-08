namespace PersonBuilder;

public class Application
{
    public static void Main()
    {
        Person person = new Person.Builder()
            .WithName("John Doe")
            .WithAge(30)
            .WithAddress("123 Main St")
            .Build();
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    
    public class Builder
    {
        private readonly Person _person = new Person();

        public Builder WithName(string name)
        {
            _person.Name = name;
            return this;
        }

        public Builder WithAge(int age)
        {
            _person.Age = age;
            return this;
        }

        public Builder WithAddress(string address)
        {
            _person.Address = address;
            return this;
        }

        public Person Build()
        {
            return _person;
        }
    }
}