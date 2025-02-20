using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_2
{
    [Table("Student")]
    public class Student
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Group { get; set; }
        public string Cource { get; set; }
    }
}
