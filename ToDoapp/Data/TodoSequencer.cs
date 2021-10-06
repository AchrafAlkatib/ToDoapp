using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoapp.Data
{
    class TodoSequencer
    {
        private static int todoid;
        public static int nexttodoid(int id)
        {
            id++;
            return id;
        }

        public static int reset()
        {
            return 0;
        }
    }
}
