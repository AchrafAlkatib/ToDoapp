using System;
using System.Collections.Generic;
using System.Text;
using ToDoapp.Models;

namespace ToDoapp.Data
{
    class PersonSequencer
    {
        private static int personid;
        public static int nextpersonid(int id)
        {
            id++;
            return id;
        }

        public static int reset()
        {
           return 0;
        }




        private static List<Person> peopleList = new List<Person>();

       
}
