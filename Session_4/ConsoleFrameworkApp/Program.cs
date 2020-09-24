using FrameworkLibraryApp;
using System;
using System.Windows.Forms;

namespace ConsoleFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.employeeId = 63;
            Console.WriteLine(employee.employeeId);
            MessageBox.Show(employee.employeeId.ToString());
            Console.ReadLine();
        }
    }
}
