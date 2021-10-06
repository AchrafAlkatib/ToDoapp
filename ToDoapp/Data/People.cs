using System;
using System.Collections.Generic;
using System.Text;
using ToDoapp.Models;

namespace ToDoapp.Data
{
    class People
    {


        private static List<Person> peopleList = new List<Person>();
        public int size() { return peopleList.Count; }
        public Person Create(string f, string l)
        {
            Person person = new Person();
            person.Id = peopleList.Count;
            person.FirstName = f;
            person.LastName = l;
            peopleList.Add(person);
            return person;
        }
        public void Clear(List<Person> p)
        {
            while (peopleList.Count != 0)
            {
                p.Remove(p[0]);
            }
        }

        public Person FindById(int id)
        {
            foreach (Person p in peopleList)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }

            return null;
        }



        public List<Person> FindAll()
        {
            return peopleList;
        }

        public void Update(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException();
            }

            Person oldPerson = FindById(person.Id);

            if (oldPerson == null)
            {
                throw new ArgumentNullException();
            }
        }
        public void Delete(int id)
        {
            foreach (Person p in peopleList)
            {
                if (p.Id == id)
                    peopleList.Remove(p);

            }

        }
    }
}