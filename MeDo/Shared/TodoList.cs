using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeDo.Shared
{
    public class TodoList
    {
        public TodoList()
        {
        }

        public TodoList(int id, string name, List<TodoTask> tasks)
        {
            Id = id;
            Name = name;
            Tasks = tasks;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<TodoTask> Tasks { get; set; }

    }
}
