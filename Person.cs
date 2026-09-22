namespace P01;

class Person
{
  public string Name { get; set; }
  public int Age { get; set; }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public virtual void ShowContactInfo()
  {
    Console.WriteLine($"NAME: {Name}, AGE: {Age}");
  }
}
