using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeDo.Shared
{
    public class TodoTask
    {
        public TodoTask()
        {
        }

        public TodoTask(int id, string name, string description = "")
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool Completed { get; set; } = false;

        public string Description { get; set; }
    }
}
