using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Löner
{
    class Personalregister
    {
        public List<string> employeesandsalaries;

        public Personalregister()
        {
            employeesandsalaries = new List<string>();
        }
        public void AddEmployeeAndSalary(string employeeAndSalary)
        {
            Console.WriteLine("Vill du lägga till anställd och lön? Svara Ja eller Nej och tryck enter:");
            string jaEllerNej;
            string v = Console.ReadLine(jaEllerNej);

            if (jaEllerNej = Ja)
                {
                    Console.WriteLine("Skriv namn och lön och tryck enter:");
                Console.ReadLine(employeeAndSalary);
                    employeesandsalaries.Add(employeeAndSalary);
                }
            else
                        {
                            Console.WriteLine("Vill du se personalregistret? Svara Ja eller Nej och tryck enter:");
                            Console.ReadLine(jaEllerNej);
                            if (jaEllerNej = Ja)
                              {
                                 Console.Write(employeesandsalaries);
                              }
                             else
                                 Console.WriteLine("Då är vi klara!");
            }

            
        }
 //       List<string> employeesandsalaries;

    }
}
