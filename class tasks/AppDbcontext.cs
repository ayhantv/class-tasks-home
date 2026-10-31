using System;
using System.Collections.Generic;
using System.Text;

namespace class_tasks
{
    internal class AppDbcontext
    {
        public Employee[] GetAllWorkers()
        {
            Employee worker1 = new()
            {
                FullName = "Eli",
                Email = "eliyevEli@gmail.com",
                Age = 18,
                salary = 1450,
                adress = "yasamal"
            };

            Employee worker2 = new()
            {
                FullName = "Orxan",
                Email = "RzayevOrxan@gmail.com",
                Age = 23,

                 salary = 1450,
                adress = "RAMANA"
            };

            Employee worker3 = new()
            {
                FullName = "Ferid",
                Email = "abdullayevFerid@gmail.com",
                Age = 25,
                salary = 1450,
                adress = "Razin"
            };

            return new[] { worker1, worker2, worker3 };
        }
    }
}
