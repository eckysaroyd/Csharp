using System;
using System.Collections.Generic;
using System.Text;

namespace employsalaryCalculationAPP
{
    class employer
    {
        string Emp_name;
        int Emp_id;
        double basicSalary;
        double netSalary;
        double totalsalary;
        double tax;
        double ta = 1000;
        double ha = 5000;

        public void getDetails()
        {
            Console.WriteLine("Enter Employee name");
            Emp_name = Console.ReadLine();
            Console.WriteLine("Enter Employee ID");
            Emp_id = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            basicSalary = int.Parse(Console.ReadLine());
            totalsalary = basicSalary + ta + ha;
            if(totalsalary > 25000)
            {
                double deduction = totalsalary * 0.1;
                netSalary = totalsalary - deduction;
                Console.WriteLine("Net salary:" + netSalary);
            }
            else
            {
                Console.WriteLine("Net salary:" + totalsalary);
            }
            
        }
    }
}
