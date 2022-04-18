using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = new string[5, 4]
            {
                {"101","Edvin","SE","10000"},
                {"102","Nichita","SE","20000"},
                {"103","Felix","SSE","30000"},
                {"104","Cristi","SE","40000"},
                {"105","David","SSE","50000"}
            };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
    }
}
