using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_1
{
    public static class StudentListTransfer
    {
        public class Student
        {
            public string surname { get; set; }
            public string name { get; set; }
            public string patromic { get; set; }
            public string group { get; set; }
            public string cource { get; set; }
            public string sex { get; set; }
            public string dateOfBirth { get; set; }
        }

        public static List<Student> students = new List<Student>();
    }
}
