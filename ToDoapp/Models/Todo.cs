using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoapp.Models
{
    class Todo
    {
        public Todo(int _id, string _description)
        {
            id = _id;
            description = _description;
            done = false;
            assignee = null;
            
        }
        public int id { get; }
        public string description;
        public bool done;
        public Person assignee;
        

        public virtual string Info()
        {
            return "";
           // return $"--- {this.GetType().Firstname, Last name} Info ---\nName: {Firstname, LastName}\nID: {ID}";
        }
    }
}
