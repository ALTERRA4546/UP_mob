using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ticket_2
{
    public class StudentRepository
    {
        SQLiteConnection database;

        public StudentRepository(string datapasePath)
        {
            database = new SQLiteConnection(datapasePath);
            database.CreateTable<Student>();
        }

        public IEnumerable<Student> GetItems()
        {
            return database.Table<Student>().ToList();
        }

        public Student GetItem(int id)
        { 
            return database.Get<Student>(id);
        }

        public int DeleteItem(int id)
        {
            return database.Delete<Student>(id);
        }

        public int SaveItem(Student item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            { 
                return database.Insert(item);
            }
        }
    }
}
