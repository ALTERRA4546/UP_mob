using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_4
{
    public static class StoredData
    {
        public class Employee
        {
            public string SurnameNamePatromyc { get; set; }
            public string DateOfBirth { get; set; }
            public string City { get; set; }
        }

        public static List<Employee> employees = new List<Employee>();
    }
}
