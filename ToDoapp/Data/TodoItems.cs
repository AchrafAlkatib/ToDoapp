using System;
using System.Collections.Generic;
using System.Text;
using ToDoapp.Models;

namespace ToDoapp.Data
{
    class TodoItems
    {


        private static List<Todo> todoList = new List<Todo>();
        public int size() { return todoList.Count; }
        public Todo Create(Person person)
        {
            Todo todo = new Todo(todoList.Count,"");
            todo.assignee = person;
            todoList.Add(todo);
            return todo;
        }
        public void Clear(List<Todo> p)
        {
            while (todoList.Count != 0)
            {
                p.Remove(p[0]);
            }
        }

        public Todo FindById(int id)
        {
            foreach (Todo p in todoList)
            {
                if (p.id == id)
                {
                    return p;
                }
            }

            return null;
        }



        public List<Todo> FindAll()
        {
            return todoList;
        }

        public void Update(Todo todo)
        {
            if (todo == null)
            {
                throw new ArgumentNullException();
            }

            Todo oldTodo = FindById(todo.id);

            if (oldTodo == null)
            {
                throw new ArgumentNullException();
            }
        }
        public List<Todo> FindByDoneStatus(bool doneStatus)
        {
            List<Todo> li = new List<Todo>();
            foreach (Todo t in todoList)
            {
                if (t.done == doneStatus)
                    li.Add(t);
                
                    
            }
            return li;
        }
        public List<Todo> FindByAssignee(int personid)
        {
            List<Todo> li = new List<Todo>();
            foreach (Todo t in todoList)
            {
                if (t.assignee.Id == personid)
                    li.Add(t);


            }
            return li;
        }
        public List<Todo> FindByAssignee(Person assignee)
        {
            List<Todo> li = new List<Todo>();
            foreach (Todo t in todoList)
            {
                if (t.assignee == assignee)
                    li.Add(t);


            }
            return li;
        }
        public List<Todo> FindUnassigned()
        {
            List<Todo> li = new List<Todo>();
            foreach (Todo t in todoList)
            {
                if (t.assignee == null)
                    li.Add(t);


            }
            return li;
        }
        public void Delete(int id)
        {
            foreach (Todo t in todoList)
            {
                if (t.id == id)
                    todoList.Remove(t);

            }
                              
        }

    }
}
