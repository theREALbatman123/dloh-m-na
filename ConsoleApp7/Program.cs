using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Age = 28 },
            new Employee { Name = "Bob", Age = 35 },
            new Employee { Name = "Charlie", Age = 42 },
            new Employee { Name = "David", Age = 24 },
            new Employee { Name = "Jeremiah", Age = -5},
            new Employee {Name = "Uvuvwevwevwe Onyetrnyevwem Ossas", Age = 846311984}
        };

        var longAssNameMfs = employees
            .Where(e => e.Name.Length > 4)
            .OrderBy(e => e.Name.Length)
            .Select(e => e.Name);

        Console.WriteLine("Dluhý ména EMEFS: ");
        foreach (var name in longAssNameMfs)
        {
            Console.WriteLine(name);
        }
    }
}