namespace P01;

class Student(string name, int age, string className) : Person(name, age)
{
  public string ClassName { get; set; } = className;
}
