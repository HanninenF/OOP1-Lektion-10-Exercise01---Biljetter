namespace P01;

public enum PractiseTask
{
    Biljetter,
}

internal class Program
{
    private static void Main(string[] args)
    {
        Person newPerson = new("Janne", 23);

        string p = newPerson.ToString();

        Console.WriteLine(newPerson);

        PractiseTask exercise = PractiseTask.Biljetter;

        switch (exercise)
        {
            case PractiseTask.Biljetter:
                /* Övning 01 - Biljetter */
                Ticket ticket = new("Konsert", 500);
                /* ticket.PrintInfo(); */

                StudentTicket studentTicket = new("Konsert", 500);
                /*  studentTicket.PrintInfo(); */

                VipTicket vipTicket = new("Konsert", 500, "A12");
                /* vipTicket.PrintInfo(); */

                ChildTicket childTicket = new("Konsert", 500);

                List<Ticket> tickets = [ticket, studentTicket, vipTicket, childTicket];

                int totalPrice = 0;
                foreach (Ticket t in tickets)
                {
                    int price = t.GetPrice();
                    totalPrice += price;
                    t.PrintInfo();
                }
                Console.WriteLine(totalPrice);

                break;
        }
    }

    public class VipTicket(string eventName, int basePrice, string seatNumber)
        : Ticket(eventName, basePrice)
    {
        string SeatNumber { get; set; } = seatNumber;

        public override int GetPrice()
        {
            return BasePrice + 300;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Plats: {SeatNumber}");
        }
    }

    public class Ticket
    {
        public string EventName { get; set; }
        public int BasePrice { get; set; }

        public Ticket(string eventName, int basePrice)
        {
            EventName = eventName;
            BasePrice = basePrice;
        }

        public virtual int GetPrice()
        {
            return BasePrice;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{EventName}: {GetPrice()} kr");
        }
    }

    public class ChildTicket : Ticket
    {
        public ChildTicket(string evenName, int basePrice)
            : base(evenName, basePrice)
        {
            BasePrice = basePrice / 2;
        }
    }

    public class StudentTicket : Ticket
    {
        public StudentTicket(string eventName, int basePrice)
            : base(eventName, basePrice) { }

        public override int GetPrice()
        {
            return BasePrice * 80 / 100;
        }
    }

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

    class Student(string name, int age, string className) : Person(name, age)
    {
        public string ClassName { get; set; } = className;
    }

    /* class Teacher() : Person { } */
}
