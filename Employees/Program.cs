using Employees.Entities;
using System.Globalization;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} employee");
                Console.WriteLine("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("Hours");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.WriteLine("AdditionalCharge:");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcerdEmployee(addCharge, name, hours, valuePerHour));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }
            Console.WriteLine("");
            Console.WriteLine("PAYMENT");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}